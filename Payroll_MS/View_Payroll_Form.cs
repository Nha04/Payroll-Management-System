using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Payroll_MS
{
    public partial class View_Payroll_Form : Form
    {
        SqlConnection Iconnect = new SqlConnection();
        public View_Payroll_Form()
        {
            InitializeComponent();
        }
        private void Fetchemp1()
        {
            try
            {
                string query = "select * from tblempsalary where Empid='" + txtpID.Text + "'  ";
                SqlCommand cmd = new SqlCommand(query, Iconnect);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lblpID.Text = dr["Empid"].ToString();
                    lblpName.Text = dr["Name"].ToString();
                    lblpPosition.Text = dr["Position"].ToString();
                    lblpSalary.Text = dr["Salary"].ToString();
                    lblpPermission.Text = dr["Permission"].ToString();
                    lblpAbsent.Text = dr["Absent"].ToString();
                    lblpBonus.Text = dr["Bonus"].ToString();
                    lblpDeduction.Text = dr["Deduction"].ToString();
                    lblpTotal.Text = dr["TotalAmount"].ToString();


                }
                Iconnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu main_Formz = new Main_Menu();
            main_Formz.ShowDialog();
        }

        private void View_Payroll_Form_Load(object sender, EventArgs e)
        {
            try
            {
                //call connection string
                Iconnect.ConnectionString = @"Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=payroll_DBMS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;MultipleActiveResultSets=True;";
                Iconnect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnpView_Click(object sender, EventArgs e)
        {
            Fetchemp1();

        }

        private void btnpClear_Click(object sender, EventArgs e)
        {
            txtpID.Text = null;
            lblpID.Text = null;
            lblpName.Text = null;
            lblpPosition.Text = null;
            lblpSalary.Text = null;
            lblpPermission.Text = null;
            lblpAbsent.Text = null;
            lblpBonus.Text = null;
            lblpDeduction.Text = null;
            lblpTotal.Text = null;
        }
    }
}
