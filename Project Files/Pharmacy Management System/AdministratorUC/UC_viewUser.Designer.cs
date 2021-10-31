
namespace Pharmacy_Management_System.AdministratorUC
{
    partial class UC_viewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_viewUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchbyUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewUserGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewuserRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.totalUsers = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "View User";
            // 
            // txtsearchbyUsername
            // 
            this.txtsearchbyUsername.BackColor = System.Drawing.Color.Navy;
            this.txtsearchbyUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchbyUsername.DefaultText = "";
            this.txtsearchbyUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearchbyUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearchbyUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchbyUsername.DisabledState.Parent = this.txtsearchbyUsername;
            this.txtsearchbyUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchbyUsername.FillColor = System.Drawing.Color.RoyalBlue;
            this.txtsearchbyUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchbyUsername.FocusedState.Parent = this.txtsearchbyUsername;
            this.txtsearchbyUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbyUsername.ForeColor = System.Drawing.Color.White;
            this.txtsearchbyUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchbyUsername.HoverState.Parent = this.txtsearchbyUsername;
            this.txtsearchbyUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtsearchbyUsername.IconLeft")));
            this.txtsearchbyUsername.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtsearchbyUsername.IconRight = ((System.Drawing.Image)(resources.GetObject("txtsearchbyUsername.IconRight")));
            this.txtsearchbyUsername.IconRightOffset = new System.Drawing.Point(6, 0);
            this.txtsearchbyUsername.IconRightSize = new System.Drawing.Size(35, 35);
            this.txtsearchbyUsername.Location = new System.Drawing.Point(42, 140);
            this.txtsearchbyUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsearchbyUsername.Name = "txtsearchbyUsername";
            this.txtsearchbyUsername.PasswordChar = '\0';
            this.txtsearchbyUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtsearchbyUsername.PlaceholderText = "    Search by Username";
            this.txtsearchbyUsername.SelectedText = "";
            this.txtsearchbyUsername.ShadowDecoration.Parent = this.txtsearchbyUsername;
            this.txtsearchbyUsername.Size = new System.Drawing.Size(966, 53);
            this.txtsearchbyUsername.TabIndex = 17;
            this.txtsearchbyUsername.TextChanged += new System.EventHandler(this.txtsearchbyUsername_TextChanged);
            // 
            // viewUserGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewUserGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewUserGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewUserGridView.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.viewUserGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewUserGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewUserGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUserGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewUserGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewUserGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewUserGridView.EnableHeadersVisualStyles = false;
            this.viewUserGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewUserGridView.Location = new System.Drawing.Point(42, 222);
            this.viewUserGridView.Name = "viewUserGridView";
            this.viewUserGridView.RowHeadersVisible = false;
            this.viewUserGridView.RowHeadersWidth = 51;
            this.viewUserGridView.RowTemplate.Height = 24;
            this.viewUserGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewUserGridView.Size = new System.Drawing.Size(1043, 522);
            this.viewUserGridView.TabIndex = 18;
            this.viewUserGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewUserGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewUserGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewUserGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewUserGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewUserGridView.ThemeStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewUserGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewUserGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.viewUserGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewUserGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewUserGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewUserGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewUserGridView.ThemeStyle.HeaderStyle.Height = 28;
            this.viewUserGridView.ThemeStyle.ReadOnly = false;
            this.viewUserGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewUserGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewUserGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewUserGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewUserGridView.ThemeStyle.RowsStyle.Height = 24;
            this.viewUserGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewUserGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewUserGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUserGridView_CellClick);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BorderRadius = 20;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteUser.DisabledState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.FillColor = System.Drawing.Color.Navy;
            this.btnDeleteUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteUser.Location = new System.Drawing.Point(811, 764);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(274, 52);
            this.btnDeleteUser.TabIndex = 29;
            this.btnDeleteUser.Text = "Delete user";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnViewuserRefresh
            // 
            this.btnViewuserRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewuserRefresh.BackgroundImage")));
            this.btnViewuserRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewuserRefresh.CheckedState.Parent = this.btnViewuserRefresh;
            this.btnViewuserRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewuserRefresh.CustomImages.Parent = this.btnViewuserRefresh;
            this.btnViewuserRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewuserRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewuserRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewuserRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewuserRefresh.DisabledState.Parent = this.btnViewuserRefresh;
            this.btnViewuserRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnViewuserRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewuserRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewuserRefresh.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnViewuserRefresh.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnViewuserRefresh.HoverState.Parent = this.btnViewuserRefresh;
            this.btnViewuserRefresh.ImageSize = new System.Drawing.Size(37, 37);
            this.btnViewuserRefresh.Location = new System.Drawing.Point(1027, 143);
            this.btnViewuserRefresh.Name = "btnViewuserRefresh";
            this.btnViewuserRefresh.PressedColor = System.Drawing.Color.Transparent;
            this.btnViewuserRefresh.ShadowDecoration.BorderRadius = 15;
            this.btnViewuserRefresh.ShadowDecoration.Parent = this.btnViewuserRefresh;
            this.btnViewuserRefresh.Size = new System.Drawing.Size(49, 46);
            this.btnViewuserRefresh.TabIndex = 30;
            this.btnViewuserRefresh.Click += new System.EventHandler(this.btnViewuserRefresh_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // totalUsers
            // 
            this.totalUsers.BackColor = System.Drawing.Color.White;
            this.totalUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUsers.ForeColor = System.Drawing.Color.Black;
            this.totalUsers.Location = new System.Drawing.Point(290, 764);
            this.totalUsers.Margin = new System.Windows.Forms.Padding(0);
            this.totalUsers.MinimumSize = new System.Drawing.Size(42, 39);
            this.totalUsers.Name = "totalUsers";
            this.totalUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.totalUsers.Size = new System.Drawing.Size(64, 39);
            this.totalUsers.TabIndex = 31;
            this.totalUsers.Text = "0";
            this.totalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalUsers.Click += new System.EventHandler(this.totalUsers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(47, 764);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 39);
            this.label10.TabIndex = 32;
            this.label10.Text = "Total Users : ";
            // 
            // UC_viewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalUsers);
            this.Controls.Add(this.btnViewuserRefresh);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.viewUserGridView);
            this.Controls.Add(this.txtsearchbyUsername);
            this.Controls.Add(this.label1);
            this.Name = "UC_viewUser";
            this.Size = new System.Drawing.Size(1127, 862);
            this.Load += new System.EventHandler(this.UC_viewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewUserGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearchbyUsername;
        private Guna.UI2.WinForms.Guna2DataGridView viewUserGridView;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnViewuserRefresh;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label totalUsers;
        private System.Windows.Forms.Label label10;
    }
}
