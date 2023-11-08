namespace Inventory_Management_System.UserControls
{
    partial class Summary
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
            this.PanelStocks = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelCategory = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelItems = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelStocks.SuspendLayout();
            this.PanelCategory.SuspendLayout();
            this.PanelItems.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStocks
            // 
            this.PanelStocks.BorderRadius = 10;
            this.PanelStocks.Controls.Add(this.label5);
            this.PanelStocks.Controls.Add(this.label4);
            this.PanelStocks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(9)))), ((int)(((byte)(125)))));
            this.PanelStocks.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(96)))), ((int)(((byte)(161)))));
            this.PanelStocks.Location = new System.Drawing.Point(595, 68);
            this.PanelStocks.Name = "PanelStocks";
            this.PanelStocks.Size = new System.Drawing.Size(231, 159);
            this.PanelStocks.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Out of stocks";
            // 
            // PanelCategory
            // 
            this.PanelCategory.BackColor = System.Drawing.Color.Transparent;
            this.PanelCategory.BorderRadius = 10;
            this.PanelCategory.Controls.Add(this.lblTotalCategory);
            this.PanelCategory.Controls.Add(this.label3);
            this.PanelCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.PanelCategory.Location = new System.Drawing.Point(303, 68);
            this.PanelCategory.Name = "PanelCategory";
            this.PanelCategory.Size = new System.Drawing.Size(231, 159);
            this.PanelCategory.TabIndex = 1;
            // 
            // lblTotalCategory
            // 
            this.lblTotalCategory.AutoSize = true;
            this.lblTotalCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategory.ForeColor = System.Drawing.Color.White;
            this.lblTotalCategory.Location = new System.Drawing.Point(56, 74);
            this.lblTotalCategory.Name = "lblTotalCategory";
            this.lblTotalCategory.Size = new System.Drawing.Size(0, 31);
            this.lblTotalCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Category";
            // 
            // PanelItems
            // 
            this.PanelItems.BackColor = System.Drawing.Color.Transparent;
            this.PanelItems.BorderRadius = 10;
            this.PanelItems.Controls.Add(this.lblTotalProduct);
            this.PanelItems.Controls.Add(this.label2);
            this.PanelItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.PanelItems.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.PanelItems.Location = new System.Drawing.Point(7, 68);
            this.PanelItems.Name = "PanelItems";
            this.PanelItems.Size = new System.Drawing.Size(231, 159);
            this.PanelItems.TabIndex = 1;
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduct.ForeColor = System.Drawing.Color.White;
            this.lblTotalProduct.Location = new System.Drawing.Point(56, 74);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(0, 31);
            this.lblTotalProduct.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Products";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(829, 44);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PanelStocks);
            this.panel1.Controls.Add(this.PanelCategory);
            this.panel1.Controls.Add(this.PanelItems);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 496);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Summary";
            this.Size = new System.Drawing.Size(857, 531);
            this.Load += new System.EventHandler(this.Summary_Load);
            this.PanelStocks.ResumeLayout(false);
            this.PanelStocks.PerformLayout();
            this.PanelCategory.ResumeLayout(false);
            this.PanelCategory.PerformLayout();
            this.PanelItems.ResumeLayout(false);
            this.PanelItems.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel PanelStocks;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelCategory;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblTotalCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
