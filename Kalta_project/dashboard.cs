using Kalta_project.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalta_project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            // cost control user control
            cost_control_uc uc = new cost_control_uc();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_dash_cost_control_Click(object sender, EventArgs e)
        {
            cost_control_uc uc = new cost_control_uc();
            addUserControl(uc);
        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            management_uc uc = new management_uc();
            addUserControl(uc);
        }
    }
}
