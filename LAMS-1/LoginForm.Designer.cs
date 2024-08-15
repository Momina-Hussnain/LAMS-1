namespace LAMS_1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            BtnLogin = new Button();
            button2 = new Button();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.DarkOliveGreen;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.White;
            txtusername.Location = new Point(93, 193);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(183, 20);
            txtusername.TabIndex = 2;
            txtusername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.DarkOliveGreen;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.White;
            txtpassword.Location = new Point(93, 262);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(183, 20);
            txtpassword.TabIndex = 3;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 191);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 262);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(93, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 4);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(93, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 4);
            panel2.TabIndex = 7;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Cyan;
            BtnLogin.FlatStyle = FlatStyle.Popup;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(35, 342);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(241, 32);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(35, 380);
            button2.Name = "button2";
            button2.Size = new Size(241, 35);
            button2.TabIndex = 9;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.FromArgb(192, 255, 255);
            btnclose.FlatStyle = FlatStyle.Popup;
            btnclose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = Color.Red;
            btnclose.Location = new Point(297, -1);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(23, 23);
            btnclose.TabIndex = 10;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(320, 525);
            Controls.Add(btnclose);
            Controls.Add(button2);
            Controls.Add(BtnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Button BtnLogin;
        private Button button2;
        private Button btnclose;
    }
}