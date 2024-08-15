namespace LAMS_1
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            Datetimepicker = new DateTimePicker();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(311, 22);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 1;
            label1.Text = "Add Books";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(225, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(Datetimepicker);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(267, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 348);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(227, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Wheat;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(107, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Datetimepicker
            // 
            Datetimepicker.Location = new Point(180, 151);
            Datetimepicker.Name = "Datetimepicker";
            Datetimepicker.Size = new Size(200, 23);
            Datetimepicker.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(180, 245);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 201);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(180, 100);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(200, 23);
            txtPublication.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(180, 54);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(180, 19);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(200, 23);
            txtBookName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 253);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 209);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 157);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 3;
            label5.Text = "Book Publication Date";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 108);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 62);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 22);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private DateTimePicker Datetimepicker;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
    }
}