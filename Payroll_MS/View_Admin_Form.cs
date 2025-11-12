using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Payroll_MS
{
    public partial class View_Admin_Form : Form
    {
        SqlConnection Iconnect = new SqlConnection();
        public View_Admin_Form()
        {
            InitializeComponent();
        }
        private void Fetchemp()
        {
            try
            {
                string query = "select * from tbladmin where AdminID='" + txtadviewID.Text + "'  ";
                SqlCommand cmd = new SqlCommand(query, Iconnect);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lbladID.Text = dr["AdminID"].ToString();
                    lbladName.Text = dr["Username"].ToString();
                    lbladPassword.Text = dr["Password"].ToString();
                    lbladEmail.Text = dr["Email"].ToString();
                    lbladDOB.Text = dr["DOB"].ToString();
                    lbladPhone.Text = dr["Phone"].ToString();
                    lbladRole.Text = dr["Role"].ToString();


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
            Main_Menu main11 = new Main_Menu();
            main11.Show();
        }
        private void View_Admin_Form_Load(object sender, EventArgs e)
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtadviewID.Text = null;
            lbladID.Text = null;
            lbladName.Text = null;
            lbladPassword.Text = null;
            lbladEmail.Text = null;
            lbladDOB.Text= null;
            lbladPhone.Text = null;
            lbladRole.Text = null;
        }
    }
}
