namespace Payroll_MS
{
    partial class Login_Form
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
            btnFormClose = new Button();
            label4 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFormClose
            // 
            btnFormClose.BackColor = Color.FromArgb(192, 0, 0);
            btnFormClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFormClose.Location = new Point(321, 12);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(39, 29);
            btnFormClose.TabIndex = 0;
            btnFormClose.Text = "X";
            btnFormClose.UseVisualStyleBackColor = false;
            btnFormClose.Click += btnFormClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(67, 50);
            label4.Name = "label4";
            label4.Size = new Size(241, 56);
            label4.TabIndex = 6;
            label4.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(9, 103);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Gainsboro;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(127, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(194, 30);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(127, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(194, 30);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(118, 23);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Blue;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(9, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(312, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(9, 157);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(20, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 284);
            panel1.TabIndex = 1;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(372, 465);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnFormClose);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormClose;
        private Label label4;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Label label2;
        private Panel panel1;
    }
}