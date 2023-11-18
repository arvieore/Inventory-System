namespace Inventory_Management_System.Forms
{
    partial class Create
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateRole = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select which one of this you want to create";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnCreateAccount.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAccount.Image = global::Inventory_Management_System.Properties.Resources.acc;
            this.btnCreateAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreateAccount.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCreateAccount.Location = new System.Drawing.Point(27, 105);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(182, 71);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Account";
            this.btnCreateAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateRole.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateRole.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnCreateRole.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreateRole.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCreateRole.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateRole.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRole.Image = global::Inventory_Management_System.Properties.Resources.coordinate;
            this.btnCreateRole.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreateRole.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCreateRole.Location = new System.Drawing.Point(256, 105);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(182, 71);
            this.btnCreateRole.TabIndex = 1;
            this.btnCreateRole.Text = "Role";
            this.btnCreateRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 208);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCreateRole;
        private Guna.UI2.WinForms.Guna2Button btnCreateAccount;
    }
}