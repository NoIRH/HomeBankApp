namespace HomeBankApp
{
    partial class RegistrationForm1
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
            Authorization_label = new Label();
            button1 = new Button();
            PasswordText = new TextBox();
            LoginText = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Authorization_label
            // 
            Authorization_label.AutoSize = true;
            Authorization_label.Cursor = Cursors.Hand;
            Authorization_label.Location = new Point(174, 404);
            Authorization_label.Name = "Authorization_label";
            Authorization_label.Size = new Size(121, 20);
            Authorization_label.TabIndex = 6;
            Authorization_label.Text = "Авторизоваться";
            Authorization_label.MouseClick += Authorization_label_MouseClick;
            Authorization_label.MouseEnter += Authorization_label_MouseEnter;
            Authorization_label.MouseLeave += Authorization_label_MouseLeave;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(121, 354);
            button1.Name = "button1";
            button1.Size = new Size(212, 47);
            button1.TabIndex = 5;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(94, 270);
            PasswordText.Multiline = true;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(268, 36);
            PasswordText.TabIndex = 4;
            // 
            // LoginText
            // 
            LoginText.Location = new Point(94, 175);
            LoginText.Multiline = true;
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(268, 36);
            LoginText.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pass;
            pictureBox2.Location = new Point(24, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(24, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(Authorization_label);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PasswordText);
            panel1.Controls.Add(LoginText);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 446);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 104);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(413, 81);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // RegistrationForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 446);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm1";
            Text = "RegistrationForm1";
            Load += RegistrationForm1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Authorization_label;
        private Button button1;
        private TextBox PasswordText;
        private TextBox LoginText;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}