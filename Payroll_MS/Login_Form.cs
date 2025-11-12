using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Payroll_MS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection(@"Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=payroll_DBMS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        
        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;
            try
            {
                string querry = "SELECT Username, Password FROM tbladmin WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if(dataTable.Rows.Count > 0)
                {
                    username=txtUsername.Text;
                    password=txtPassword.Text;
                    Main_Menu form2 = new Main_Menu();
                    form2.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
