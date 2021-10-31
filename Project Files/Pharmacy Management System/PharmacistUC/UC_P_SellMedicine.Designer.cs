
namespace Pharmacy_Management_System.PharmacistUC
{
    partial class UC_P_SellMedicine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_SellMedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrandName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoOfUnits = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExpireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddtoCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicineInfoReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtsearchbyMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.medicineListbox = new System.Windows.Forms.ListBox();
            this.viewCartGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.totalMedicineLabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewCartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 51);
            this.label1.TabIndex = 67;
            this.label1.Text = "Sell Medicine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BorderColor = System.Drawing.Color.Navy;
            this.btnRemoveFromCart.BorderRadius = 20;
            this.btnRemoveFromCart.BorderThickness = 2;
            this.btnRemoveFromCart.CheckedState.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.CustomImages.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveFromCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveFromCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveFromCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveFromCart.DisabledState.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveFromCart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(216)))), ((int)(((byte)(250)))));
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRemoveFromCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(216)))), ((int)(((byte)(250)))));
            this.btnRemoveFromCart.HoverState.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCart.Image")));
            this.btnRemoveFromCart.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRemoveFromCart.Location = new System.Drawing.Point(360, 727);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.PressedColor = System.Drawing.Color.MidnightBlue;
            this.btnRemoveFromCart.ShadowDecoration.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.Size = new System.Drawing.Size(170, 45);
            this.btnRemoveFromCart.TabIndex = 70;
            this.btnRemoveFromCart.Text = "Remove";
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnPrintPurchase
            // 
            this.btnPrintPurchase.BorderRadius = 20;
            this.btnPrintPurchase.CheckedState.Parent = this.btnPrintPurchase;
            this.btnPrintPurchase.CustomImages.Parent = this.btnPrintPurchase;
            this.btnPrintPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintPurchase.DisabledState.Parent = this.btnPrintPurchase;
            this.btnPrintPurchase.FillColor = System.Drawing.Color.Navy;
            this.btnPrintPurchase.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPrintPurchase.HoverState.Parent = this.btnPrintPurchase;
            this.btnPrintPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPurchase.Image")));
            this.btnPrintPurchase.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrintPurchase.Location = new System.Drawing.Point(771, 727);
            this.btnPrintPurchase.Name = "btnPrintPurchase";
            this.btnPrintPurchase.ShadowDecoration.Parent = this.btnPrintPurchase;
            this.btnPrintPurchase.Size = new System.Drawing.Size(314, 45);
            this.btnPrintPurchase.TabIndex = 71;
            this.btnPrintPurchase.Text = "Sell";
            this.btnPrintPurchase.Click += new System.EventHandler(this.btnPrintPurchase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.AcceptsTab = true;
            this.txtMedicineName.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.DefaultText = "";
            this.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.DisabledState.Parent = this.txtMedicineName;
            this.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.FocusedState.Parent = this.txtMedicineName;
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.White;
            this.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.HoverState.Parent = this.txtMedicineName;
            this.txtMedicineName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMedicineName.IconLeft")));
            this.txtMedicineName.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtMedicineName.Location = new System.Drawing.Point(402, 103);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PasswordChar = '\0';
            this.txtMedicineName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtMedicineName.PlaceholderText = "Medicine Name";
            this.txtMedicineName.ReadOnly = true;
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.ShadowDecoration.Parent = this.txtMedicineName;
            this.txtMedicineName.Size = new System.Drawing.Size(305, 53);
            this.txtMedicineName.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 75;
            this.label2.Text = "Price per Unit";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.AcceptsTab = true;
            this.txtPricePerUnit.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.White;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.HoverState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPricePerUnit.IconLeft")));
            this.txtPricePerUnit.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtPricePerUnit.Location = new System.Drawing.Point(771, 103);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPricePerUnit.PlaceholderText = "Price per unit";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.ShadowDecoration.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Size = new System.Drawing.Size(305, 53);
            this.txtPricePerUnit.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Brand Name";
            // 
            // txtBrandName
            // 
            this.txtBrandName.AcceptsTab = true;
            this.txtBrandName.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtBrandName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrandName.DefaultText = "";
            this.txtBrandName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrandName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrandName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandName.DisabledState.Parent = this.txtBrandName;
            this.txtBrandName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandName.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtBrandName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandName.FocusedState.Parent = this.txtBrandName;
            this.txtBrandName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.ForeColor = System.Drawing.Color.White;
            this.txtBrandName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandName.HoverState.Parent = this.txtBrandName;
            this.txtBrandName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBrandName.IconLeft")));
            this.txtBrandName.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtBrandName.Location = new System.Drawing.Point(402, 210);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.PasswordChar = '\0';
            this.txtBrandName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBrandName.PlaceholderText = "Brand Name";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.SelectedText = "";
            this.txtBrandName.ShadowDecoration.Parent = this.txtBrandName;
            this.txtBrandName.Size = new System.Drawing.Size(305, 53);
            this.txtBrandName.TabIndex = 76;
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtBrandName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(767, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 79;
            this.label5.Text = "No of Units";
            // 
            // txtNoOfUnits
            // 
            this.txtNoOfUnits.AcceptsTab = true;
            this.txtNoOfUnits.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtNoOfUnits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfUnits.DefaultText = "0";
            this.txtNoOfUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoOfUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoOfUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoOfUnits.DisabledState.Parent = this.txtNoOfUnits;
            this.txtNoOfUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoOfUnits.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtNoOfUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoOfUnits.FocusedState.Parent = this.txtNoOfUnits;
            this.txtNoOfUnits.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfUnits.ForeColor = System.Drawing.Color.White;
            this.txtNoOfUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoOfUnits.HoverState.Parent = this.txtNoOfUnits;
            this.txtNoOfUnits.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNoOfUnits.IconLeft")));
            this.txtNoOfUnits.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtNoOfUnits.Location = new System.Drawing.Point(771, 210);
            this.txtNoOfUnits.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNoOfUnits.Name = "txtNoOfUnits";
            this.txtNoOfUnits.PasswordChar = '\0';
            this.txtNoOfUnits.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtNoOfUnits.PlaceholderText = "";
            this.txtNoOfUnits.SelectedText = "";
            this.txtNoOfUnits.SelectionStart = 1;
            this.txtNoOfUnits.ShadowDecoration.Parent = this.txtNoOfUnits;
            this.txtNoOfUnits.Size = new System.Drawing.Size(305, 53);
            this.txtNoOfUnits.TabIndex = 78;
            this.txtNoOfUnits.TextChanged += new System.EventHandler(this.txtNoOfUnits_TextChanged);
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.CheckedState.Parent = this.txtExpireDate;
            this.txtExpireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtExpireDate.HoverState.Parent = this.txtExpireDate;
            this.txtExpireDate.Location = new System.Drawing.Point(402, 325);
            this.txtExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.ShadowDecoration.Parent = this.txtExpireDate;
            this.txtExpireDate.Size = new System.Drawing.Size(305, 53);
            this.txtExpireDate.TabIndex = 81;
            this.txtExpireDate.Value = new System.DateTime(2021, 6, 16, 12, 10, 1, 389);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(398, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 80;
            this.label10.Text = "Expire Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(767, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 83;
            this.label6.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AcceptsTab = true;
            this.txtTotalPrice.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTotalPrice.IconLeft")));
            this.txtTotalPrice.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtTotalPrice.Location = new System.Drawing.Point(771, 318);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.PlaceholderText = "Total Price";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(305, 53);
            this.txtTotalPrice.TabIndex = 82;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BorderRadius = 20;
            this.btnAddtoCart.CheckedState.Parent = this.btnAddtoCart;
            this.btnAddtoCart.CustomImages.Parent = this.btnAddtoCart;
            this.btnAddtoCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddtoCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddtoCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddtoCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddtoCart.DisabledState.Parent = this.btnAddtoCart;
            this.btnAddtoCart.FillColor = System.Drawing.Color.Navy;
            this.btnAddtoCart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.HoverState.Parent = this.btnAddtoCart;
            this.btnAddtoCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddtoCart.Image")));
            this.btnAddtoCart.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnAddtoCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddtoCart.Location = new System.Drawing.Point(735, 398);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.ShadowDecoration.Parent = this.btnAddtoCart;
            this.btnAddtoCart.Size = new System.Drawing.Size(341, 45);
            this.btnAddtoCart.TabIndex = 84;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // btnMedicineInfoReset
            // 
            this.btnMedicineInfoReset.BorderColor = System.Drawing.Color.Navy;
            this.btnMedicineInfoReset.BorderRadius = 20;
            this.btnMedicineInfoReset.BorderThickness = 2;
            this.btnMedicineInfoReset.CheckedState.Parent = this.btnMedicineInfoReset;
            this.btnMedicineInfoReset.CustomImages.Parent = this.btnMedicineInfoReset;
            this.btnMedicineInfoReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicineInfoReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicineInfoReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicineInfoReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicineInfoReset.DisabledState.Parent = this.btnMedicineInfoReset;
            this.btnMedicineInfoReset.FillColor = System.Drawing.Color.Transparent;
            this.btnMedicineInfoReset.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(216)))), ((int)(((byte)(250)))));
            this.btnMedicineInfoReset.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineInfoReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMedicineInfoReset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(216)))), ((int)(((byte)(250)))));
            this.btnMedicineInfoReset.HoverState.Parent = this.btnMedicineInfoReset;
            this.btnMedicineInfoReset.ImageSize = new System.Drawing.Size(10, 10);
            this.btnMedicineInfoReset.Location = new System.Drawing.Point(542, 398);
            this.btnMedicineInfoReset.Name = "btnMedicineInfoReset";
            this.btnMedicineInfoReset.PressedColor = System.Drawing.Color.MidnightBlue;
            this.btnMedicineInfoReset.ShadowDecoration.Parent = this.btnMedicineInfoReset;
            this.btnMedicineInfoReset.Size = new System.Drawing.Size(161, 45);
            this.btnMedicineInfoReset.TabIndex = 85;
            this.btnMedicineInfoReset.Text = "Reset";
            // 
            // txtsearchbyMedicineName
            // 
            this.txtsearchbyMedicineName.BackColor = System.Drawing.Color.Navy;
            this.txtsearchbyMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchbyMedicineName.DefaultText = "";
            this.txtsearchbyMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearchbyMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearchbyMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchbyMedicineName.DisabledState.Parent = this.txtsearchbyMedicineName;
            this.txtsearchbyMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchbyMedicineName.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtsearchbyMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchbyMedicineName.FocusedState.Parent = this.txtsearchbyMedicineName;
            this.txtsearchbyMedicineName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbyMedicineName.ForeColor = System.Drawing.Color.White;
            this.txtsearchbyMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchbyMedicineName.HoverState.Parent = this.txtsearchbyMedicineName;
            this.txtsearchbyMedicineName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtsearchbyMedicineName.IconLeft")));
            this.txtsearchbyMedicineName.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtsearchbyMedicineName.IconRight = ((System.Drawing.Image)(resources.GetObject("txtsearchbyMedicineName.IconRight")));
            this.txtsearchbyMedicineName.IconRightOffset = new System.Drawing.Point(6, 0);
            this.txtsearchbyMedicineName.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtsearchbyMedicineName.Location = new System.Drawing.Point(32, 131);
            this.txtsearchbyMedicineName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsearchbyMedicineName.Name = "txtsearchbyMedicineName";
            this.txtsearchbyMedicineName.PasswordChar = '\0';
            this.txtsearchbyMedicineName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtsearchbyMedicineName.PlaceholderText = "  Search";
            this.txtsearchbyMedicineName.SelectedText = "";
            this.txtsearchbyMedicineName.ShadowDecoration.Parent = this.txtsearchbyMedicineName;
            this.txtsearchbyMedicineName.Size = new System.Drawing.Size(281, 53);
            this.txtsearchbyMedicineName.TabIndex = 86;
            this.txtsearchbyMedicineName.TextChanged += new System.EventHandler(this.txtsearchbyMedicineName_TextChanged);
            // 
            // medicineListbox
            // 
            this.medicineListbox.BackColor = System.Drawing.Color.RoyalBlue;
            this.medicineListbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.medicineListbox.ForeColor = System.Drawing.Color.White;
            this.medicineListbox.FormattingEnabled = true;
            this.medicineListbox.ItemHeight = 28;
            this.medicineListbox.Location = new System.Drawing.Point(32, 196);
            this.medicineListbox.Name = "medicineListbox";
            this.medicineListbox.Size = new System.Drawing.Size(281, 564);
            this.medicineListbox.TabIndex = 87;
            this.medicineListbox.SelectedIndexChanged += new System.EventHandler(this.medicineListbox_SelectedIndexChanged);
            // 
            // viewCartGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewCartGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewCartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewCartGridView.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.viewCartGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewCartGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewCartGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewCartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewCartGridView.ColumnHeadersHeight = 28;
            this.viewCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCartGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewCartGridView.EnableHeadersVisualStyles = false;
            this.viewCartGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewCartGridView.Location = new System.Drawing.Point(346, 456);
            this.viewCartGridView.Name = "viewCartGridView";
            this.viewCartGridView.RowHeadersVisible = false;
            this.viewCartGridView.RowHeadersWidth = 51;
            this.viewCartGridView.RowTemplate.Height = 24;
            this.viewCartGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewCartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCartGridView.Size = new System.Drawing.Size(739, 247);
            this.viewCartGridView.TabIndex = 88;
            this.viewCartGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewCartGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewCartGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewCartGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewCartGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewCartGridView.ThemeStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewCartGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewCartGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.viewCartGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewCartGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewCartGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewCartGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewCartGridView.ThemeStyle.HeaderStyle.Height = 28;
            this.viewCartGridView.ThemeStyle.ReadOnly = false;
            this.viewCartGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewCartGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewCartGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewCartGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewCartGridView.ThemeStyle.RowsStyle.Height = 24;
            this.viewCartGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewCartGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewCartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCartGridView_CellClick);
            // 
            // totalMedicineLabel
            // 
            this.totalMedicineLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.totalMedicineLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMedicineLabel.ForeColor = System.Drawing.Color.Black;
            this.totalMedicineLabel.Location = new System.Drawing.Point(544, 727);
            this.totalMedicineLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalMedicineLabel.MinimumSize = new System.Drawing.Size(42, 39);
            this.totalMedicineLabel.Name = "totalMedicineLabel";
            this.totalMedicineLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.totalMedicineLabel.Size = new System.Drawing.Size(214, 45);
            this.totalMedicineLabel.TabIndex = 89;
            this.totalMedicineLabel.Text = "Rs.00";
            this.totalMedicineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalMedicineLabel.Click += new System.EventHandler(this.totalMedicine_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No of Units";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expire Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Unit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Brand Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // UC_P_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.totalMedicineLabel);
            this.Controls.Add(this.viewCartGridView);
            this.Controls.Add(this.medicineListbox);
            this.Controls.Add(this.txtsearchbyMedicineName);
            this.Controls.Add(this.btnMedicineInfoReset);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoOfUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnPrintPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_SellMedicine";
            this.Size = new System.Drawing.Size(1127, 862);
            this.Load += new System.EventHandler(this.UC_P_SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewCartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRemoveFromCart;
        private Guna.UI2.WinForms.Guna2Button btnPrintPurchase;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBrandName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNoOfUnits;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpireDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnAddtoCart;
        private Guna.UI2.WinForms.Guna2Button btnMedicineInfoReset;
        private Guna.UI2.WinForms.Guna2TextBox txtsearchbyMedicineName;
        private System.Windows.Forms.ListBox medicineListbox;
        private Guna.UI2.WinForms.Guna2DataGridView viewCartGridView;
        private System.Windows.Forms.Label totalMedicineLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
