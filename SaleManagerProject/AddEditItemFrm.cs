﻿using System;
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
        private List<Item> _items;
        private IViewController _controller;
        public AddEditItemFrm()
        {
            InitializeComponent();
            CenterToParent();
        }
        public AddEditItemFrm(IViewController masterView ,List<Discount> discounts, Item item = null) : this()
        {
            _discounts= discounts;
            _controller = masterView;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if(comboDiscount.SelectedIndex > -1)
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
                _controller.AddNewItem(item);
            }
            catch (InvalidItemNameException ex)
            {

                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelClick(object sender, EventArgs e)
        {
            var ans = ShowConfirmMessage("Xác nhận", "Bạn muốn hủy mặt hàng?");
            if(ans == DialogResult.Yes)
            {
                Dispose();
            }            
        }

        private DialogResult ShowConfirmMessage(string v1, string v2)
        {
            return MessageBox.Show(v2, v1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
