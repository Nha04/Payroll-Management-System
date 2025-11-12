using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace Payroll_MS
{
    public partial class Payroll_and_Position_Form : Form
    {
        SqlConnection Iconnect = new SqlConnection();

        public Payroll_and_Position_Form()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(txtpSalary.Text);
            double bonus = Convert.ToDouble(cmbBonus.Text);
            double bonussalary;
            if (bonus == 0)
            {
                bonussalary = salary;
            }
            else
            {
                bonussalary = salary + (salary * (bonus / 100));
            }
            txtBonusSalary.Text = txtTotal.Text = bonussalary.ToString();
        }
        private void btnCalculate1_Click(object sender, EventArgs e)
        {
            double dsalary = Convert.ToDouble(txtpSalary.Text);
            double deduction = Convert.ToDouble(cmbDeduction.Text);
            double deductionsalary;
            if(deduction == 0)
            {
                deductionsalary = dsalary;
            }
            else
            {
                deductionsalary = dsalary - (dsalary * (deduction / 100));
            }
            txtDeductionSalary.Text = txtTotal.Text = deductionsalary.ToString();

        }
        private void Payroll_and_Position_Form_Load(object sender, EventArgs e)
        {
            try
            {
                Iconnect.ConnectionString = @"Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=payroll_DBMS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;MultipleActiveResultSets=True;";
                Iconnect.Open();
                payrollloaddata();
            }
            catch (Exception)
            {

            }
        }
        private void payrollloaddata()
        {
            string sqlSelect = "select Empid,Name,Position,Salary,Permission,Absent,Bonus,Deduction,TotalAmount from tblempsalary";
            SqlCommand cmd = new SqlCommand(sqlSelect, Iconnect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    payrollview.Rows.Add(rd["Empid"].ToString(), rd["Name"].ToString(), rd["Position"].ToString(), rd["Salary"].ToString(), rd["Permission"].ToString(), rd["Absent"].ToString(), rd["Bonus"].ToString(), rd["Deduction"].ToString(), rd["TotalAmount"].ToString());
                }
                rd.Close();
            }
        }
        private void btnFormClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu main_zin = new Main_Menu();
            main_zin.Show();
        }

        private void btnpSave_Click(object sender, EventArgs e)
        {
            try
            {
                string InsertpData = "insert into tblempsalary(Empid, Name, Position, Salary, Permission, Absent, Bonus, Deduction, TotalAmount) values(@Empid, @Name, @Position, @Salary, @Permission, @Absent, @Bonus, @Deduction, @TotalAmount)";
                SqlCommand cm4 = new SqlCommand(InsertpData, Iconnect);
                cm4.CommandType = CommandType.Text;

                cm4.Parameters.AddWithValue("@Empid", txtpID.Text);

                SqlParameter empName = cm4.Parameters.AddWithValue("@Name", txtpName.Text);
                empName.SqlDbType = SqlDbType.NVarChar; //change staff name into khmer

                cm4.Parameters.AddWithValue("@Position", cmbPosition.Text);

                cm4.Parameters.AddWithValue("@Salary", txtpSalary.Text);

                cm4.Parameters.AddWithValue("@Permission", txtpPermission.Text);

                cm4.Parameters.AddWithValue("@Absent", txtpAbsent.Text);

                cm4.Parameters.AddWithValue("@Bonus", cmbBonus.Text);

                cm4.Parameters.AddWithValue("@Deduction", cmbDeduction.Text);

                cm4.Parameters.AddWithValue("@TotalAmount", txtTotal.Text);

                cm4.ExecuteNonQuery();
                MessageBox.Show("Save Successfully");
                payrollview.Rows.Clear();
                payrollloaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlpdelete = "delete from tblempsalary where Empid='" + txtpID.Text + "'";
                SqlCommand cm3 = new SqlCommand(sqlpdelete, Iconnect);
                cm3.CommandType = CommandType.Text;
                cm3.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnpUpdate_Click(object sender, EventArgs e)
        {
            string UpdatepData = "Update tblempsalary set Name=@Name, Position=@Position, Salary=@Salary, Permission=@Permission, Absent=@Absent, Bonus=@Bonus, Deduction=@Deduction, TotalAmount=@TotalAmount where Empid=@Empid";
            SqlCommand uppay = new SqlCommand(UpdatepData, Iconnect);
            uppay.Parameters.AddWithValue("@Empid", txtpID.Text);
            uppay.Parameters.AddWithValue("@Name", txtpName.Text);
            uppay.Parameters.AddWithValue("@Position", cmbPosition.Text);
            uppay.Parameters.AddWithValue("@Salary", txtpSalary.Text);
            uppay.Parameters.AddWithValue("@Permission", txtpPermission.Text);
            uppay.Parameters.AddWithValue("@Absent", txtpAbsent.Text);
            uppay.Parameters.AddWithValue("@Bonus", cmbBonus.Text);
            uppay.Parameters.AddWithValue("@Deduction", cmbDeduction.Text);
            uppay.Parameters.AddWithValue("@TotalAmount", txtTotal.Text);
            uppay.ExecuteNonQuery();
            MessageBox.Show("Save Successfully");
            payrollview.Rows.Clear();
            payrollloaddata();
        }

        private void btnpClear_Click(object sender, EventArgs e)
        {
            txtpID.Text = "";
            txtpName.Text = "";
            cmbPosition.Items.Clear();
            txtpSalary.Text = "";
            txtpPermission.Text = "";
            txtpAbsent.Text = "";
            cmbBonus.Items.Clear();
            cmbDeduction.Items.Clear();
            txtTotal.Text = "";
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
