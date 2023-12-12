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

namespace Inventory_Management_System.Functions
{
    public partial class ManagerDashboard : Form
    {
        public string account_fullname;
        public ManagerDashboard()
        {
            InitializeComponent();

            DisplayDashBoardUserControl();
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnProducts.FillColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnProducts.ForeColor = Color.White;

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

        private void btnProducts_Click(object sender, EventArgs e)
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

            btnProducts.BackColor = Color.White;
            btnProducts.ForeColor = Color.Black;
            int x = 0;
            int y = 86;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            //Display the product User Control
            ProductControl productControl = new ProductControl();
            DisplayUserControl(productControl);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnProducts.FillColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnProducts.ForeColor = Color.White;

            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.White;

            btnReport.FillColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
            btnReport.ForeColor = Color.White;

            btnHistory.BackColor = Color.White;
            btnHistory.ForeColor = Color.Black;
            int x = 0;
            int y = 129;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            HistoryControl historyControl = new HistoryControl();
            DisplayUserControl(historyControl);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnProducts.FillColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnProducts.ForeColor = Color.White;

            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.White;

            btnHistory.FillColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;
            btnHistory.ForeColor = Color.White;

            btnReport.BackColor = Color.White;
            btnReport.ForeColor = Color.Black;
            int x = 0;
            int y = 172;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            SalesReport sales = new SalesReport();
            DisplayUserControl(sales);
        }

        private void btnSwitchAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login switch_account = new Login();
            switch_account.Show();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            lblFullname.Text = account_fullname;
        }
    }
}
