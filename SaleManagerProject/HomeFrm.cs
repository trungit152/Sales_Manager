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

namespace SaleManagerProject
{
    public interface IViewController
    {
        void AddNewItem<T> (T item);
        void UpdateItem<T> (T updatedItem);

    }
    public partial class HomeFrm : Form, IViewController
    {
        private List<Item> _items;
        private List<Discount> _discounts;
        private List<Customer> _customers;
        private CommonController _commonController;
        private ItemController _itemController;
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
            _items = new List<Item>();
            _discounts = new List<Discount>();
            _customers = new List<Customer>();
            _commonController = new CommonController();
            _itemController = new ItemController();
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
                    newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyy"),$"{newItem.Price:N0}",
                    newItem.Discount == null ? "-" : newItem.Discount.Name
                });
            }
            else if (typeof(T) == typeof(Customer))
            {
                //hiển thị lên bảng Customer
            }
        }

        public void UpdateItem<T>(T updatedItem)
        {
            if(typeof(T) == typeof(Item))
            {
                var newItem = updatedItem as Item;
                int updatedIndex = _commonController.UpdateItem(_items, newItem);
                tblItem.Rows.RemoveAt(updatedIndex);
                tblItem.Rows.Insert(updatedIndex,
                    new object[]{
                        newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                        newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyy"),$"{newItem.Price:N0}",
                        newItem.Discount == null ? "-" : newItem.Discount.Name
                    }
                );
            }
        }
        private void HomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabCustomer_Click(object sender, EventArgs e)
        {

        }

        private void tabDiscount_Click(object sender, EventArgs e)
        {

        }

        private void tabBill_Click(object sender, EventArgs e)
        {

        }

        private void tabStat_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TblItemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0 && e.ColumnIndex == tblItem.Columns["tblItemEdit"].Index) 
            {
                var updateItemView = new AddEditItemFrm(this, _discounts, _items[e.RowIndex]);
                updateItemView.Show();
            } 
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemRemove"].Index)
            {
                var title = "Xác nhận xóa?";
                var msg = "Bạn muốn xóa bản ghi?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {
                    var removeItemIndex = _commonController.DeleteItem(_items, _items[e.RowIndex]);
                    tblItem.Rows.RemoveAt(removeItemIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
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
            if(comboSearchItem.SelectedIndex == -1)
            {
                var msg = "Chọn tiêu chí để tìm kiếm";
                var title = "Lỗi";
                MessageBox.Show(msg,title,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboSearchItem.SelectedIndex == 0) 
            {
                var key = txtSearchItem.Text;
                var result = _commonController.Search(_items, _itemController.IsItemNameMatch, key);
                if(result.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowItems(result);
                }
            }
            else if (comboSearchItem.SelectedIndex == 1)
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                var key = txtSearchItem.Text;
                var result = _commonController.Search(_items, _itemController.IsItemPriceMatch, from, to);
                if (result.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowItems(result);
                }
            }
            else if (comboSearchItem.SelectedIndex == 2) //Loại mặt hàng
            {
                var key = txtSearchItem.Text;
                var result = _commonController.Search(_items, _itemController.IsItemTypeMatch, key);
                if (result.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowItems(result);
                }
            }
            else if (comboSearchItem.SelectedIndex == 3)//Hãng sx
            {
                var key = txtSearchItem.Text;
                var result = _commonController.Search(_items, _itemController.IsItemBrandMatch, key);
                if (result.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowItems(result);
                }
            }
            else if (comboSearchItem.SelectedIndex == 4)
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                var key = txtSearchItem.Text;
                var result = _commonController.Search(_items, _itemController.IsItemQuantityMatch, from, to);
                if (result.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowItems(result);
                }
            }
        }

        private void btnRefreshClick(object sender, EventArgs e)
        {
            if (sender.Equals(btnRefreshItem))
            {
                ShowItems(_items);
            }
        }
    }
}
