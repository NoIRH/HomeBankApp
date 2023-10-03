namespace HomeBankApp
{
    partial class RegistrationForm
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
            panel1 = new Panel();
            password = new TextBox();
            login = new TextBox();
            authorization = new Label();
            buttonRedistration = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(password);
            panel1.Controls.Add(login);
            panel1.Controls.Add(authorization);
            panel1.Controls.Add(buttonRedistration);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 361);
            panel1.TabIndex = 0;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(157, 190);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(200, 33);
            password.TabIndex = 8;
            password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(157, 124);
            login.Name = "login";
            login.Size = new Size(200, 33);
            login.TabIndex = 7;
            // 
            // authorization
            // 
            authorization.AutoSize = true;
            authorization.Cursor = Cursors.Hand;
            authorization.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            authorization.Location = new Point(198, 332);
            authorization.Name = "authorization";
            authorization.Size = new Size(121, 20);
            authorization.TabIndex = 6;
            authorization.Text = "Авторизоваться";
            authorization.MouseClick += authorization_MouseClick;
            authorization.MouseEnter += authorization_MouseEnter;
            authorization.MouseLeave += authorization_MouseLeave;
            // 
            // buttonRedistration
            // 
            buttonRedistration.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRedistration.Location = new Point(157, 253);
            buttonRedistration.Margin = new Padding(3, 2, 3, 2);
            buttonRedistration.Name = "buttonRedistration";
            buttonRedistration.Size = new Size(200, 35);
            buttonRedistration.TabIndex = 5;
            buttonRedistration.Text = "Зарегистрироваться";
            buttonRedistration.UseVisualStyleBackColor = true;
            buttonRedistration.Click += buttonRedistration_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pass;
            pictureBox2.Location = new Point(69, 179);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(69, 113);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 97);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 23);
            label1.Name = "label1";
            label1.Size = new Size(257, 57);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 361);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button buttonRedistration;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label authorization;
        private TextBox password;
        private TextBox login;
    }
}