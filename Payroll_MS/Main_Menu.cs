using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Payroll_MS
{
    public partial class Main_Menu : Form

    {
        SqlConnection Iconnect = new SqlConnection();
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btnMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form login_page = new Login_Form();
            login_page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Register_Form register_Form = new Employee_Register_Form();
            register_Form.Show();
        }

        private void employee_Register1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Emplyee_Form view_Form = new View_Emplyee_Form();
            view_Form.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payroll_and_Position_Form payroll_and_Position_ = new Payroll_and_Position_Form();
            payroll_and_Position_.Show();
        }

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Payroll_Form viewpay = new View_Payroll_Form();
            viewpay.Show();
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Register_Form regiadmin = new Admin_Register_Form();
            regiadmin.Show();
        }

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Admin_Form viewadmin = new View_Admin_Form();
            viewadmin.Show();
        }
    }
}
