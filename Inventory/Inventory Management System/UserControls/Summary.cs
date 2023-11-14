using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.UserControls
{
    public partial class Summary : UserControl
    {
        private DB_InventoryEntities db;
        public Summary()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            RefreshSummary();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }
        private void RefreshSummary()
        {
            int countProduct = db.Products.Count();
            lblTotalProduct.Text = countProduct.ToString();

            int countCategory = db.Category.Count();
            lblTotalCategory.Text = countCategory.ToString();
        }
    }
}
