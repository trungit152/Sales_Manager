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
    public partial class AddEditBillFrm : Form
    {
        private List<Item> _items;
        private List<Customer> _customer;
        private IViewController _controller;
        private BillDetail _bill;
        private CommonController _commonController;
        private List<Customer> _searchedCustomerResults;
        private List<Item> _searchedItemResults;
        private IBillController _billController;
        private bool _isEditing = false;
        private int _selectedIndex = -1;

        public AddEditBillFrm()
        {
            InitializeComponent();
            CenterToParent();
            _commonController = new CommonController();
            _billController = new BillController();
            _searchedCustomerResults = new List<Customer>();
            _searchedItemResults = new List<Item>();
        }

        public AddEditBillFrm(IViewController controller,
            List<Customer> customers, List<Item> items, BillDetail bill = null) : this()
        {
            _controller = controller;
            _items = items;
            _customer = customers;
            if (bill != null)
            {
                _bill = bill;
                ShowBillData();
            }
            else
            {
                _bill = new BillDetail(0);
            }
        }
        private void ShowBillData()
        {
            throw new NotImplementedException();
        }

        private void BtnPayClick(object sender, EventArgs e)
        {
            var paymentView = new PaymentFrm();
            paymentView.Show();
        }

        private void BtnSearchCustomerClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                var msg = "Vui lòng nhập tên khách hàng cần tìm.";
                var title = "Lỗi tìm kiếm";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _searchedCustomerResults = _commonController.Search(_customer,
                    new CustomerController().IsCustomerNameMatch, txtSearchCustomer.Text);
                tblSearchedCustomer.Rows.Clear();
                foreach (var customer in _searchedCustomerResults)
                {
                    tblSearchedCustomer.Rows.Add(new object[]
                    {
                            customer.PersonId, customer.FullName.ToString()
                    });
                }
                if (_searchedCustomerResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSearchItemClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchItem.Text))
            {
                var msg = "Vui lòng nhập tên mặt hàng cần tìm.";
                var title = "Lỗi tìm kiếm";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _searchedItemResults = _commonController.Search(_items,
                    new ItemController().IsItemNameMatch, txtSearchItem.Text);
                tblSearchedItem.Rows.Clear();
                foreach (var item in _searchedItemResults)
                {
                    tblSearchedItem.Rows.Add(new object[]
                    {
                            item.ItemId, item.ItemName, $"{item.Quantity:N0}"
                    });
                }
                if (_searchedItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TblCustomerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblSearchedCustomer.Columns["tblCustomerColSelect"].Index)
            {
                _bill.Cart.Customer = _searchedCustomerResults[e.RowIndex];
                ShowTotalInfo();
            }
        }

        private void ShowTotalInfo()
        {
            labelCustomerName.Text = $"Tên KH: {_bill.Cart?.Customer?.FullName?.ToString()}";
            labelTotalItem.Text = $"Tổng SP: {_bill.TotalItem:N0}sp";
            labelTotalAmount.Text = $"Tổng tiền: {_bill.TotalAmount:N0}đ";
            labelTotalDiscount.Text = $"Tổng KM: {_bill.TotalDiscountAmount:N0}đ";
        }

        private void TblItemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblSearchedItem.Columns["tblItemColSelect"].Index)
            {
                SelectedItem item = new SelectedItem(_searchedItemResults[e.RowIndex]);
                item.NumberOfSelectedItem = (int)numericSelectedQuantity.Value;
                if (item.NumberOfSelectedItem > 0)
                {
                    numericSelectedQuantity.Value = 0;
                    _billController.UpdateBill(_bill, item);
                    ShowBillDetail(item);
                    ShowTotalInfo();
                }
                else
                {
                    ShowErrorNumberOfSelectedItem();
                }
            }
        }

        private void ShowErrorNumberOfSelectedItem()
        {
            var title = "Lỗi dữ liệu";
            var msg = "Vui lòng nhập số mặt hàng khách chọn khác 0";
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowBillDetail(SelectedItem item)
        {
            tblBillDetail.Rows.Add(new object[]
            {
                _bill.BillId, item.ItemId, item.ItemName, $"{item.NumberOfSelectedItem:N0}",
                $"{item.Price:N0}", $"{item.PriceAfterDiscount:N0}",
                $"{item.NumberOfSelectedItem * item.PriceAfterDiscount:N0}"
            });
        }

        private void BtnUpdateSelectedItemCLick(object sender, EventArgs e)
        {
            if (_isEditing && _selectedIndex >= 0)
            {
                var item = _bill.Cart.SelectedItems[_selectedIndex];
                var newValue = (int)numericSelectedQuantity.Value;
                if (newValue == 0)
                {
                    ShowErrorNumberOfSelectedItem();
                }
                else
                {
                    item.NumberOfSelectedItem = newValue;
                    _billController.UpdateBill(_bill, item);
                    ShowTotalInfo();
                    tblBillDetail.Rows.RemoveAt(_selectedIndex);
                    tblBillDetail.Rows.Insert(_selectedIndex, new object[]
                        {
                            _bill.BillId, item.ItemId, item.ItemName, $"{item.NumberOfSelectedItem:N0}",
                            $"{item.Price:N0}", $"{item.PriceAfterDiscount:N0}",
                            $"{item.NumberOfSelectedItem * item.PriceAfterDiscount:N0}"
                        }
                    );
                    var msg = $"Cập nhật mặt hàng \"{item.ItemName}\" thành công.";
                    var title = "Cập nhật thành công";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _isEditing = false;
                    _selectedIndex = -1;
                }
            }
        }

        private void TblBillDetailCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblBillDetail.Columns["tblBillDetailColEdit"].Index)
            {
                _isEditing = true;
                _selectedIndex = e.RowIndex;
                numericSelectedQuantity.Value = _bill.Cart.SelectedItems[e.RowIndex].NumberOfSelectedItem;
            }
        }
    }
}
