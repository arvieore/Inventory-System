using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class ClerksDashboard : Form
    {
        public ClerksDashboard()
        {
            InitializeComponent();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DisplayDashBoardUserControl()
        {
            Summary summary = new Summary();
            DisplayUserControl(summary);
        }
        //Display the User Controls
        public void DisplayUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnSwitchAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login switch_account = new Login();
            switch_account.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.White;

            btnHistory.FillColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;
            btnHistory.ForeColor = Color.White;

            btnReport.FillColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
            btnReport.ForeColor = Color.White;

            btnOrder.BackColor = Color.White;
            btnOrder.ForeColor = Color.Black;
            int x = 0;
            int y = 86;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            //Display the product User Control
            ProductControl productControl = new ProductControl();
            DisplayUserControl(productControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnOrder.FillColor = Color.Transparent;
            btnOrder.BackColor = Color.Transparent;
            btnOrder.ForeColor = Color.White;

            btnHistory.FillColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;
            btnHistory.ForeColor = Color.White;

            btnReport.FillColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
            btnReport.ForeColor = Color.White;

            btnDashboard.BackColor = Color.White;
            btnDashboard.ForeColor = Color.Black;
            int x = 0;
            int y = 43;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            DisplayDashBoardUserControl();
        }
    }
}
