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
    public partial class Summary : UserControl
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(825.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }
    }
}
