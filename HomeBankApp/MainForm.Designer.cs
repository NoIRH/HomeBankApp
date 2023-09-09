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
            Enter = new TextBox();
            Capital = new TextBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            OperationsToolStripMenuItem = new ToolStripMenuItem();
            StatisticsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Introduction
            // 
            Introduction.Location = new Point(10, 56);
            Introduction.Margin = new Padding(3, 2, 3, 2);
            Introduction.Name = "Introduction";
            Introduction.Size = new Size(117, 38);
            Introduction.TabIndex = 0;
            Introduction.Text = "Добавить";
            Introduction.UseVisualStyleBackColor = true;
            // 
            // Wastes
            // 
            Wastes.Location = new Point(133, 56);
            Wastes.Margin = new Padding(3, 2, 3, 2);
            Wastes.Name = "Wastes";
            Wastes.Size = new Size(117, 38);
            Wastes.TabIndex = 1;
            Wastes.Text = "Потратить";
            Wastes.UseVisualStyleBackColor = true;
            // 
            // Operations
            // 
            Operations.FormattingEnabled = true;
            Operations.ItemHeight = 15;
            Operations.Location = new Point(-1, 104);
            Operations.Margin = new Padding(3, 2, 3, 2);
            Operations.Name = "Operations";
            Operations.Size = new Size(746, 274);
            Operations.TabIndex = 2;
            // 
            // Enter
            // 
            Enter.Location = new Point(333, 64);
            Enter.Margin = new Padding(3, 2, 3, 2);
            Enter.Name = "Enter";
            Enter.Size = new Size(123, 23);
            Enter.TabIndex = 3;
            // 
            // Capital
            // 
            Capital.Location = new Point(609, 64);
            Capital.Margin = new Padding(3, 2, 3, 2);
            Capital.Name = "Capital";
            Capital.Size = new Size(123, 23);
            Capital.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 5;
            label1.Text = "Общая сумма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 34);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 6;
            label2.Text = "Внесение суммы";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 255, 128);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { OperationsToolStripMenuItem, StatisticsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(744, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // OperationsToolStripMenuItem
            // 
            OperationsToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            OperationsToolStripMenuItem.Size = new Size(75, 20);
            OperationsToolStripMenuItem.Text = "Операции";
            // 
            // StatisticsToolStripMenuItem
            // 
            StatisticsToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem";
            StatisticsToolStripMenuItem.Size = new Size(80, 20);
            StatisticsToolStripMenuItem.Text = "Статистика";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(744, 377);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Capital);
            Controls.Add(Enter);
            Controls.Add(Operations);
            Controls.Add(Wastes);
            Controls.Add(Introduction);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Introduction;
        private Button Wastes;
        private ListBox Operations;
        private TextBox Enter;
        private TextBox Capital;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem OperationsToolStripMenuItem;
        private ToolStripMenuItem StatisticsToolStripMenuItem;
    }
}