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
using System.Data.SqlClient;
using System.Drawing.Imaging;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Payroll_MS
{
    public partial class Admin_Register_Form : Form
    {
        SqlConnection Iconnect = new SqlConnection();
        public Admin_Register_Form()
        {
            InitializeComponent();
        }
        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu mainz = new Main_Menu();
            mainz.ShowDialog();
        }

        private void Admin_Register_Form_Load(object sender, EventArgs e)
        {
            try
            {
                //call connection string
                Iconnect.ConnectionString = @"Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=payroll_DBMS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;MultipleActiveResultSets=True;";
                Iconnect.Open();

                adloadData();
            }
            catch (Exception ex)
            {

            }
        }

        private void adloadData()
        {
            string sqlSelect = "select AdminID,Username,Password,Email,DOB,Phone,Role from tbladmin";
            SqlCommand cmd = new SqlCommand(sqlSelect, Iconnect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    viewAdmin.Rows.Add(rd["AdminID"].ToString(), rd["Username"].ToString(), rd["Password"].ToString(), rd["Email"].ToString(), rd["DOB"].ToString(), rd["Phone"].ToString(), rd["Role"].ToString());
                }
                rd.Close();
            }
        }

        private void btnadDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sqldelete = "delete from tbladmin where AdminID='" + txtadID.Text + "'";
                SqlCommand cm = new SqlCommand(sqldelete, Iconnect);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadSave_Click(object sender, EventArgs e)
        {
            try
            {
                // string sql statement
                string InsertData = "insert into tbladmin(AdminID, Username, Password, Email, DOB, Phone, Role) values(@AdminID, @Username, @Password, @Email, @DOB, @Phone, @Role)";
                //sql library
                SqlCommand cm11 = new SqlCommand(InsertData, Iconnect);
                cm11.CommandType = CommandType.Text;

                cm11.Parameters.AddWithValue("@AdminID", txtadID.Text);

                SqlParameter staffname = cm11.Parameters.AddWithValue("@Username", txtadUsername.Text);
                staffname.SqlDbType = SqlDbType.NVarChar; //change staff name into khmer

                cm11.Parameters.AddWithValue("@Password", txtadPassword.Text);

                cm11.Parameters.AddWithValue("@Email", txtadEmail.Text);

                cm11.Parameters.AddWithValue("@DOB", adminDOB.Text);

                cm11.Parameters.AddWithValue("@Phone", txtadPhone.Text);

                cm11.Parameters.AddWithValue("@Role", cmbRole.Text);

                cm11.ExecuteNonQuery();
                MessageBox.Show("Save successfully");
                viewAdmin.Rows.Clear();
                adloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadUpdate_Click(object sender, EventArgs e)
        {
            string UpdateData = "Update tbladmin set Username=@Username, Password=@Password, Email=@Email, Phone=@Phone, Role=@Role where AdminID=@AdminID";
            SqlCommand cm1 = new SqlCommand(UpdateData, Iconnect);
            cm1.Parameters.AddWithValue("@AdminID", txtadID.Text);
            cm1.Parameters.AddWithValue("@Username", txtadUsername.Text);
            cm1.Parameters.AddWithValue("@Password", txtadPassword.Text);
            cm1.Parameters.AddWithValue("@Email", txtadEmail.Text);
            cm1.Parameters.AddWithValue("@DOB", adminDOB.Text);
            cm1.Parameters.AddWithValue("@Phone", txtadPhone.Text);
            cm1.Parameters.AddWithValue("@Role", cmbRole.Text);
            cm1.ExecuteNonQuery();
            MessageBox.Show("Save successfully");
            viewAdmin.Rows.Clear();
            adloadData();
        }

        private void btnadClear_Click(object sender, EventArgs e)
        {
            txtadID.Text = "";
            txtadUsername.Text = "";
            txtadPassword.Text = "";
            txtadEmail.Text = "";
            adminDOB.Text = DateTime.Now.ToString();
            txtadPhone.Text = "";
            cmbRole.Items.Clear();

        }

        private void txtadID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
