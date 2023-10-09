namespace SaleManagerProject
{
    partial class AddEditBillFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditBillFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericSelectedQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.tblSearchCustomer = new System.Windows.Forms.DataGridView();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.tblSearchItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerColSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblItemColSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblSelectedItem = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.labelTotalDiscount = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCreatedTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSelectedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblSearchCustomer);
            this.groupBox1.Controls.Add(this.btnSearchCustomer);
            this.groupBox1.Controls.Add(this.txtStaff);
            this.groupBox1.Controls.Add(this.txtSearchCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblSearchItem);
            this.groupBox2.Controls.Add(this.btnSearchItem);
            this.groupBox2.Controls.Add(this.txtSearchItem);
            this.groupBox2.Controls.Add(this.numericSelectedQuantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(630, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tblSelectedItem);
            this.groupBox3.Controls.Add(this.labelTotalDiscount);
            this.groupBox3.Controls.Add(this.labelAmount);
            this.groupBox3.Location = new System.Drawing.Point(12, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1228, 348);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết mặt hàng trong hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // numericSelectedQuantity
            // 
            this.numericSelectedQuantity.Location = new System.Drawing.Point(155, 74);
            this.numericSelectedQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericSelectedQuantity.Name = "numericSelectedQuantity";
            this.numericSelectedQuantity.Size = new System.Drawing.Size(264, 27);
            this.numericSelectedQuantity.TabIndex = 6;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(159, 34);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(264, 27);
            this.txtSearchCustomer.TabIndex = 1;
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(159, 69);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(264, 27);
            this.txtStaff.TabIndex = 3;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(479, 41);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(110, 40);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Tìm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // tblSearchCustomer
            // 
            this.tblSearchCustomer.AllowUserToAddRows = false;
            this.tblSearchCustomer.AllowUserToDeleteRows = false;
            this.tblSearchCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSearchCustomer.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSearchCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSearchCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.tblCustomerColSelect});
            this.tblSearchCustomer.Location = new System.Drawing.Point(6, 124);
            this.tblSearchCustomer.Name = "tblSearchCustomer";
            this.tblSearchCustomer.RowHeadersWidth = 51;
            this.tblSearchCustomer.RowTemplate.Height = 24;
            this.tblSearchCustomer.Size = new System.Drawing.Size(598, 148);
            this.tblSearchCustomer.TabIndex = 5;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(155, 34);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(264, 27);
            this.txtSearchItem.TabIndex = 4;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchItem.Image")));
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchItem.Location = new System.Drawing.Point(480, 41);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(110, 40);
            this.btnSearchItem.TabIndex = 5;
            this.btnSearchItem.Text = "Tìm";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            // 
            // tblSearchItem
            // 
            this.tblSearchItem.AllowUserToAddRows = false;
            this.tblSearchItem.AllowUserToDeleteRows = false;
            this.tblSearchItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSearchItem.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSearchItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.tblItemColSelect});
            this.tblSearchItem.Location = new System.Drawing.Point(6, 124);
            this.tblSearchItem.Name = "tblSearchItem";
            this.tblSearchItem.RowHeadersWidth = 51;
            this.tblSearchItem.RowTemplate.Height = 24;
            this.tblSearchItem.Size = new System.Drawing.Size(598, 148);
            this.tblSearchItem.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblCustomerColSelect
            // 
            this.tblCustomerColSelect.HeaderText = "Chọn";
            this.tblCustomerColSelect.MinimumWidth = 6;
            this.tblCustomerColSelect.Name = "tblCustomerColSelect";
            this.tblCustomerColSelect.Text = "Chọn";
            this.tblCustomerColSelect.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã mặt hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên mặt hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblItemColSelect
            // 
            this.tblItemColSelect.HeaderText = "Chọn";
            this.tblItemColSelect.MinimumWidth = 6;
            this.tblItemColSelect.Name = "tblItemColSelect";
            this.tblItemColSelect.Text = "Chọn";
            this.tblItemColSelect.UseColumnTextForButtonValue = true;
            // 
            // tblSelectedItem
            // 
            this.tblSelectedItem.AllowUserToAddRows = false;
            this.tblSelectedItem.AllowUserToDeleteRows = false;
            this.tblSelectedItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSelectedItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblSelectedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSelectedItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblSelectedItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblSelectedItem.Location = new System.Drawing.Point(7, 27);
            this.tblSelectedItem.Name = "tblSelectedItem";
            this.tblSelectedItem.RowHeadersWidth = 51;
            this.tblSelectedItem.RowTemplate.Height = 24;
            this.tblSelectedItem.Size = new System.Drawing.Size(1215, 263);
            this.tblSelectedItem.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã HĐ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã MH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên MH";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giá bán";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giá sau KM";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Thành tiền";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Xóa bỏ";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(19, 594);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(102, 20);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Khách hàng:";
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Location = new System.Drawing.Point(280, 594);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(106, 20);
            this.labelTotalItem.TabIndex = 3;
            this.labelTotalItem.Text = "Tổng số: 0sp";
            // 
            // labelTotalDiscount
            // 
            this.labelTotalDiscount.AutoSize = true;
            this.labelTotalDiscount.Location = new System.Drawing.Point(485, 310);
            this.labelTotalDiscount.Name = "labelTotalDiscount";
            this.labelTotalDiscount.Size = new System.Drawing.Size(104, 20);
            this.labelTotalDiscount.TabIndex = 4;
            this.labelTotalDiscount.Text = "Tổng KM: 0đ";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(712, 310);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(106, 20);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Tổng tiền: 0đ";
            // 
            // labelCreatedTime
            // 
            this.labelCreatedTime.AutoSize = true;
            this.labelCreatedTime.Location = new System.Drawing.Point(967, 594);
            this.labelCreatedTime.Name = "labelCreatedTime";
            this.labelCreatedTime.Size = new System.Drawing.Size(82, 20);
            this.labelCreatedTime.TabIndex = 6;
            this.labelCreatedTime.Text = "Thời gian:";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(201, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 42);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(441, 659);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 42);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(921, 659);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(681, 659);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 42);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Xóa bỏ";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // AddEditBillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 715);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelCreatedTime);
            this.Controls.Add(this.labelTotalItem);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditBillFrm";
            this.Text = "THÊM MỚI HÓA ĐƠN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSelectedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblSearchCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericSelectedQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn tblCustomerColSelect;
        private System.Windows.Forms.DataGridView tblSearchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn tblItemColSelect;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.DataGridView tblSelectedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.Label labelTotalDiscount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCreatedTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
    }
}