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
    public partial class View_Emplyee_Form : Form
    {
        SqlConnection Iconnect = new SqlConnection();
        public View_Emplyee_Form()
        {
            InitializeComponent();
        }
        private void Fetchemp()
        {
            try
            {
                string query = "select * from tblemployees where Empid='" + txtempID.Text + "'  ";
                SqlCommand cmd = new SqlCommand(query, Iconnect);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lblid.Text = dr["Empid"].ToString();
                    lblName.Text = dr["Name"].ToString();
                    lblPosition.Text = dr["Position"].ToString();
                    lblMobile.Text = dr["Mobile"].ToString();
                    lblGender.Text = dr["Gender"].ToString();
                    lblPANNo.Text = dr["PANNo"].ToString();
                    lblDOB.Text = dr["Dob"].ToString();
                    lblBankDetails.Text = dr["BankDetails"].ToString();
                    lblAddress.Text = dr["Address"].ToString();


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
            Main_Menu main_Form = new Main_Menu();
            main_Form.ShowDialog();
        }

        private void View_Emplyee_Form_Load(object sender, EventArgs e)
        {
            //catch error
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtempID.Text = null;
            lblid.Text = null;
            lblName.Text = null;
            lblPosition.Text = null;
            lblMobile.Text = null;
            lblGender.Text = null;
            lblPANNo.Text = null;
            lblDOB.Text = null;
            lblBankDetails.Text = null;
            lblAddress.Text = null;

        }
    }
}
