using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using SaleManagerProject;

namespace CSharpCourseFinalProject
{
    public partial class AddEditCustomerFrm : Form
    {
        private Customer _customer;
        private IViewController _controller;

        public AddEditCustomerFrm()
        {
            InitializeComponent();
            CenterToParent();
        }

        public AddEditCustomerFrm(IViewController controller, Customer customer = null) : this()
        {
            _customer = customer;
            _controller = controller;
            if (customer != null)
            {
                ShowCustomerInfo();
            }
        }

        private void ShowCustomerInfo()
        {
            throw new NotImplementedException();
        }

        private void ClearCustomerIdHintHandler(object sender, MouseEventArgs e)
        {
            txtCustomerId.Text = "";
        }

        private void TxtIdTakeForcus(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtCustomerId.ForeColor = Color.Black;
        }

        private void TxtIdLeaveFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text))
            {
                txtCustomerId.Text = "CMND/CCCD";
                txtCustomerId.ForeColor = Color.Gray;
            }
            else
            {
                txtCustomerId.ForeColor = Color.Black;
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

        private void BtnAddUpdateClick(object sender, EventArgs e)
        {
            var customerController = new CustomerController();
            try
            {
                if (!customerController.IsNameValid(txtFullName.Text))
                {
                    throw new InvalidNameException("Họ và tên không hợp lệ.", txtFullName.Text);
                }
                if (!customerController.IsEmailValid(txtEmail.Text))
                {
                    throw new InvalidEmailException("Email không hợp lệ.", txtEmail.Text);
                }
                if (!customerController.IsPhoneValid(txtPhoneNumber.Text))
                {
                    throw new InvalidPhoneNumberException("Số điện thoại không hợp lệ.", txtPhoneNumber.Text);
                }
                if (btnAddNew.Text.CompareTo("Cập nhật") != 0)
                {
                    var id = txtCustomerId.Text;
                    var name = txtFullName.Text;
                    var address = txtAddress.Text;
                    var email = txtEmail.Text;
                    var phone = txtPhoneNumber.Text;
                    var birthDate = datePickerBirthDate.Value;
                    var createdAccTime = DateTime.Now;
                    var point = (int)numericPoint.Value;
                    var customerType = comboCustomerType.Text;
                    var customer = new Customer(customerType, point, createdAccTime, email);
                    customer.PersonId = id;
                    customer.FullName = new FullName(name);
                    customer.Address = address;
                    customer.PhoneNumber = phone;
                    customer.BirthDate = birthDate;
                    customer.CreateTime = createdAccTime;
                    _controller.AddNewItem(customer);
                }
                else
                {
                    // update customer info
                }


            }
            catch (InvalidNameException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (InvalidEmailException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (InvalidPhoneNumberException ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ShowErrorMessage(string msg)
        {
            var title = "Lỗi dữ liệu";
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
