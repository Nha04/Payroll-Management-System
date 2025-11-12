namespace Payroll_MS
{
    partial class Employee_Register_Form
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtBankDetail = new TextBox();
            txtMobile = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            btnFormClose = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            EmpID = new DataGridViewTextBoxColumn();
            EmpName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            EmpMobile = new DataGridViewTextBoxColumn();
            EmpGender = new DataGridViewTextBoxColumn();
            EmpPANNo = new DataGridViewTextBoxColumn();
            EmpDob = new DataGridViewTextBoxColumn();
            EmpBankDetails = new DataGridViewTextBoxColumn();
            EmpAddress = new DataGridViewTextBoxColumn();
            EmpImageData = new DataGridViewTextBoxColumn();
            label9 = new Label();
            cmbPosition = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtPANno = new TextBox();
            DOBdate = new DateTimePicker();
            btnAdd = new Button();
            btnRemove = new Button();
            pb1 = new PictureBox();
            cmbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Blue;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(776, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(590, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(497, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.LightGray;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(756, 199);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 30);
            txtAddress.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightGray;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(756, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 30);
            txtName.TabIndex = 2;
            // 
            // txtBankDetail
            // 
            txtBankDetail.BackColor = Color.Gainsboro;
            txtBankDetail.BorderStyle = BorderStyle.FixedSingle;
            txtBankDetail.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBankDetail.ForeColor = Color.Black;
            txtBankDetail.Location = new Point(387, 238);
            txtBankDetail.Name = "txtBankDetail";
            txtBankDetail.Size = new Size(250, 30);
            txtBankDetail.TabIndex = 9;
            // 
            // txtMobile
            // 
            txtMobile.BackColor = Color.Gainsboro;
            txtMobile.BorderStyle = BorderStyle.FixedSingle;
            txtMobile.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobile.ForeColor = Color.Black;
            txtMobile.Location = new Point(387, 166);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(250, 30);
            txtMobile.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Gainsboro;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.Black;
            txtID.Location = new Point(387, 89);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 30);
            txtID.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(659, 205);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 38;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(662, 133);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 37;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(676, 97);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 36;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(255, 246);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 35;
            label4.Text = "Bank Details :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(295, 210);
            label3.Name = "label3";
            label3.Size = new Size(86, 22);
            label3.TabIndex = 34;
            label3.Text = "PAN No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(300, 97);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 32;
            label1.Text = "Emp ID :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 10);
            panel2.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 569);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1015, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 569);
            panel4.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 10);
            panel1.TabIndex = 28;
            // 
            // btnFormClose
            // 
            btnFormClose.BackColor = Color.FromArgb(192, 0, 0);
            btnFormClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.Location = new Point(967, 22);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(39, 29);
            btnFormClose.TabIndex = 16;
            btnFormClose.Text = "X";
            btnFormClose.UseVisualStyleBackColor = false;
            btnFormClose.Click += btnFormClose_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Blue;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(683, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmpID, EmpName, Position, EmpMobile, EmpGender, EmpPANNo, EmpDob, EmpBankDetails, EmpAddress, EmpImageData });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(33, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(973, 224);
            dataGridView1.TabIndex = 54;
            // 
            // EmpID
            // 
            EmpID.HeaderText = "EmpID";
            EmpID.MinimumWidth = 6;
            EmpID.Name = "EmpID";
            EmpID.Width = 125;
            // 
            // EmpName
            // 
            EmpName.HeaderText = "EmpName";
            EmpName.MinimumWidth = 6;
            EmpName.Name = "EmpName";
            EmpName.Width = 125;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // EmpMobile
            // 
            EmpMobile.HeaderText = "EmpMobile";
            EmpMobile.MinimumWidth = 6;
            EmpMobile.Name = "EmpMobile";
            EmpMobile.Width = 125;
            // 
            // EmpGender
            // 
            EmpGender.HeaderText = "EmpGender";
            EmpGender.MinimumWidth = 6;
            EmpGender.Name = "EmpGender";
            EmpGender.Width = 125;
            // 
            // EmpPANNo
            // 
            EmpPANNo.HeaderText = "EmpPANNo";
            EmpPANNo.MinimumWidth = 6;
            EmpPANNo.Name = "EmpPANNo";
            EmpPANNo.Width = 125;
            // 
            // EmpDob
            // 
            EmpDob.HeaderText = "EmpDob";
            EmpDob.MinimumWidth = 6;
            EmpDob.Name = "EmpDob";
            EmpDob.Width = 125;
            // 
            // EmpBankDetails
            // 
            EmpBankDetails.HeaderText = "EmpBankDetails";
            EmpBankDetails.MinimumWidth = 6;
            EmpBankDetails.Name = "EmpBankDetails";
            EmpBankDetails.Width = 125;
            // 
            // EmpAddress
            // 
            EmpAddress.HeaderText = "EmpAddress";
            EmpAddress.MinimumWidth = 6;
            EmpAddress.Name = "EmpAddress";
            EmpAddress.Width = 125;
            // 
            // EmpImageData
            // 
            EmpImageData.HeaderText = "EmpImageData";
            EmpImageData.MinimumWidth = 6;
            EmpImageData.Name = "EmpImageData";
            EmpImageData.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(387, 22);
            label9.Name = "label9";
            label9.Size = new Size(284, 38);
            label9.TabIndex = 57;
            label9.Text = "Employee Register";
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = Color.Gainsboro;
            cmbPosition.FlatStyle = FlatStyle.Flat;
            cmbPosition.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.ForeColor = Color.Black;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Project Manager", "Analyst/Tester", "Senior Programmer", "Junior Programmer", "IT Support" });
            cmbPosition.Location = new Point(387, 126);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(250, 29);
            cmbPosition.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(300, 133);
            label10.Name = "label10";
            label10.Size = new Size(81, 22);
            label10.TabIndex = 58;
            label10.Text = "Position:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(692, 169);
            label8.Name = "label8";
            label8.Size = new Size(58, 22);
            label8.TabIndex = 39;
            label8.Text = "DOB :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(301, 174);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 33;
            label2.Text = "Mobile :";
            // 
            // txtPANno
            // 
            txtPANno.BackColor = Color.Gainsboro;
            txtPANno.BorderStyle = BorderStyle.FixedSingle;
            txtPANno.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPANno.ForeColor = Color.Black;
            txtPANno.Location = new Point(387, 202);
            txtPANno.Name = "txtPANno";
            txtPANno.Size = new Size(250, 30);
            txtPANno.TabIndex = 7;
            // 
            // DOBdate
            // 
            DOBdate.CalendarFont = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBdate.Format = DateTimePickerFormat.Short;
            DOBdate.Location = new Point(756, 166);
            DOBdate.Name = "DOBdate";
            DOBdate.Size = new Size(250, 27);
            DOBdate.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(38, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Blue;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(131, 298);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 29);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // pb1
            // 
            pb1.BackColor = Color.Gainsboro;
            pb1.Location = new Point(33, 33);
            pb1.Name = "pb1";
            pb1.Size = new Size(200, 229);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 40;
            pb1.TabStop = false;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.LightGray;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            cmbGender.Location = new Point(756, 126);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(250, 29);
            cmbGender.TabIndex = 4;
            // 
            // Employee_Register_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1025, 579);
            Controls.Add(cmbPosition);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnClear);
            Controls.Add(btnFormClose);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(DOBdate);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtBankDetail);
            Controls.Add(txtPANno);
            Controls.Add(txtMobile);
            Controls.Add(txtID);
            Controls.Add(pb1);
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
            Name = "Employee_Register_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee_Register_Form";
            Load += Employee_Register_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtBankDetail;
        private TextBox txtMobile;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Button btnFormClose;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Label label9;
        private ComboBox cmbPosition;
        private Label label10;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn EmpMobile;
        private DataGridViewTextBoxColumn EmpGender;
        private DataGridViewTextBoxColumn EmpPANNo;
        private DataGridViewTextBoxColumn EmpDob;
        private DataGridViewTextBoxColumn EmpBankDetails;
        private DataGridViewTextBoxColumn EmpAddress;
        private DataGridViewTextBoxColumn EmpImageData;
        private Label label8;
        private Label label2;
        private TextBox txtPANno;
        private DateTimePicker DOBdate;
        private Button btnAdd;
        private Button btnRemove;
        private PictureBox pb1;
        private ComboBox cmbGender;
    }
}