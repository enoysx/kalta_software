using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Kalta_project
{
    public partial class login_form : Form
    {
        connection conn = new connection();

        public login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txt_user_login.Text))
                {
                    lbl_info_login.Text = " Masukan Username / Password ";
                } else if  (string.IsNullOrEmpty(txt_pass_login.Text))
                {
                    lbl_info_login.Text = " Masukan Username / Password ";
                }
                else 
                    try
                    {
                        
                    }
            } 

            catch (Exception)
            {
                Console.WriteLine("exception caught", e);
            }
        }
    }
}
