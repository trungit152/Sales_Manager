namespace SaleManagerProject
{
    partial class HomeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnRefreshItem = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.comboSearchItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericItemFrom = new System.Windows.Forms.NumericUpDown();
            this.numericItemTo = new System.Windows.Forms.NumericUpDown();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab.Controls.Add(this.tabItem);
            this.tab.Controls.Add(this.tabCustomer);
            this.tab.Controls.Add(this.tabDiscount);
            this.tab.Controls.Add(this.tabBill);
            this.tab.Controls.Add(this.tabStat);
            this.tab.Location = new System.Drawing.Point(2, 0);
            this.tab.Name = "tab";
            this.tab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1101, 692);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.groupBox3);
            this.tabItem.Controls.Add(this.groupBox2);
            this.tabItem.Controls.Add(this.groupBox1);
            this.tabItem.Controls.Add(this.dataGridView1);
            this.tabItem.Location = new System.Drawing.Point(4, 28);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabItem.Size = new System.Drawing.Size(1093, 660);
            this.tabItem.TabIndex = 0;
            this.tabItem.Text = "QL MẶT HÀNG";
            this.tabItem.UseVisualStyleBackColor = true;
            this.tabItem.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Location = new System.Drawing.Point(4, 28);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1093, 660);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "QL KHÁCH HÀNG";
            this.tabCustomer.UseVisualStyleBackColor = true;
            this.tabCustomer.Click += new System.EventHandler(this.tabCustomer_Click);
            // 
            // tabDiscount
            // 
            this.tabDiscount.Location = new System.Drawing.Point(4, 28);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(1093, 660);
            this.tabDiscount.TabIndex = 2;
            this.tabDiscount.Text = "QL KHUYẾN MÃI";
            this.tabDiscount.UseVisualStyleBackColor = true;
            this.tabDiscount.Click += new System.EventHandler(this.tabDiscount_Click);
            // 
            // tabBill
            // 
            this.tabBill.Location = new System.Drawing.Point(4, 28);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(1093, 660);
            this.tabBill.TabIndex = 3;
            this.tabBill.Text = "QL HÓA ĐƠN";
            this.tabBill.UseVisualStyleBackColor = true;
            this.tabBill.Click += new System.EventHandler(this.tabBill_Click);
            // 
            // tabStat
            // 
            this.tabStat.Location = new System.Drawing.Point(4, 28);
            this.tabStat.Name = "tabStat";
            this.tabStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat.Size = new System.Drawing.Size(1093, 660);
            this.tabStat.TabIndex = 4;
            this.tabStat.Text = "THỐNG KÊ";
            this.tabStat.UseVisualStyleBackColor = true;
            this.tabStat.Click += new System.EventHandler(this.tabStat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshItem);
            this.groupBox1.Controls.Add(this.btnAddNewItem);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(6, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(355, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(368, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(355, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchItem);
            this.groupBox3.Controls.Add(this.numericItemTo);
            this.groupBox3.Controls.Add(this.numericItemFrom);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSearchItem);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboSearchItem);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Location = new System.Drawing.Point(729, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(355, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewItem.Image")));
            this.btnAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItem.Location = new System.Drawing.Point(43, 71);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(131, 46);
            this.btnAddNewItem.TabIndex = 0;
            this.btnAddNewItem.Text = "Thêm mới";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefreshItem
            // 
            this.btnRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshItem.Image")));
            this.btnRefreshItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshItem.Location = new System.Drawing.Point(180, 71);
            this.btnRefreshItem.Name = "btnRefreshItem";
            this.btnRefreshItem.Size = new System.Drawing.Size(131, 46);
            this.btnRefreshItem.TabIndex = 1;
            this.btnRefreshItem.Text = "Làm mới";
            this.btnRefreshItem.UseVisualStyleBackColor = true;
            this.btnRefreshItem.Click += new System.EventHandler(this.btnRefreshItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Giá niêm yết tăng dần";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Giá niêm yết giảm dần";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 142);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "A-Z";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(181, 36);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(140, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Số lượng giảm dần";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(181, 90);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(168, 20);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Ngày sản xuất tăng dần";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // comboSearchItem
            // 
            this.comboSearchItem.FormattingEnabled = true;
            this.comboSearchItem.Items.AddRange(new object[] {
            "Tìm theo tên mặt hàng",
            "Tìm theo khoảng giá a-b",
            "Tìm theo loại mặt hàng",
            "Tìm theo hãng sản xuất",
            "Theo số lượng khoảng a-b"});
            this.comboSearchItem.Location = new System.Drawing.Point(98, 28);
            this.comboSearchItem.Name = "comboSearchItem";
            this.comboSearchItem.Size = new System.Drawing.Size(224, 24);
            this.comboSearchItem.TabIndex = 0;
            this.comboSearchItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu chí";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(99, 67);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(223, 22);
            this.txtSearchItem.TabIndex = 4;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericItemFrom
            // 
            this.numericItemFrom.Location = new System.Drawing.Point(99, 101);
            this.numericItemFrom.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericItemFrom.Name = "numericItemFrom";
            this.numericItemFrom.Size = new System.Drawing.Size(71, 22);
            this.numericItemFrom.TabIndex = 6;
            this.numericItemFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericItemTo
            // 
            this.numericItemTo.Location = new System.Drawing.Point(251, 103);
            this.numericItemTo.Name = "numericItemTo";
            this.numericItemTo.Size = new System.Drawing.Size(71, 22);
            this.numericItemTo.TabIndex = 7;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchItem.Image")));
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchItem.Location = new System.Drawing.Point(113, 143);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(129, 37);
            this.btnSearchItem.TabIndex = 8;
            this.btnSearchItem.Text = "Tìm kiếm";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 693);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeFrm";
            this.Text = "QUẢN LÍ BÁN HÀNG";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.tab.ResumeLayout(false);
            this.tabItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshItem;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSearchItem;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.NumericUpDown numericItemTo;
        private System.Windows.Forms.NumericUpDown numericItemFrom;
        private System.Windows.Forms.Label label4;
    }
}

