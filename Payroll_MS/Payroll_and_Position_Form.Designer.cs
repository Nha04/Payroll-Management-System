namespace Payroll_MS
{
    partial class Payroll_and_Position_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbPosition = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            btnpClear = new Button();
            btnpFormClose = new Button();
            btnpDelete = new Button();
            btnpUpdate = new Button();
            btnpSave = new Button();
            txtpName = new TextBox();
            txtTotal = new TextBox();
            txtpID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            txtpAbsent = new TextBox();
            cmbBonus = new ComboBox();
            cmbDeduction = new ComboBox();
            txtpSalary = new TextBox();
            txtpPermission = new TextBox();
            payrollview = new DataGridView();
            EmpPayrollID = new DataGridViewTextBoxColumn();
            EmpPayrollName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            Permission = new DataGridViewTextBoxColumn();
            Absent = new DataGridViewTextBoxColumn();
            Bonus = new DataGridViewTextBoxColumn();
            Deduction = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            btnCalculate = new Button();
            btnCalculate1 = new Button();
            label11 = new Label();
            txtBonusSalary = new TextBox();
            txtDeductionSalary = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)payrollview).BeginInit();
            SuspendLayout();
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = Color.Gainsboro;
            cmbPosition.FlatStyle = FlatStyle.Flat;
            cmbPosition.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.ForeColor = Color.Black;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Project Manager", "Analyst/Tester", "Senior Programmer", "Junior Programmer", "IT Support" });
            cmbPosition.Location = new Point(166, 125);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(250, 29);
            cmbPosition.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(79, 133);
            label10.Name = "label10";
            label10.Size = new Size(81, 22);
            label10.TabIndex = 90;
            label10.Text = "Position:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(447, 22);
            label9.Name = "label9";
            label9.Size = new Size(267, 38);
            label9.TabIndex = 89;
            label9.Text = "Employee Payroll";
            // 
            // btnpClear
            // 
            btnpClear.BackColor = Color.Blue;
            btnpClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnpClear.FlatStyle = FlatStyle.Flat;
            btnpClear.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnpClear.ForeColor = Color.White;
            btnpClear.Location = new Point(540, 327);
            btnpClear.Name = "btnpClear";
            btnpClear.Size = new Size(87, 29);
            btnpClear.TabIndex = 11;
            btnpClear.Text = "Clear";
            btnpClear.UseVisualStyleBackColor = false;
            btnpClear.Click += btnpClear_Click;
            // 
            // btnpFormClose
            // 
            btnpFormClose.BackColor = Color.FromArgb(192, 0, 0);
            btnpFormClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnpFormClose.FlatStyle = FlatStyle.Flat;
            btnpFormClose.Location = new Point(1000, 22);
            btnpFormClose.Name = "btnpFormClose";
            btnpFormClose.Size = new Size(39, 29);
            btnpFormClose.TabIndex = 13;
            btnpFormClose.Text = "X";
            btnpFormClose.UseVisualStyleBackColor = false;
            btnpFormClose.Click += btnFormClose_Click_1;
            // 
            // btnpDelete
            // 
            btnpDelete.BackColor = Color.Blue;
            btnpDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnpDelete.FlatStyle = FlatStyle.Flat;
            btnpDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnpDelete.ForeColor = Color.White;
            btnpDelete.Location = new Point(633, 327);
            btnpDelete.Name = "btnpDelete";
            btnpDelete.Size = new Size(87, 29);
            btnpDelete.TabIndex = 12;
            btnpDelete.Text = "Delete";
            btnpDelete.UseVisualStyleBackColor = false;
            btnpDelete.Click += btnpDelete_Click;
            // 
            // btnpUpdate
            // 
            btnpUpdate.BackColor = Color.Blue;
            btnpUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnpUpdate.FlatStyle = FlatStyle.Flat;
            btnpUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnpUpdate.ForeColor = Color.White;
            btnpUpdate.Location = new Point(447, 327);
            btnpUpdate.Name = "btnpUpdate";
            btnpUpdate.Size = new Size(87, 29);
            btnpUpdate.TabIndex = 10;
            btnpUpdate.Text = "Update";
            btnpUpdate.UseVisualStyleBackColor = false;
            btnpUpdate.Click += btnpUpdate_Click;
            // 
            // btnpSave
            // 
            btnpSave.BackColor = Color.Blue;
            btnpSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnpSave.FlatStyle = FlatStyle.Flat;
            btnpSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnpSave.ForeColor = Color.White;
            btnpSave.Location = new Point(354, 327);
            btnpSave.Name = "btnpSave";
            btnpSave.Size = new Size(87, 29);
            btnpSave.TabIndex = 9;
            btnpSave.Text = "Save";
            btnpSave.UseVisualStyleBackColor = false;
            btnpSave.Click += btnpSave_Click;
            // 
            // txtpName
            // 
            txtpName.BackColor = Color.Gainsboro;
            txtpName.BorderStyle = BorderStyle.FixedSingle;
            txtpName.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpName.ForeColor = Color.Black;
            txtpName.Location = new Point(690, 89);
            txtpName.Name = "txtpName";
            txtpName.Size = new Size(250, 30);
            txtpName.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Gainsboro;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(485, 282);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(250, 30);
            txtTotal.TabIndex = 76;
            // 
            // txtpID
            // 
            txtpID.BackColor = Color.Gainsboro;
            txtpID.BorderStyle = BorderStyle.FixedSingle;
            txtpID.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpID.ForeColor = Color.Black;
            txtpID.Location = new Point(166, 89);
            txtpID.Name = "txtpID";
            txtpID.Size = new Size(250, 30);
            txtpID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(608, 170);
            label8.Name = "label8";
            label8.Size = new Size(76, 22);
            label8.TabIndex = 71;
            label8.Text = "Absent:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(577, 204);
            label7.Name = "label7";
            label7.Size = new Size(106, 22);
            label7.TabIndex = 70;
            label7.Text = "Deduction:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(616, 133);
            label6.Name = "label6";
            label6.Size = new Size(68, 22);
            label6.TabIndex = 69;
            label6.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(610, 96);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 68;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(353, 290);
            label4.Name = "label4";
            label4.Size = new Size(129, 22);
            label4.TabIndex = 67;
            label4.Text = "Total Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(93, 204);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 66;
            label3.Text = "Bonus:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(53, 170);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 65;
            label2.Text = "Permission:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(79, 97);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 64;
            label1.Text = "Emp ID :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 10);
            panel2.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 569);
            panel3.TabIndex = 61;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1045, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 569);
            panel4.TabIndex = 63;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 10);
            panel1.TabIndex = 60;
            // 
            // txtpAbsent
            // 
            txtpAbsent.BackColor = Color.Gainsboro;
            txtpAbsent.BorderStyle = BorderStyle.FixedSingle;
            txtpAbsent.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpAbsent.ForeColor = Color.Black;
            txtpAbsent.Location = new Point(690, 160);
            txtpAbsent.Name = "txtpAbsent";
            txtpAbsent.Size = new Size(250, 30);
            txtpAbsent.TabIndex = 6;
            // 
            // cmbBonus
            // 
            cmbBonus.BackColor = Color.Gainsboro;
            cmbBonus.FlatStyle = FlatStyle.Flat;
            cmbBonus.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBonus.ForeColor = Color.Black;
            cmbBonus.FormattingEnabled = true;
            cmbBonus.Items.AddRange(new object[] { "0", "2.50", "5", "7.50", "10", "12.50", "15" });
            cmbBonus.Location = new Point(166, 196);
            cmbBonus.Name = "cmbBonus";
            cmbBonus.Size = new Size(250, 29);
            cmbBonus.TabIndex = 7;
            // 
            // cmbDeduction
            // 
            cmbDeduction.BackColor = Color.Gainsboro;
            cmbDeduction.FlatStyle = FlatStyle.Flat;
            cmbDeduction.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDeduction.ForeColor = Color.Black;
            cmbDeduction.FormattingEnabled = true;
            cmbDeduction.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbDeduction.Location = new Point(690, 197);
            cmbDeduction.Name = "cmbDeduction";
            cmbDeduction.Size = new Size(250, 29);
            cmbDeduction.TabIndex = 8;
            // 
            // txtpSalary
            // 
            txtpSalary.BackColor = Color.Gainsboro;
            txtpSalary.BorderStyle = BorderStyle.FixedSingle;
            txtpSalary.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpSalary.ForeColor = Color.Black;
            txtpSalary.Location = new Point(690, 124);
            txtpSalary.Name = "txtpSalary";
            txtpSalary.Size = new Size(250, 30);
            txtpSalary.TabIndex = 4;
            // 
            // txtpPermission
            // 
            txtpPermission.BackColor = Color.Gainsboro;
            txtpPermission.BorderStyle = BorderStyle.FixedSingle;
            txtpPermission.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpPermission.ForeColor = Color.Black;
            txtpPermission.Location = new Point(166, 160);
            txtpPermission.Name = "txtpPermission";
            txtpPermission.Size = new Size(250, 30);
            txtpPermission.TabIndex = 5;
            // 
            // payrollview
            // 
            payrollview.BackgroundColor = Color.Gainsboro;
            payrollview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payrollview.Columns.AddRange(new DataGridViewColumn[] { EmpPayrollID, EmpPayrollName, Position, Salary, Permission, Absent, Bonus, Deduction, TotalAmount });
            payrollview.GridColor = Color.Black;
            payrollview.Location = new Point(19, 362);
            payrollview.Name = "payrollview";
            payrollview.RowHeadersWidth = 51;
            payrollview.Size = new Size(1020, 195);
            payrollview.TabIndex = 97;
            // 
            // EmpPayrollID
            // 
            EmpPayrollID.HeaderText = "EmpPayrollID";
            EmpPayrollID.MinimumWidth = 6;
            EmpPayrollID.Name = "EmpPayrollID";
            EmpPayrollID.Width = 125;
            // 
            // EmpPayrollName
            // 
            EmpPayrollName.HeaderText = "EmpPayrollName";
            EmpPayrollName.MinimumWidth = 6;
            EmpPayrollName.Name = "EmpPayrollName";
            EmpPayrollName.Width = 125;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "(none)";
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            Salary.Width = 125;
            // 
            // Permission
            // 
            Permission.HeaderText = "Permission";
            Permission.MinimumWidth = 6;
            Permission.Name = "Permission";
            Permission.Width = 125;
            // 
            // Absent
            // 
            Absent.HeaderText = "Absent";
            Absent.MinimumWidth = 6;
            Absent.Name = "Absent";
            Absent.Width = 125;
            // 
            // Bonus
            // 
            Bonus.HeaderText = "Bonus";
            Bonus.MinimumWidth = 6;
            Bonus.Name = "Bonus";
            Bonus.Width = 125;
            // 
            // Deduction
            // 
            Deduction.HeaderText = "Deduction";
            Deduction.MinimumWidth = 6;
            Deduction.Name = "Deduction";
            Deduction.Width = 125;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "TotalAmount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 125;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Blue;
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(422, 197);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(93, 29);
            btnCalculate.TabIndex = 98;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnCalculate1
            // 
            btnCalculate1.BackColor = Color.Blue;
            btnCalculate1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCalculate1.FlatStyle = FlatStyle.Flat;
            btnCalculate1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCalculate1.ForeColor = Color.White;
            btnCalculate1.Location = new Point(946, 197);
            btnCalculate1.Name = "btnCalculate1";
            btnCalculate1.Size = new Size(93, 29);
            btnCalculate1.TabIndex = 99;
            btnCalculate1.Text = "Calculate";
            btnCalculate1.UseVisualStyleBackColor = false;
            btnCalculate1.Click += btnCalculate1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(35, 240);
            label11.Name = "label11";
            label11.Size = new Size(124, 22);
            label11.TabIndex = 100;
            label11.Text = "Bonus Salary:";
            // 
            // txtBonusSalary
            // 
            txtBonusSalary.BackColor = Color.Gainsboro;
            txtBonusSalary.BorderStyle = BorderStyle.FixedSingle;
            txtBonusSalary.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBonusSalary.ForeColor = Color.Black;
            txtBonusSalary.Location = new Point(166, 232);
            txtBonusSalary.Name = "txtBonusSalary";
            txtBonusSalary.ReadOnly = true;
            txtBonusSalary.Size = new Size(250, 30);
            txtBonusSalary.TabIndex = 9;
            // 
            // txtDeductionSalary
            // 
            txtDeductionSalary.BackColor = Color.Gainsboro;
            txtDeductionSalary.BorderStyle = BorderStyle.FixedSingle;
            txtDeductionSalary.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeductionSalary.ForeColor = Color.Black;
            txtDeductionSalary.Location = new Point(690, 232);
            txtDeductionSalary.Name = "txtDeductionSalary";
            txtDeductionSalary.ReadOnly = true;
            txtDeductionSalary.Size = new Size(250, 30);
            txtDeductionSalary.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(519, 240);
            label12.Name = "label12";
            label12.Size = new Size(164, 22);
            label12.TabIndex = 102;
            label12.Text = "Deduction Salary:";
            // 
            // Payroll_and_Position_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1055, 579);
            Controls.Add(txtDeductionSalary);
            Controls.Add(label12);
            Controls.Add(txtBonusSalary);
            Controls.Add(label11);
            Controls.Add(btnCalculate1);
            Controls.Add(btnCalculate);
            Controls.Add(payrollview);
            Controls.Add(txtpPermission);
            Controls.Add(txtpSalary);
            Controls.Add(cmbDeduction);
            Controls.Add(cmbBonus);
            Controls.Add(txtpAbsent);
            Controls.Add(cmbPosition);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnpClear);
            Controls.Add(btnpFormClose);
            Controls.Add(btnpDelete);
            Controls.Add(btnpUpdate);
            Controls.Add(btnpSave);
            Controls.Add(txtpName);
            Controls.Add(txtTotal);
            Controls.Add(txtpID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payroll_and_Position_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll_and_Position_Form";
            Load += Payroll_and_Position_Form_Load;
            ((System.ComponentModel.ISupportInitialize)payrollview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPosition;
        private Label label10;
        private Label label9;
        private Button btnpClear;
        private Button btnpFormClose;
        private Button btnpDelete;
        private Button btnpUpdate;
        private Button btnpSave;
        private ComboBox cmbGender;
        private TextBox txtAddress;
        private TextBox txtpName;
        private TextBox txtTotal;
        private TextBox txtPANno;
        private TextBox txtMobile;
        private TextBox txtpID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private TextBox txtpAbsent;
        private ComboBox cmbBonus;
        private ComboBox cmbDeduction;
        private TextBox txtpSalary;
        private TextBox txtpPermission;
        private DataGridView payrollview;
        private Button btnCalculate;
        private Button btnCalculate1;
        private Label label11;
        private TextBox txtBonusSalary;
        private TextBox txtDeductionSalary;
        private Label label12;
        private DataGridViewTextBoxColumn EmpPayrollID;
        private DataGridViewTextBoxColumn EmpPayrollName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Permission;
        private DataGridViewTextBoxColumn Absent;
        private DataGridViewTextBoxColumn Bonus;
        private DataGridViewTextBoxColumn Deduction;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}