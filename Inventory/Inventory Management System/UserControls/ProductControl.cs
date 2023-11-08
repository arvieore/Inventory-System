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
    public partial class ProductControl : UserControl
    {
        private DB_InventoryEntities db;
        public ProductControl()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(825.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Category
            var categories = db.Category.ToList();

            Cbox_Category.ValueMember = "categoryID";
            Cbox_Category.DisplayMember = "categoryName";
            Cbox_Category.DataSource = categories;
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
