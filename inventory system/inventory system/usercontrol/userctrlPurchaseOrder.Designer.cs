﻿namespace inventory_system.usercontrol
{
    partial class userctrlPurchaseOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerCurrentDate = new DateTimePicker();
            dateTimePickerCreationDate = new DateTimePicker();
            txtBoxPurchaseOrderNumber = new TextBox();
            txtBoxCreatedBy = new TextBox();
            txtBoxVendorName = new TextBox();
            dateTimePickerExpectedDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbBoxPaymentType = new ComboBox();
            dateTimePickerDateReceived = new DateTimePicker();
            btnUpdateInventory = new Button();
            btnClearForm = new Button();
            txtBoxProductID = new TextBox();
            label10 = new Label();
            txtBoxProductName = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtBoxSubTotal = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(291, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 39);
            label1.TabIndex = 9;
            label1.Text = "Purchase Order Details";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(btnClearForm);
            groupBox1.Controls.Add(txtBoxSubTotal);
            groupBox1.Controls.Add(btnUpdateInventory);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtBoxProductName);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtBoxProductID);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePickerDateReceived);
            groupBox1.Controls.Add(cmbBoxPaymentType);
            groupBox1.Controls.Add(txtBoxVendorName);
            groupBox1.Controls.Add(dateTimePickerExpectedDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBoxCreatedBy);
            groupBox1.Controls.Add(txtBoxPurchaseOrderNumber);
            groupBox1.Controls.Add(dateTimePickerCreationDate);
            groupBox1.Controls.Add(dateTimePickerCurrentDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(19, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 325);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 30);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Current Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 71);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "PO Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 109);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 2;
            label4.Text = "Created By :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 145);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 3;
            label5.Text = "Creation Date :";
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Location = new Point(136, 29);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.Size = new Size(216, 23);
            dateTimePickerCurrentDate.TabIndex = 4;
            // 
            // dateTimePickerCreationDate
            // 
            dateTimePickerCreationDate.Location = new Point(136, 139);
            dateTimePickerCreationDate.Name = "dateTimePickerCreationDate";
            dateTimePickerCreationDate.Size = new Size(216, 23);
            dateTimePickerCreationDate.TabIndex = 5;
            // 
            // txtBoxPurchaseOrderNumber
            // 
            txtBoxPurchaseOrderNumber.Location = new Point(136, 68);
            txtBoxPurchaseOrderNumber.Name = "txtBoxPurchaseOrderNumber";
            txtBoxPurchaseOrderNumber.Size = new Size(216, 23);
            txtBoxPurchaseOrderNumber.TabIndex = 6;
            // 
            // txtBoxCreatedBy
            // 
            txtBoxCreatedBy.Location = new Point(136, 106);
            txtBoxCreatedBy.Name = "txtBoxCreatedBy";
            txtBoxCreatedBy.Size = new Size(216, 23);
            txtBoxCreatedBy.TabIndex = 7;
            // 
            // txtBoxVendorName
            // 
            txtBoxVendorName.Location = new Point(496, 69);
            txtBoxVendorName.Name = "txtBoxVendorName";
            txtBoxVendorName.Size = new Size(218, 23);
            txtBoxVendorName.TabIndex = 14;
            // 
            // dateTimePickerExpectedDate
            // 
            dateTimePickerExpectedDate.Location = new Point(496, 30);
            dateTimePickerExpectedDate.Name = "dateTimePickerExpectedDate";
            dateTimePickerExpectedDate.Size = new Size(218, 23);
            dateTimePickerExpectedDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 146);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 11;
            label6.Text = "Payment Type :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 110);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 10;
            label7.Text = "Date Received :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(395, 72);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 9;
            label8.Text = "Vendor Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 31);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 8;
            label9.Text = "Expected Date :";
            // 
            // cmbBoxPaymentType
            // 
            cmbBoxPaymentType.FormattingEnabled = true;
            cmbBoxPaymentType.Items.AddRange(new object[] { "Cash", "Check" });
            cmbBoxPaymentType.Location = new Point(496, 146);
            cmbBoxPaymentType.Name = "cmbBoxPaymentType";
            cmbBoxPaymentType.Size = new Size(102, 23);
            cmbBoxPaymentType.TabIndex = 16;
            // 
            // dateTimePickerDateReceived
            // 
            dateTimePickerDateReceived.Location = new Point(496, 107);
            dateTimePickerDateReceived.Name = "dateTimePickerDateReceived";
            dateTimePickerDateReceived.Size = new Size(218, 23);
            dateTimePickerDateReceived.TabIndex = 17;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdateInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInventory.ForeColor = Color.White;
            btnUpdateInventory.Location = new Point(237, 264);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(157, 44);
            btnUpdateInventory.TabIndex = 18;
            btnUpdateInventory.Text = "Update Inventory";
            btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.Red;
            btnClearForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearForm.ForeColor = Color.White;
            btnClearForm.Location = new Point(441, 264);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(157, 44);
            btnClearForm.TabIndex = 19;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // txtBoxProductID
            // 
            txtBoxProductID.Location = new Point(136, 182);
            txtBoxProductID.Name = "txtBoxProductID";
            txtBoxProductID.Size = new Size(216, 23);
            txtBoxProductID.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 185);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 18;
            label10.Text = "Product ID :";
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.Location = new Point(136, 221);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.Size = new Size(216, 23);
            txtBoxProductName.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 224);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 20;
            label11.Text = "Product Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(651, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(550, 190);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 24;
            label12.Text = "Product Rate :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(496, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(33, 23);
            textBox2.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(395, 190);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 22;
            label13.Text = "Product Qty :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(395, 224);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 26;
            label14.Text = "Sub Total :";
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.Location = new Point(496, 224);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(102, 23);
            txtBoxSubTotal.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(20, 403);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(787, 139);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Purchase Order Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(775, 111);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // userctrlPurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "userctrlPurchaseOrder";
            Size = new Size(845, 545);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnClearForm;
        private TextBox txtBoxSubTotal;
        private Button btnUpdateInventory;
        private Label label14;
        private TextBox textBox1;
        private Label label12;
        private TextBox textBox2;
        private Label label13;
        private TextBox txtBoxProductName;
        private Label label11;
        private TextBox txtBoxProductID;
        private Label label10;
        private DateTimePicker dateTimePickerDateReceived;
        private ComboBox cmbBoxPaymentType;
        private TextBox txtBoxVendorName;
        private DateTimePicker dateTimePickerExpectedDate;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBoxCreatedBy;
        private TextBox txtBoxPurchaseOrderNumber;
        private DateTimePicker dateTimePickerCreationDate;
        private DateTimePicker dateTimePickerCurrentDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}