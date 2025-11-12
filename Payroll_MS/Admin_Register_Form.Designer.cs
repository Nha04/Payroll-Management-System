namespace Payroll_MS
{
    partial class Admin_Register_Form
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
            label10 = new Label();
            label9 = new Label();
            viewAdmin = new DataGridView();
            AdminID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            btnadClear = new Button();
            btnFormClose = new Button();
            btnadDelete = new Button();
            btnadUpdate = new Button();
            btnadSave = new Button();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            txtadEmail = new TextBox();
            txtadPhone = new TextBox();
            txtadUsername = new TextBox();
            txtadID = new TextBox();
            txtadPassword = new TextBox();
            cmbRole = new ComboBox();
            adminDOB = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)viewAdmin).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(433, 177);
            label10.Name = "label10";
            label10.Size = new Size(58, 22);
            label10.TabIndex = 90;
            label10.Text = "Role :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(287, 31);
            label9.Name = "label9";
            label9.Size = new Size(234, 38);
            label9.TabIndex = 89;
            label9.Text = "Admin Register";
            // 
            // viewAdmin
            // 
            viewAdmin.BackgroundColor = Color.Gainsboro;
            viewAdmin.BorderStyle = BorderStyle.None;
            viewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAdmin.Columns.AddRange(new DataGridViewColumn[] { AdminID, Username, Password, Email, DOB, Phone, Role });
            viewAdmin.GridColor = Color.Black;
            viewAdmin.Location = new Point(33, 290);
            viewAdmin.Name = "viewAdmin";
            viewAdmin.RowHeadersWidth = 51;
            viewAdmin.Size = new Size(714, 197);
            viewAdmin.TabIndex = 86;
            // 
            // AdminID
            // 
            AdminID.HeaderText = "AdminID";
            AdminID.MinimumWidth = 6;
            AdminID.Name = "AdminID";
            AdminID.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 125;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // DOB
            // 
            DOB.HeaderText = "DOB";
            DOB.MinimumWidth = 6;
            DOB.Name = "DOB";
            DOB.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // btnadClear
            // 
            btnadClear.BackColor = Color.Blue;
            btnadClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnadClear.FlatStyle = FlatStyle.Flat;
            btnadClear.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnadClear.ForeColor = Color.White;
            btnadClear.Location = new Point(419, 255);
            btnadClear.Name = "btnadClear";
            btnadClear.Size = new Size(87, 29);
            btnadClear.TabIndex = 10;
            btnadClear.Text = "Clear";
            btnadClear.UseVisualStyleBackColor = false;
            btnadClear.Click += btnadClear_Click;
            // 
            // btnFormClose
            // 
            btnFormClose.BackColor = Color.FromArgb(192, 0, 0);
            btnFormClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.Location = new Point(722, 16);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(39, 29);
            btnFormClose.TabIndex = 12;
            btnFormClose.Text = "X";
            btnFormClose.UseVisualStyleBackColor = false;
            btnFormClose.Click += btnFormClose_Click;
            // 
            // btnadDelete
            // 
            btnadDelete.BackColor = Color.Blue;
            btnadDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnadDelete.FlatStyle = FlatStyle.Flat;
            btnadDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnadDelete.ForeColor = Color.White;
            btnadDelete.Location = new Point(512, 255);
            btnadDelete.Name = "btnadDelete";
            btnadDelete.Size = new Size(87, 29);
            btnadDelete.TabIndex = 11;
            btnadDelete.Text = "Delete";
            btnadDelete.UseVisualStyleBackColor = false;
            btnadDelete.Click += btnadDelete_Click;
            // 
            // btnadUpdate
            // 
            btnadUpdate.BackColor = Color.Blue;
            btnadUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnadUpdate.FlatStyle = FlatStyle.Flat;
            btnadUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnadUpdate.ForeColor = Color.White;
            btnadUpdate.Location = new Point(326, 255);
            btnadUpdate.Name = "btnadUpdate";
            btnadUpdate.Size = new Size(87, 29);
            btnadUpdate.TabIndex = 9;
            btnadUpdate.Text = "Update";
            btnadUpdate.UseVisualStyleBackColor = false;
            btnadUpdate.Click += btnadUpdate_Click;
            // 
            // btnadSave
            // 
            btnadSave.BackColor = Color.Blue;
            btnadSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnadSave.FlatStyle = FlatStyle.Flat;
            btnadSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnadSave.ForeColor = Color.White;
            btnadSave.Location = new Point(233, 255);
            btnadSave.Name = "btnadSave";
            btnadSave.Size = new Size(87, 29);
            btnadSave.TabIndex = 8;
            btnadSave.Text = "Save";
            btnadSave.UseVisualStyleBackColor = false;
            btnadSave.Click += btnadSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(64, 213);
            label8.Name = "label8";
            label8.Size = new Size(66, 22);
            label8.TabIndex = 71;
            label8.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(20, 142);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 68;
            label5.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(415, 141);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 66;
            label3.Text = "Phone :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(28, 177);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 65;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(30, 105);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 64;
            label1.Text = "Admin ID :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 10);
            panel2.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 501);
            panel3.TabIndex = 61;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(767, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 501);
            panel4.TabIndex = 63;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 10);
            panel1.TabIndex = 60;
            // 
            // txtadEmail
            // 
            txtadEmail.BackColor = Color.LightGray;
            txtadEmail.BorderStyle = BorderStyle.FixedSingle;
            txtadEmail.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadEmail.ForeColor = Color.Black;
            txtadEmail.Location = new Point(136, 205);
            txtadEmail.Name = "txtadEmail";
            txtadEmail.Size = new Size(250, 30);
            txtadEmail.TabIndex = 4;
            // 
            // txtadPhone
            // 
            txtadPhone.BackColor = Color.LightGray;
            txtadPhone.BorderStyle = BorderStyle.FixedSingle;
            txtadPhone.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadPhone.ForeColor = Color.Black;
            txtadPhone.Location = new Point(497, 133);
            txtadPhone.Name = "txtadPhone";
            txtadPhone.Size = new Size(250, 30);
            txtadPhone.TabIndex = 6;
            // 
            // txtadUsername
            // 
            txtadUsername.BackColor = Color.LightGray;
            txtadUsername.BorderStyle = BorderStyle.FixedSingle;
            txtadUsername.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadUsername.ForeColor = Color.Black;
            txtadUsername.Location = new Point(136, 133);
            txtadUsername.Name = "txtadUsername";
            txtadUsername.Size = new Size(250, 30);
            txtadUsername.TabIndex = 2;
            // 
            // txtadID
            // 
            txtadID.BackColor = Color.LightGray;
            txtadID.BorderStyle = BorderStyle.FixedSingle;
            txtadID.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadID.ForeColor = Color.Black;
            txtadID.Location = new Point(136, 97);
            txtadID.Name = "txtadID";
            txtadID.Size = new Size(250, 30);
            txtadID.TabIndex = 1;
            txtadID.TextChanged += txtadID_TextChanged;
            // 
            // txtadPassword
            // 
            txtadPassword.BackColor = Color.LightGray;
            txtadPassword.BorderStyle = BorderStyle.FixedSingle;
            txtadPassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadPassword.ForeColor = Color.Black;
            txtadPassword.Location = new Point(136, 169);
            txtadPassword.Name = "txtadPassword";
            txtadPassword.Size = new Size(250, 30);
            txtadPassword.TabIndex = 3;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.Gainsboro;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Manager", "Finance", "Human Resource" });
            cmbRole.Location = new Point(497, 169);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(250, 28);
            cmbRole.TabIndex = 7;
            // 
            // adminDOB
            // 
            adminDOB.CalendarMonthBackground = Color.Gainsboro;
            adminDOB.Format = DateTimePickerFormat.Short;
            adminDOB.Location = new Point(497, 100);
            adminDOB.Name = "adminDOB";
            adminDOB.Size = new Size(250, 27);
            adminDOB.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(433, 105);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 99;
            label4.Text = "DOB :";
            // 
            // Admin_Register_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(777, 511);
            Controls.Add(label4);
            Controls.Add(adminDOB);
            Controls.Add(cmbRole);
            Controls.Add(txtadPassword);
            Controls.Add(txtadID);
            Controls.Add(txtadUsername);
            Controls.Add(txtadPhone);
            Controls.Add(txtadEmail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(viewAdmin);
            Controls.Add(btnadClear);
            Controls.Add(btnFormClose);
            Controls.Add(btnadDelete);
            Controls.Add(btnadUpdate);
            Controls.Add(btnadSave);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Register_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Register_Form";
            Load += Admin_Register_Form_Load;
            ((System.ComponentModel.ISupportInitialize)viewAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPosition;
        private Label label10;
        private Label label9;
        private DataGridView viewAdmin;
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
        private Button btnadClear;
        private Button btnFormClose;
        private Button btnadDelete;
        private Button btnadUpdate;
        private Button btnadSave;
        private TextBox txtName;
        private TextBox txtPANno;
        private TextBox txtMobile;
        private TextBox txtID;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private TextBox txtadEmail;
        private TextBox txtadPhone;
        private TextBox txtadUsername;
        private TextBox txtadID;
        private TextBox txtadPassword;
        private ComboBox cmbRole;
        private DataGridViewTextBoxColumn AdminID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Role;
        private DateTimePicker adminDOB;
        private Label label4;
    }
}