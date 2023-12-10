using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.UserControls
{
    public partial class HistoryControl : UserControl
    {
        private DB_InventoryEntities db;
        public HistoryControl()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
        private void LoadHistory()
        {
            dgv_Transactions.DataSource = db.vw_History.ToList();
            dgv_Transactions.Columns["ID"].Width = 30;
            dgv_Transactions.Columns["Order_no"].HeaderText = "Order number";
            dgv_Transactions.Columns["Order_no"].Width = 85;

            dgv_Transactions.Columns["Products"].Width = 200;
            dgv_Transactions.Columns["Quantity"].Width = 50;
            dgv_Transactions.Columns["Total"].Width = 80;
            dgv_Transactions.Columns["Date"].Width = 85;

        }
    }
}