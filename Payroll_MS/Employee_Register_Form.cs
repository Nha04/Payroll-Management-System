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
    public partial class Employee_Register_Form : Form
    {
        string filename;
        SqlConnection Iconnect = new SqlConnection();
        MemoryStream ms = new MemoryStream();
        public Employee_Register_Form()
        {
            InitializeComponent();
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu main_Form = new Main_Menu();
            main_Form.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pb1.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        private void Employee_Register_Form_Load(object sender, EventArgs e)
        {
            //catch error
            try
            {
                //call connection string
                Iconnect.ConnectionString = @"Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=payroll_DBMS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;MultipleActiveResultSets=True;";
                Iconnect.Open();

                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //class to load data
        private void loadData()
        {
            string sqlSelect = "select Empid,Name,Position,Mobile,Gender,PANNo,Dob,BankDetails,Address,ImageData from tblemployees";
            SqlCommand cmd = new SqlCommand(sqlSelect, Iconnect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    dataGridView1.Rows.Add(rd["Empid"].ToString(), rd["Name"].ToString(), rd["Position"].ToString(), rd["Mobile"].ToString(), rd["Gender"].ToString(), rd["PANNo"].ToString(), rd["Dob"].ToString(), rd["BankDetails"].ToString(), rd["Address"].ToString(), rd["ImageData"].ToString());
                }
                rd.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string sql statement
            try
            {
                string sqldelete = "delete from tblemployees where Empid='" + txtID.Text + "'";
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // string sql statement
                string InsertData = "insert into tblemployees(Empid, Name, Position, Mobile, Gender, PANNo, Dob, BankDetails, Address, ImageData) values(@Empid, @Name, @Position, @Mobile, @Gender, @PANNo, @Dob, @BankDetails, @Address, @ImageData)";
                //sql library
                SqlCommand cm = new SqlCommand(InsertData, Iconnect);
                cm.CommandType = CommandType.Text;

                cm.Parameters.AddWithValue("@Empid", txtID.Text);

                SqlParameter staffname = cm.Parameters.AddWithValue("@Name", txtName.Text);
                staffname.SqlDbType = SqlDbType.NVarChar; //change staff name into khmer

                cm.Parameters.AddWithValue("@Position", cmbPosition.Text);

                SqlParameter mb = cm.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                mb.SqlDbType = SqlDbType.NVarChar;

                SqlParameter gd = cm.Parameters.AddWithValue("@Gender", cmbGender.Text);
                gd.SqlDbType = SqlDbType.NVarChar;

                cm.Parameters.AddWithValue("@PANNo", txtPANno.Text);

                cm.Parameters.AddWithValue("@Dob", DOBdate.Text);

                cm.Parameters.AddWithValue("@BankDetails", txtBankDetail.Text);

                cm.Parameters.AddWithValue("@Address", txtAddress.Text);

                //insert photo
                if (pb1.Image != null)
                {
                    pb1.Image.Save(ms, ImageFormat.Jpeg);
                    //pcbProfile.Image.Save(ms, ImageFormat.Png);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    cm.Parameters.AddWithValue("@ImageData", photo_aray);
                }
                cm.ExecuteNonQuery();
                MessageBox.Show("Save successfully");
                dataGridView1.Rows.Clear();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string UpdateData = "Update tblemployee set Name=@Name, Position=@Position, Mobile=@Mobile, Gender=@Gender, PANNo=@PANNo, Dob=@Dob, BankDetails=@BankDetails, Address=@Address where Empid=@Empid";
            SqlCommand cm1 = new SqlCommand(UpdateData, Iconnect);
            cm1.Parameters.AddWithValue("@Empid", txtID.Text);
            cm1.Parameters.AddWithValue("@Name", txtName.Text);
            cm1.Parameters.AddWithValue("@Position", cmbPosition.Text);
            cm1.Parameters.AddWithValue("@Mobile", txtMobile.Text);
            cm1.Parameters.AddWithValue("@Gender", cmbGender.Text);
            cm1.Parameters.AddWithValue("@PANNo", txtPANno.Text);
            cm1.Parameters.AddWithValue("@Dob", DOBdate.Text);
            cm1.Parameters.AddWithValue("@BankDetails", txtBankDetail.Text);
            cm1.Parameters.AddWithValue("@Address", txtAddress.Text);
            cm1.ExecuteNonQuery();
            MessageBox.Show("Save successfully");
            dataGridView1.Rows.Clear();
            loadData();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            pb1.Image=null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            cmbPosition.Items.Clear();
            txtMobile.Text = "";
            cmbGender.Items.Clear();
            txtPANno.Text = "";
            DOBdate.Text = DateTime.Now.ToString();
            txtBankDetail.Text = "";
            txtAddress.Text = "";
            pb1.Image=null;
        }
    }
}
