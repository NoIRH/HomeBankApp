namespace HomeBankApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Introduction = new Button();
            Wastes = new Button();
            Operations = new ListBox();
            Capital = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Introduction
            // 
            Introduction.Dock = DockStyle.Left;
            Introduction.Location = new Point(184, 0);
            Introduction.Margin = new Padding(5, 3, 5, 3);
            Introduction.Name = "Introduction";
            Introduction.Size = new Size(184, 111);
            Introduction.TabIndex = 0;
            Introduction.Text = "Добавить";
            Introduction.UseVisualStyleBackColor = true;
            // 
            // Wastes
            // 
            Wastes.Dock = DockStyle.Left;
            Wastes.Location = new Point(0, 0);
            Wastes.Margin = new Padding(5, 3, 5, 3);
            Wastes.Name = "Wastes";
            Wastes.Size = new Size(184, 111);
            Wastes.TabIndex = 1;
            Wastes.Text = "Потратить";
            Wastes.UseVisualStyleBackColor = true;
            // 
            // Operations
            // 
            Operations.Dock = DockStyle.Fill;
            Operations.FormattingEnabled = true;
            Operations.ItemHeight = 25;
            Operations.Location = new Point(5, 5);
            Operations.Margin = new Padding(5, 3, 5, 3);
            Operations.Name = "Operations";
            Operations.Size = new Size(1031, 572);
            Operations.TabIndex = 2;
            // 
            // Capital
            // 
            Capital.Location = new Point(723, 46);
            Capital.Margin = new Padding(5, 3, 5, 3);
            Capital.Name = "Capital";
            Capital.Size = new Size(191, 33);
            Capital.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(759, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 5;
            label1.Text = "Общая сумма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 15);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 6;
            label2.Text = "Внесение суммы";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(240, 38);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 29);
            numericUpDown1.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1049, 620);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(Operations);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1041, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(Introduction);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Wastes);
            panel1.Controls.Add(Capital);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 111);
            panel1.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1016, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1049, 620);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Introduction;
        private Button Wastes;
        private ListBox Operations;
        private TextBox Capital;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
    }
}