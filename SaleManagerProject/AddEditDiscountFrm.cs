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

namespace SaleManagerProject
{
    public partial class AddEditDiscountFrm : Form
    {
        private Discount _discount;
        private IViewController _controller;
        public AddEditDiscountFrm()
        {
            InitializeComponent();
            CenterToParent();
        }
        public AddEditDiscountFrm(IViewController controller, Discount discount = null) : this()
        {
            _controller = controller;
            _discount = discount;
            if (_discount != null)
            {
                Text = "CẬP NHẬT THÔNG TIN KHUYẾN MÃI";
                btnAddNew.Text = "Cập nhật";
                ShowDiscountInfo();
            }
        }

        private void ShowDiscountInfo()
        {
            txtDiscountId.Text = _discount.DiscountId + "";
            txtDiscountName.Text = _discount.Name;
            dtPickerStart.Value = _discount.StartTime;
            dtPickerEnd.Value = _discount.EndTime;
            numericDiscountAmount.Value = _discount.DiscountPriceAmount;
            numericDiscountPercent.Value = _discount.DiscountPercent;
            for (int i = 0; i < comboDiscountType.Items.Count; i++)
            {
                if (_discount.DiscountType.CompareTo(comboDiscountType.Items[i]) == 0)
                {
                    comboDiscountType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            var title = "Xác nhận";
            var message = "Bạn có chắc muốn hủy bỏ?";
            var ans = ShowConfirmMessage(title, message);
            if (ans == DialogResult.Yes)
            {
                Dispose();
            }
        }
        private DialogResult ShowConfirmMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void BtnAddEditClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountName.Text))
            {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng nhập tên khuyến mãi.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboDiscountType.SelectedIndex == -1)
            {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng chọn loại chương trình khuyến mãi.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnAddNew.Text.CompareTo("Cập nhật") == 0)
                {
                    _discount.Name = txtDiscountName.Text;
                    _discount.StartTime = dtPickerStart.Value;
                    _discount.EndTime = dtPickerEnd.Value;
                    _discount.DiscountType = comboDiscountType.Text;
                    _discount.DiscountPercent = (int)numericDiscountPercent.Value;
                    _discount.DiscountPriceAmount = (int)numericDiscountAmount.Value;
                    var title = "Xác nhận";
                    var msg = "Bạn có chắc chắn muốn lưu các thay đổi?";
                    var ans = ShowConfirmMessage(title, msg);
                    if (ans == DialogResult.Yes)
                    {
                        _controller.UpdateItem(_discount);
                        Dispose();
                    }
                }
                else
                {
                    // tạo mới ct km
                    Discount discount = new Discount(0, txtDiscountName.Text, dtPickerStart.Value,
                        dtPickerEnd.Value, comboDiscountType.Text, (int)numericDiscountAmount.Value,
                        (int)numericDiscountPercent.Value);
                    _controller.AddNewItem(discount);
                }
            }
        }
    }
}
