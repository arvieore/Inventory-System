﻿namespace Inventory_Management_System.Forms
{
    partial class ClerksDashboard
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnSwitchAccount = new Guna.UI2.WinForms.Guna2Button();
            this.panelHover = new System.Windows.Forms.Panel();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFullname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnCart);
            this.guna2GradientPanel1.Controls.Add(this.btnSwitchAccount);
            this.guna2GradientPanel1.Controls.Add(this.panelHover);
            this.guna2GradientPanel1.Controls.Add(this.btnHistory);
            this.guna2GradientPanel1.Controls.Add(this.btnOrder);
            this.guna2GradientPanel1.Controls.Add(this.btnDashboard);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 639);
            this.guna2GradientPanel1.TabIndex = 15;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.FillColor = System.Drawing.Color.Transparent;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCart.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(12, 129);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(188, 43);
            this.btnCart.TabIndex = 6;
            this.btnCart.Text = "Cart";
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnSwitchAccount
            // 
            this.btnSwitchAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSwitchAccount.ForeColor = System.Drawing.Color.White;
            this.btnSwitchAccount.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchAccount.Image = global::Inventory_Management_System.Properties.Resources.Switch_account;
            this.btnSwitchAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSwitchAccount.ImageSize = new System.Drawing.Size(38, 38);
            this.btnSwitchAccount.Location = new System.Drawing.Point(12, 583);
            this.btnSwitchAccount.Name = "btnSwitchAccount";
            this.btnSwitchAccount.PressedColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.Size = new System.Drawing.Size(188, 44);
            this.btnSwitchAccount.TabIndex = 5;
            this.btnSwitchAccount.Text = "Switch account";
            this.btnSwitchAccount.Click += new System.EventHandler(this.btnSwitchAccount_Click);
            // 
            // panelHover
            // 
            this.panelHover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.panelHover.Location = new System.Drawing.Point(0, 43);
            this.panelHover.Name = "panelHover";
            this.panelHover.Size = new System.Drawing.Size(11, 43);
            this.panelHover.TabIndex = 1;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(12, 172);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(188, 43);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "History Transaction";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.FillColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(12, 86);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(188, 43);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(12, 43);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(188, 43);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblFullname);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.ExitIcon);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.guna2Panel1.Location = new System.Drawing.Point(200, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(996, 37);
            this.guna2Panel1.TabIndex = 16;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.White;
            this.lblFullname.Location = new System.Drawing.Point(24, 9);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(82, 20);
            this.lblFullname.TabIndex = 4;
            this.lblFullname.Text = "Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hi";
            // 
            // ExitIcon
            // 
            this.ExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitIcon.FillColor = System.Drawing.Color.Transparent;
            this.ExitIcon.Image = global::Inventory_Management_System.Properties.Resources.reject_removebg_preview;
            this.ExitIcon.ImageRotate = 0F;
            this.ExitIcon.Location = new System.Drawing.Point(977, 0);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(19, 37);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 0;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(996, 602);
            this.MainPanel.TabIndex = 17;
            // 
            // ClerksDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 639);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClerksDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClerksDashboard";
            this.Load += new System.EventHandler(this.ClerksDashboard_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSwitchAccount;
        private System.Windows.Forms.Panel panelHover;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ExitIcon;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCart;
    }
}