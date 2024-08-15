namespace LAMS_1
{
    partial class CreateAccount
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtconfirmpassword = new TextBox();
            BtnRegister = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 0;
            label1.Text = "SIGNUP ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 235);
            label5.Name = "label5";
            label5.Size = new Size(76, 40);
            label5.TabIndex = 4;
            label5.Text = "Confirm\r\nPassword";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(114, 104);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(166, 23);
            txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(114, 174);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(166, 23);
            txtpassword.TabIndex = 2;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(114, 252);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(166, 23);
            txtconfirmpassword.TabIndex = 4;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = Color.DodgerBlue;
            BtnRegister.FlatStyle = FlatStyle.Popup;
            BtnRegister.ForeColor = Color.Black;
            BtnRegister.Location = new Point(73, 328);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(173, 49);
            BtnRegister.TabIndex = 5;
            BtnRegister.Text = "CREATE ACCOUNT";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += btnCreateAccount_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DodgerBlue;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(73, 396);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(173, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(304, 486);
            Controls.Add(btnBack);
            Controls.Add(BtnRegister);
            Controls.Add(txtconfirmpassword);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtconfirmpassword;
        private Button BtnRegister;
        private Button btnBack;
    }
}