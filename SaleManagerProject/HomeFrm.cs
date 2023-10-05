using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
using CSharpCourseFinalProject;

namespace SaleManagerProject
{
    public enum ActionType
    {
        NORMAL, SEARCH
    }
    public interface IViewController
    {
        void AddNewItem<T> (T item);
        void UpdateItem<T> (T updatedItem);

    }
    public partial class HomeFrm : Form, IViewController
    {
        private static string DATE_FORMAT = "dd/MM/yyyy";
        private static string DATE_TIME_FORMAT = "dd/MM/yyyy HH:mm:ss";
        private List<Item> _items;
        private List<Discount> _discounts;
        private List<Customer> _customers;
        private CommonController _commonController;
        private ItemController _itemController;
        private List<Item> _searchItemResults;
        private ActionType _actionType;
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
            _items = new List<Item>();
            _discounts = new List<Discount>();
            _customers = new List<Customer>();
            _commonController = new CommonController();
            _itemController = new ItemController();
            _actionType= ActionType.NORMAL;
            //nạp dữ liệu
            _items.AddRange(Utils.CreateFakeItems());
            //Hien thi
            ShowItems(_items);
        }

        private void BtnAddNewClick(object sender, EventArgs e)
        {
            CenterToScreen();
            if (sender.Equals(btnAddNewItem))
            {
                var childView = new AddEditItemFrm(this, _discounts);
                childView.Show();
            }
        }

        public void AddNewItem<T>(T item)
        {
            if (typeof(T) == typeof(Item))
            {
                var newItem = item as Item;
                _commonController.AddNewItem(_items, newItem);
                tblItem.Rows.Add(new object[]
                {
                    newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                    newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"), $"{newItem.Price:N0}",
                    newItem.Discount == null ? "-" : newItem.Discount.Name
                });
            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = item as Customer;
                int indexOfCustomer = _commonController.IndexOfItem(_customers, customer);
                if (indexOfCustomer >= 0)
                {
                    var title = "Lỗi trùng lặp";
                    var msg = "Thông tin khách hàng này đã tồn tại!";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    _commonController.AddNewItem(_customers, customer);
                    tblCustomer.Rows.Add(new object[]
                    {
                    customer.PersonId, customer.FullName?.ToString(), customer.BirthDate.ToString(DATE_FORMAT),
                    customer.Address, customer.PhoneNumber, customer.CustomerType, $"{customer.Point:N0}",
                    customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                    });
                }
            }
        }

        public void UpdateItem<T>(T updatedItem)
        {
            if (typeof(T) == typeof(Item))
            {
                var newItem = updatedItem as Item;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_items, newItem);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchItemResults, newItem);
                    _commonController.UpdateItem(_items, newItem);
                }
                tblItem.Rows.RemoveAt(updatedIndex);
                tblItem.Rows.Insert(updatedIndex,
                    new object[] {
                            newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                            newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"), $"{newItem.Price:N0}",
                            newItem.Discount == null ? "-" : newItem.Discount.Name
                        }
                );
            }
        }


        private void TblItemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemEdit"].Index)
            {
                Item item = _items[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    item = _searchItemResults[e.RowIndex];
                }
                var updateItemView = new AddEditItemFrm(this, _discounts, item);
                updateItemView.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {
                    int removedItemIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Item item = _items[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_items, item);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Item item = _searchItemResults[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_searchItemResults, item);
                        _commonController.DeleteItem(_items, item);
                    }
                    tblItem.Rows.RemoveAt(removedItemIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            // tblItemRemove
        }
        private DialogResult ShowConfirmDialog(string msg, string title)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void SortItemHandler(object sender, EventArgs e)
        {
            if (radioSortItemByPriceASC.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByPriceASC);
            }
            else if (radioSortItemByPriceDSC.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByPriceDSC);
            }
            else if (radioSortItemByName.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByName);
            }
            else if (radioSortItemByProductDate.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByDate);
            }
            else if (radioSortItemByQuantity.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByQuantity);
            }
            ShowItems(_items);
        }

        private void ShowItems(List<Item> items)
        {
            tblItem.Rows.Clear();
            foreach(var item in items)
            {
                tblItem.Rows.Add(new object[]
                {
                    item.ItemId, item.ItemName, item.ItemType, item.Quantity,
                    item.Brand, item.ReleaseDate.ToString("dd/MM/yyy"),$"{item.Price:N0}",
                    item.Discount == null ? "-" : item.Discount.Name
                });
            }
        }

        private void numericItemFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboSearchItemSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboSearchItem.SelectedIndex)
            {
                case 0:
                case 2:
                case 3:
                    txtSearchItem.Enabled = true;
                    numericItemFrom.Enabled = false;
                    numericItemTo.Enabled = false;
                    break;
                case 1:
                case 4:
                    txtSearchItem.Enabled = false;
                    numericItemFrom.Enabled = true;
                    numericItemTo.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void BtnSearchItemClick(object sender, EventArgs e)
        {
            tblItem.Rows.Clear();
            _actionType = ActionType.SEARCH;
            if (comboSearchItem.SelectedIndex == -1)
            {
                var msg = "Vui lòng chọn tiêu chí tìm kiếm để tiếp tục";
                var title = "Lỗi dữ liệu";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboSearchItem.SelectedIndex == 0)
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemNameMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 1)
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemPriceMatch, from, to);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 2) // loại mặt hàng
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemTypeMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 3) // hãng
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemBrandMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 4)
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemQuantityMatch, from, to);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
        }

        private void BtnRefreshClick(object sender, EventArgs e)
        {
            _actionType = ActionType.NORMAL;
            if (sender.Equals(btnRefreshItem))
            {
                ShowItems(_items);
            }
        }

        private void BtnAddNewCustomerClick(object sender, EventArgs e)
        {
            var childView = new AddEditCustomerFrm(this, null);
            childView.Show();
            CenterToParent();
        }

        private void tblCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
