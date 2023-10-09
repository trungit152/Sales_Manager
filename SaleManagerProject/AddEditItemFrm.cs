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
    public partial class AddEditItemFrm : Form
    {
        private List<Discount> _discounts;
        private Item _item;
        private IViewController _controller;
        public AddEditItemFrm()
        {
            InitializeComponent();
            CenterToParent();
        }
        public AddEditItemFrm(IViewController masterView, List<Discount> discounts, Item item = null) : this()
        {
            _discounts = discounts;
            _controller = masterView;
            ShowDiscounts(_discounts);
            if (item != null)
            {
                Text = "CẬP NHẬT THÔNG TIN MẶT HÀNG";
                btnAddNew.Text = "Cập nhật";
                _item = item;
                ShowItemData();
            }
        }

        private void ShowDiscounts(List<Discount> discounts)
        {
            List<string> discountList = new List<string>();
            foreach (var discount in discounts)
            {
                discountList.Add(discount.Name);
            }
            comboDiscount.DataSource = discountList;
            comboDiscount.SelectedIndex = -1;
        }

        private void ShowItemData()
        {
            txtId.Text = $"{_item.ItemId}";
            txtItemName.Text = _item.ItemName;
            txtBrand.Text = _item.Brand;
            numericQuantity.Value = _item.Quantity;
            numericPrice.Value = _item.Price;
            comboItemType.Text = _item.ItemType;
            for (int i = 0; i < comboDiscount.Items.Count; i++)
            {
                if (_item.Discount?.Name.CompareTo(comboDiscount.Items[i]) == 0)
                {
                    comboDiscount.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < comboDiscount.Items.Count; i++)
            {
                if (_item.Discount?.Name.CompareTo(comboDiscount.Items[i]) == 0)
                {
                    comboDiscount.SelectedIndex = i;
                    break;
                }
            }

        }
        private void BtnAddItemClick(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var itemName = txtItemName.Text;
            var itemType = comboItemType.Text;
            var itemPrice = (int)numericPrice.Value;
            var quantity = (int)numericQuantity.Value;
            var brand = txtBrand.Text;
            var manufactureDate = datePickerReleaseDate.Value;
            Discount discount = null;
            if (comboDiscount.SelectedIndex > -1)
            {
                discount = _discounts[comboDiscount.SelectedIndex];

            }
            try
            {
                if (string.IsNullOrEmpty(itemName))
                {
                    var msg = "Phải có tên mặt hàng";
                    throw new InvalidItemNameException(msg);
                }
                if (itemType == null || itemType == "")
                {
                    var msg = "Phải chọn loại mặt hàng";
                    MessageBox.Show(msg, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Item item = new Item(id, itemName, itemType, quantity, brand, manufactureDate, itemPrice, discount);
                //
                if (btnAddNew.Text.CompareTo("Cập nhật") == 0)
                {
                    _item.ItemName = itemName;
                    _item.ItemType = itemType;
                    _item.Quantity = quantity;
                    _item.Brand = brand;
                    _item.Price = itemPrice;
                    _item.Discount = discount;
                    _item.ReleaseDate = manufactureDate;
                    var msg = "Bạn có chắc chắn muốn cập nhật?";
                    var title = "Xác nhận";
                    var ans = ShowConfirmMessage(title, msg);
                    if (ans == DialogResult.Yes)
                    {
                        _controller.UpdateItem(_item);
                        Dispose();
                    }

                }
                else
                {
                    _controller.AddNewItem(item);
                }
            }
            catch (InvalidItemNameException ex)
            {

                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelClick(object sender, EventArgs e)
        {
            var ans = ShowConfirmMessage("Xác nhận", "Bạn muốn hủy?");
            if (ans == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private DialogResult ShowConfirmMessage(string v1, string v2)
        {
            return MessageBox.Show(v2, v1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void AddEditItemFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
