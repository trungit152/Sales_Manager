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
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
            _items = new List<Item>();
            _discounts = new List<Discount>();
            _customers = new List<Customer>();
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
            throw new NotImplementedException();
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


    }
}
