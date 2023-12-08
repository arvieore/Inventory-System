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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelStocks = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCategory = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProduct = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Summary = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHover = new System.Windows.Forms.Panel();
            this.panelLowStock = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblLowOfStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelStocks.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Summary)).BeginInit();
            this.panelLowStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStocks
            // 
            this.panelStocks.BorderRadius = 10;
            this.panelStocks.Controls.Add(this.lblOutOfStock);
            this.panelStocks.Controls.Add(this.label4);
            this.panelStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelStocks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(9)))), ((int)(((byte)(125)))));
            this.panelStocks.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(96)))), ((int)(((byte)(161)))));
            this.panelStocks.Location = new System.Drawing.Point(495, 56);
            this.panelStocks.Name = "panelStocks";
            this.panelStocks.Size = new System.Drawing.Size(224, 177);
            this.panelStocks.TabIndex = 1;
            this.panelStocks.Click += new System.EventHandler(this.panelStocks_Click);
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.BackColor = System.Drawing.Color.Transparent;
            this.lblOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.ForeColor = System.Drawing.Color.White;
            this.lblOutOfStock.Location = new System.Drawing.Point(78, 74);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(0, 31);
            this.lblOutOfStock.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Out of stocks";
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.Transparent;
            this.panelCategory.BorderRadius = 10;
            this.panelCategory.Controls.Add(this.lblTotalCategory);
            this.panelCategory.Controls.Add(this.label3);
            this.panelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.panelCategory.Location = new System.Drawing.Point(251, 56);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(224, 177);
            this.panelCategory.TabIndex = 1;
            this.panelCategory.Click += new System.EventHandler(this.panelCategory_Click);
            // 
            // lblTotalCategory
            // 
            this.lblTotalCategory.AutoSize = true;
            this.lblTotalCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategory.ForeColor = System.Drawing.Color.White;
            this.lblTotalCategory.Location = new System.Drawing.Point(68, 74);
            this.lblTotalCategory.Name = "lblTotalCategory";
            this.lblTotalCategory.Size = new System.Drawing.Size(0, 31);
            this.lblTotalCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Category";
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.Transparent;
            this.panelProduct.BorderRadius = 10;
            this.panelProduct.Controls.Add(this.lblTotalProduct);
            this.panelProduct.Controls.Add(this.label2);
            this.panelProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panelProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.panelProduct.Location = new System.Drawing.Point(7, 56);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(224, 177);
            this.panelProduct.TabIndex = 1;
            this.panelProduct.Click += new System.EventHandler(this.panelProduct_Click);
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduct.ForeColor = System.Drawing.Color.White;
            this.lblTotalProduct.Location = new System.Drawing.Point(63, 74);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(0, 31);
            this.lblTotalProduct.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 46);
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
            this.panelHeader.Size = new System.Drawing.Size(967, 44);
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
            this.panel1.Controls.Add(this.dgv_Summary);
            this.panel1.Controls.Add(this.panelHover);
            this.panel1.Controls.Add(this.panelLowStock);
            this.panel1.Controls.Add(this.panelStocks);
            this.panel1.Controls.Add(this.panelCategory);
            this.panel1.Controls.Add(this.panelProduct);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgv_Summary
            // 
            this.dgv_Summary.AllowUserToAddRows = false;
            this.dgv_Summary.AllowUserToResizeColumns = false;
            this.dgv_Summary.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgv_Summary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Summary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Summary.ColumnHeadersHeight = 20;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Summary.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Summary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Summary.Location = new System.Drawing.Point(4, 263);
            this.dgv_Summary.Name = "dgv_Summary";
            this.dgv_Summary.ReadOnly = true;
            this.dgv_Summary.RowHeadersVisible = false;
            this.dgv_Summary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_Summary.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Summary.Size = new System.Drawing.Size(957, 252);
            this.dgv_Summary.TabIndex = 6;
            this.dgv_Summary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Summary.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Summary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Summary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Summary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Summary.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Summary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Summary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Summary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Summary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Summary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Summary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Summary.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_Summary.ThemeStyle.ReadOnly = true;
            this.dgv_Summary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Summary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Summary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Summary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Summary.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Summary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Summary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelHover
            // 
            this.panelHover.BackColor = System.Drawing.Color.Transparent;
            this.panelHover.Location = new System.Drawing.Point(7, 241);
            this.panelHover.Name = "panelHover";
            this.panelHover.Size = new System.Drawing.Size(224, 10);
            this.panelHover.TabIndex = 5;
            // 
            // panelLowStock
            // 
            this.panelLowStock.BorderRadius = 10;
            this.panelLowStock.Controls.Add(this.lblLowOfStock);
            this.panelLowStock.Controls.Add(this.label7);
            this.panelLowStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLowStock.FillColor = System.Drawing.Color.OrangeRed;
            this.panelLowStock.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelLowStock.Location = new System.Drawing.Point(738, 56);
            this.panelLowStock.Name = "panelLowStock";
            this.panelLowStock.Size = new System.Drawing.Size(224, 177);
            this.panelLowStock.TabIndex = 4;
            this.panelLowStock.Click += new System.EventHandler(this.panelLowStock_Click);
            // 
            // lblLowOfStock
            // 
            this.lblLowOfStock.AutoSize = true;
            this.lblLowOfStock.BackColor = System.Drawing.Color.Transparent;
            this.lblLowOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowOfStock.ForeColor = System.Drawing.Color.White;
            this.lblLowOfStock.Location = new System.Drawing.Point(90, 74);
            this.lblLowOfStock.Name = "lblLowOfStock";
            this.lblLowOfStock.Size = new System.Drawing.Size(0, 31);
            this.lblLowOfStock.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Low stock";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 267);
            this.panel2.TabIndex = 3;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Summary";
            this.Size = new System.Drawing.Size(996, 586);
            this.Load += new System.EventHandler(this.Summary_Load);
            this.panelStocks.ResumeLayout(false);
            this.panelStocks.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Summary)).EndInit();
            this.panelLowStock.ResumeLayout(false);
            this.panelLowStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel panelStocks;
        private Guna.UI2.WinForms.Guna2GradientPanel panelCategory;
        private Guna.UI2.WinForms.Guna2GradientPanel panelProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblTotalCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelLowStock;
        private System.Windows.Forms.Label lblLowOfStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelHover;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Summary;
    }
}
