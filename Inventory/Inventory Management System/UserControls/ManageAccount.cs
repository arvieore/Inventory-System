using Inventory_Management_System.Models;
using Inventory_Management_System.Forms;
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
    public partial class ManageAccount : UserControl
    {
        private DB_InventoryEntities db;
        public ManageAccount()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }
        public void loadCbBoxRole()
        {
            // SELECT * FROM Role
            var roles = db.Role.ToList();

            Cbox_Roles.ValueMember = "roleID";
            Cbox_Roles.DisplayMember = "roleName";
            Cbox_Roles.DataSource = roles;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }

        private void dgv_Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
        }
    }
}
