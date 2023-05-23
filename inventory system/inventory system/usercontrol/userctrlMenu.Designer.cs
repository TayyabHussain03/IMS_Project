namespace inventory_system.usercontrol
{
    partial class userctrlMenu
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            menubtn = new PictureBox();
            btnAnalysis = new Button();
            panel2 = new Panel();
            products = new Button();
            btnStock = new Button();
            btnProductCategory = new Button();
            btnProductTypes = new Button();
            btnProductDetails = new Button();
            panel3 = new Panel();
            btnPurchases = new Button();
            btnReport = new Button();
            btnPurchaseReturn = new Button();
            panel4 = new Panel();
            btnSale = new Button();
            siderbarTimer = new System.Windows.Forms.Timer(components);
            btnSalesReturn = new Button();
            panel6 = new Panel();
            btnDailySales = new Button();
            btnMonthlySales = new Button();
            btnYearlySales = new Button();
            panel5 = new Panel();
            panel7 = new Panel();
            sidebar = new FlowLayoutPanel();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 92);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(83, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menubtn
            // 
            menubtn.Cursor = Cursors.Hand;
            menubtn.Image = Properties.Resources.icons8_menu_25;
            menubtn.Location = new Point(25, 19);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(42, 36);
            menubtn.SizeMode = PictureBoxSizeMode.CenterImage;
            menubtn.TabIndex = 0;
            menubtn.TabStop = false;
            menubtn.Click += menubtn_Click;
            // 
            // btnAnalysis
            // 
            btnAnalysis.FlatStyle = FlatStyle.Flat;
            btnAnalysis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalysis.ForeColor = Color.FromArgb(224, 224, 224);
            btnAnalysis.Image = Properties.Resources.icons8_profit_24;
            btnAnalysis.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalysis.Location = new Point(-10, -12);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Padding = new Padding(35, 0, 0, 0);
            btnAnalysis.Size = new Size(253, 57);
            btnAnalysis.TabIndex = 1;
            btnAnalysis.Text = "              Analysis";
            btnAnalysis.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalysis.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 59, 59);
            panel2.Controls.Add(products);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 34);
            panel2.TabIndex = 1;
            // 
            // products
            // 
            products.FlatStyle = FlatStyle.Flat;
            products.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            products.ForeColor = Color.FromArgb(224, 224, 224);
            products.Image = Properties.Resources.icons8_products_24;
            products.ImageAlign = ContentAlignment.MiddleLeft;
            products.Location = new Point(-14, -13);
            products.Name = "products";
            products.Padding = new Padding(45, 0, 0, 0);
            products.Size = new Size(253, 58);
            products.TabIndex = 1;
            products.Text = "              Products";
            products.TextAlign = ContentAlignment.MiddleLeft;
            products.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStock.ForeColor = Color.FromArgb(224, 224, 224);
            btnStock.Image = Properties.Resources.icons8_stock_24;
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(-10, -12);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(35, 0, 0, 0);
            btnStock.Size = new Size(253, 57);
            btnStock.TabIndex = 1;
            btnStock.Text = "              Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = true;
            // 
            // btnProductCategory
            // 
            btnProductCategory.BackColor = Color.DarkSlateGray;
            btnProductCategory.FlatAppearance.BorderSize = 0;
            btnProductCategory.FlatStyle = FlatStyle.Flat;
            btnProductCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductCategory.ForeColor = Color.FromArgb(224, 224, 224);
            btnProductCategory.Image = Properties.Resources.icons8_dot_161;
            btnProductCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductCategory.Location = new Point(3, 141);
            btnProductCategory.Name = "btnProductCategory";
            btnProductCategory.Padding = new Padding(35, 0, 0, 0);
            btnProductCategory.Size = new Size(227, 36);
            btnProductCategory.TabIndex = 1;
            btnProductCategory.Text = "              Product Category";
            btnProductCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnProductCategory.UseVisualStyleBackColor = false;
            // 
            // btnProductTypes
            // 
            btnProductTypes.BackColor = Color.DarkSlateGray;
            btnProductTypes.FlatAppearance.BorderSize = 0;
            btnProductTypes.FlatStyle = FlatStyle.Flat;
            btnProductTypes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductTypes.ForeColor = Color.FromArgb(224, 224, 224);
            btnProductTypes.Image = Properties.Resources.icons8_dot_161;
            btnProductTypes.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductTypes.Location = new Point(3, 183);
            btnProductTypes.Name = "btnProductTypes";
            btnProductTypes.Padding = new Padding(35, 0, 0, 0);
            btnProductTypes.Size = new Size(227, 36);
            btnProductTypes.TabIndex = 2;
            btnProductTypes.Text = "              Product Types";
            btnProductTypes.TextAlign = ContentAlignment.MiddleLeft;
            btnProductTypes.UseVisualStyleBackColor = false;
            // 
            // btnProductDetails
            // 
            btnProductDetails.BackColor = Color.DarkSlateGray;
            btnProductDetails.FlatAppearance.BorderSize = 0;
            btnProductDetails.FlatStyle = FlatStyle.Flat;
            btnProductDetails.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductDetails.ForeColor = Color.FromArgb(224, 224, 224);
            btnProductDetails.Image = Properties.Resources.icons8_dot_161;
            btnProductDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductDetails.Location = new Point(3, 225);
            btnProductDetails.Name = "btnProductDetails";
            btnProductDetails.Padding = new Padding(35, 0, 0, 0);
            btnProductDetails.Size = new Size(227, 36);
            btnProductDetails.TabIndex = 3;
            btnProductDetails.Text = "              Product Details";
            btnProductDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnProductDetails.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPurchases);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(3, 267);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 34);
            panel3.TabIndex = 2;
            // 
            // btnPurchases
            // 
            btnPurchases.BackColor = Color.FromArgb(35, 59, 59);
            btnPurchases.FlatStyle = FlatStyle.Flat;
            btnPurchases.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPurchases.ForeColor = Color.FromArgb(224, 224, 224);
            btnPurchases.Image = Properties.Resources.icons8_purchases_24;
            btnPurchases.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchases.Location = new Point(-10, -12);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Padding = new Padding(35, 0, 0, 0);
            btnPurchases.Size = new Size(253, 57);
            btnPurchases.TabIndex = 1;
            btnPurchases.Text = "              Purchases";
            btnPurchases.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchases.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.FromArgb(224, 224, 224);
            btnReport.Image = Properties.Resources.icons8_graph_report_24;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-10, -12);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(35, 0, 0, 0);
            btnReport.Size = new Size(253, 57);
            btnReport.TabIndex = 1;
            btnReport.Text = "              Reports";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseReturn
            // 
            btnPurchaseReturn.BackColor = Color.DarkSlateGray;
            btnPurchaseReturn.FlatAppearance.BorderSize = 0;
            btnPurchaseReturn.FlatStyle = FlatStyle.Flat;
            btnPurchaseReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPurchaseReturn.ForeColor = Color.FromArgb(224, 224, 224);
            btnPurchaseReturn.Image = Properties.Resources.icons8_dot_161;
            btnPurchaseReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchaseReturn.Location = new Point(3, 307);
            btnPurchaseReturn.Name = "btnPurchaseReturn";
            btnPurchaseReturn.Padding = new Padding(35, 0, 0, 0);
            btnPurchaseReturn.Size = new Size(227, 36);
            btnPurchaseReturn.TabIndex = 4;
            btnPurchaseReturn.Text = "              Purchase Return";
            btnPurchaseReturn.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchaseReturn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSale);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(3, 349);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 34);
            panel4.TabIndex = 3;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.FromArgb(35, 59, 59);
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSale.ForeColor = Color.FromArgb(224, 224, 224);
            btnSale.Image = Properties.Resources.icons8_sale_24;
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(-10, -12);
            btnSale.Name = "btnSale";
            btnSale.Padding = new Padding(35, 0, 0, 0);
            btnSale.Size = new Size(253, 57);
            btnSale.TabIndex = 1;
            btnSale.Text = "              Sale";
            btnSale.TextAlign = ContentAlignment.MiddleLeft;
            btnSale.UseVisualStyleBackColor = false;
            // 
            // siderbarTimer
            // 
            siderbarTimer.Interval = 20;
            siderbarTimer.Tick += sidebarTimer_Tick;
            // 
            // btnSalesReturn
            // 
            btnSalesReturn.BackColor = Color.DarkSlateGray;
            btnSalesReturn.FlatAppearance.BorderSize = 0;
            btnSalesReturn.FlatStyle = FlatStyle.Flat;
            btnSalesReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalesReturn.ForeColor = Color.FromArgb(224, 224, 224);
            btnSalesReturn.Image = Properties.Resources.icons8_dot_161;
            btnSalesReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalesReturn.Location = new Point(3, 389);
            btnSalesReturn.Name = "btnSalesReturn";
            btnSalesReturn.Padding = new Padding(35, 0, 0, 0);
            btnSalesReturn.Size = new Size(227, 36);
            btnSalesReturn.TabIndex = 5;
            btnSalesReturn.Text = "              Sales Return";
            btnSalesReturn.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesReturn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 59, 59);
            panel6.Controls.Add(btnReport);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(3, 431);
            panel6.Name = "panel6";
            panel6.Size = new Size(232, 34);
            panel6.TabIndex = 5;
            // 
            // btnDailySales
            // 
            btnDailySales.BackColor = Color.DarkSlateGray;
            btnDailySales.FlatAppearance.BorderSize = 0;
            btnDailySales.FlatStyle = FlatStyle.Flat;
            btnDailySales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDailySales.ForeColor = Color.FromArgb(224, 224, 224);
            btnDailySales.Image = Properties.Resources.icons8_dot_161;
            btnDailySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnDailySales.Location = new Point(3, 471);
            btnDailySales.Name = "btnDailySales";
            btnDailySales.Padding = new Padding(35, 0, 0, 0);
            btnDailySales.Size = new Size(227, 36);
            btnDailySales.TabIndex = 6;
            btnDailySales.Text = "              Daily Sales";
            btnDailySales.TextAlign = ContentAlignment.MiddleLeft;
            btnDailySales.UseVisualStyleBackColor = false;
            // 
            // btnMonthlySales
            // 
            btnMonthlySales.BackColor = Color.DarkSlateGray;
            btnMonthlySales.FlatAppearance.BorderSize = 0;
            btnMonthlySales.FlatStyle = FlatStyle.Flat;
            btnMonthlySales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonthlySales.ForeColor = Color.FromArgb(224, 224, 224);
            btnMonthlySales.Image = Properties.Resources.icons8_dot_161;
            btnMonthlySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonthlySales.Location = new Point(3, 513);
            btnMonthlySales.Name = "btnMonthlySales";
            btnMonthlySales.Padding = new Padding(35, 0, 0, 0);
            btnMonthlySales.Size = new Size(227, 36);
            btnMonthlySales.TabIndex = 7;
            btnMonthlySales.Text = "              Monthly Sales";
            btnMonthlySales.TextAlign = ContentAlignment.MiddleLeft;
            btnMonthlySales.UseVisualStyleBackColor = false;
            // 
            // btnYearlySales
            // 
            btnYearlySales.BackColor = Color.DarkSlateGray;
            btnYearlySales.FlatAppearance.BorderSize = 0;
            btnYearlySales.FlatStyle = FlatStyle.Flat;
            btnYearlySales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnYearlySales.ForeColor = Color.FromArgb(224, 224, 224);
            btnYearlySales.Image = Properties.Resources.icons8_dot_161;
            btnYearlySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnYearlySales.Location = new Point(3, 555);
            btnYearlySales.Name = "btnYearlySales";
            btnYearlySales.Padding = new Padding(35, 0, 0, 0);
            btnYearlySales.Size = new Size(227, 36);
            btnYearlySales.TabIndex = 8;
            btnYearlySales.Text = "              Yearly Sales";
            btnYearlySales.TextAlign = ContentAlignment.MiddleLeft;
            btnYearlySales.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 59, 59);
            panel5.Controls.Add(btnStock);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(3, 597);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 34);
            panel5.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(35, 59, 59);
            panel7.Controls.Add(btnAnalysis);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(3, 637);
            panel7.Name = "panel7";
            panel7.Size = new Size(232, 34);
            panel7.TabIndex = 6;
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sidebar.BackColor = Color.DarkSlateGray;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnProductCategory);
            sidebar.Controls.Add(btnProductTypes);
            sidebar.Controls.Add(btnProductDetails);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(btnPurchaseReturn);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(btnSalesReturn);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(btnDailySales);
            sidebar.Controls.Add(btnMonthlySales);
            sidebar.Controls.Add(btnYearlySales);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel7);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(230, 1000);
            sidebar.MinimumSize = new Size(83, 1000);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(230, 1000);
            sidebar.TabIndex = 1;
            sidebar.WrapContents = false;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(35, 59, 59);
            btnLogout.Image = Properties.Resources.icons8_logout_24__2_;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(667, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(124, 47);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "        Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // userctrlMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLogout);
            Controls.Add(sidebar);
            Name = "userctrlMenu";
            Size = new Size(791, 729);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubtn).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer ProductsTimer;
        private Panel panel1;
        private Label label1;
        private PictureBox menubtn;
        private Button btnAnalysis;
        private Panel panel2;
        private Button products;
        private Button btnStock;
        private Button btnProductCategory;
        private Button btnProductTypes;
        private Button btnProductDetails;
        private Panel panel3;
        private Button btnPurchases;
        private Button btnReport;
        private Button btnPurchaseReturn;
        private Panel panel4;
        private Button btnSale;
        private System.Windows.Forms.Timer siderbarTimer;
        private Button btnSalesReturn;
        private Panel panel6;
        private Button btnDailySales;
        private Button btnMonthlySales;
        private Button btnYearlySales;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private FlowLayoutPanel sidebar;
        private Button btnLogout;
    }
}
