namespace Payroll_MS
{
    partial class View_Emplyee_Form
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
            label9 = new Label();
            btnFormClose = new Button();
            btnView = new Button();
            txtempID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            lblBankDetails = new Label();
            lblPANNo = new Label();
            lblMobile = new Label();
            lblid = new Label();
            lblAddress = new Label();
            lblDOB = new Label();
            lblGender = new Label();
            lblName = new Label();
            btnClear = new Button();
            lblPosition = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(317, 31);
            label9.Name = "label9";
            label9.Size = new Size(241, 38);
            label9.TabIndex = 87;
            label9.Text = "View Employee";
            // 
            // btnFormClose
            // 
            btnFormClose.BackColor = Color.FromArgb(192, 0, 0);
            btnFormClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.Location = new Point(852, 16);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(39, 29);
            btnFormClose.TabIndex = 4;
            btnFormClose.Text = "X";
            btnFormClose.UseVisualStyleBackColor = false;
            btnFormClose.Click += btnFormClose_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Blue;
            btnView.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(614, 115);
            btnView.Name = "btnView";
            btnView.Size = new Size(87, 29);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // txtempID
            // 
            txtempID.BackColor = Color.Gainsboro;
            txtempID.BorderStyle = BorderStyle.FixedSingle;
            txtempID.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtempID.ForeColor = Color.Black;
            txtempID.Location = new Point(333, 115);
            txtempID.Name = "txtempID";
            txtempID.Size = new Size(250, 30);
            txtempID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(207, 116);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 62;
            label1.Text = "Emp ID :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 10);
            panel2.TabIndex = 60;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 569);
            panel3.TabIndex = 59;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(899, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 569);
            panel4.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 10);
            panel1.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(535, 314);
            label8.Name = "label8";
            label8.Size = new Size(73, 29);
            label8.TabIndex = 95;
            label8.Text = "DOB :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(494, 376);
            label7.Name = "label7";
            label7.Size = new Size(114, 29);
            label7.TabIndex = 94;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(498, 258);
            label6.Name = "label6";
            label6.Size = new Size(110, 29);
            label6.TabIndex = 93;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(514, 202);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 92;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(48, 437);
            label4.Name = "label4";
            label4.Size = new Size(161, 29);
            label4.TabIndex = 91;
            label4.Text = "Bank Details :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(99, 376);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 90;
            label3.Text = "PAN No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(106, 258);
            label2.Name = "label2";
            label2.Size = new Size(103, 29);
            label2.TabIndex = 89;
            label2.Text = "Mobile :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(107, 202);
            label10.Name = "label10";
            label10.Size = new Size(102, 29);
            label10.TabIndex = 88;
            label10.Text = "Emp ID :";
            // 
            // lblBankDetails
            // 
            lblBankDetails.AutoSize = true;
            lblBankDetails.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblBankDetails.ForeColor = Color.Black;
            lblBankDetails.Location = new Point(215, 437);
            lblBankDetails.Name = "lblBankDetails";
            lblBankDetails.Size = new Size(217, 29);
            lblBankDetails.TabIndex = 99;
            lblBankDetails.Text = "_________________";
            // 
            // lblPANNo
            // 
            lblPANNo.AutoSize = true;
            lblPANNo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblPANNo.ForeColor = Color.Black;
            lblPANNo.Location = new Point(215, 381);
            lblPANNo.Name = "lblPANNo";
            lblPANNo.Size = new Size(217, 29);
            lblPANNo.TabIndex = 98;
            lblPANNo.Text = "_________________";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblMobile.ForeColor = Color.Black;
            lblMobile.Location = new Point(215, 264);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(217, 29);
            lblMobile.TabIndex = 97;
            lblMobile.Text = "_________________";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblid.ForeColor = Color.Black;
            lblid.Location = new Point(215, 208);
            lblid.Name = "lblid";
            lblid.Size = new Size(217, 29);
            lblid.TabIndex = 96;
            lblid.Text = "_________________";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(614, 376);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(217, 29);
            lblAddress.TabIndex = 103;
            lblAddress.Text = "_________________";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblDOB.ForeColor = Color.Black;
            lblDOB.Location = new Point(614, 319);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(217, 29);
            lblDOB.TabIndex = 102;
            lblDOB.Text = "_________________";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(614, 263);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(217, 29);
            lblGender.TabIndex = 101;
            lblGender.Text = "_________________";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(614, 208);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 29);
            lblName.TabIndex = 100;
            lblName.Text = "_________________";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Blue;
            btnClear.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(716, 116);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button1_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblPosition.ForeColor = Color.Black;
            lblPosition.Location = new Point(215, 324);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(217, 29);
            lblPosition.TabIndex = 106;
            lblPosition.Text = "_________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(104, 319);
            label12.Name = "label12";
            label12.Size = new Size(105, 29);
            label12.TabIndex = 105;
            label12.Text = "Position:";
            // 
            // View_Emplyee_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(909, 579);
            Controls.Add(lblPosition);
            Controls.Add(label12);
            Controls.Add(btnClear);
            Controls.Add(lblAddress);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(lblBankDetails);
            Controls.Add(lblPANNo);
            Controls.Add(lblMobile);
            Controls.Add(lblid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnFormClose);
            Controls.Add(btnView);
            Controls.Add(txtempID);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Emplyee_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Emplyee_Form";
            Load += View_Emplyee_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Button btnFormClose;
        private Button btnView;
        private TextBox txtempID;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label lblBankDetails;
        private Label lblPANNo;
        private Label lblMobile;
        private Label lblid;
        private Label lblAddress;
        private Label lblDOB;
        private Label lblGender;
        private Label lblName;
        private Button btnClear;
        private Label lblPosition;
        private Label label12;
    }
}