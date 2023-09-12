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
            buttonAddMoney = new Button();
            buttonRemoveMoney = new Button();
            operationsField = new ListBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            inputField = new NumericUpDown();
            depositField = new NumericUpDown();
            tabPage2 = new TabPage();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depositField).BeginInit();
            SuspendLayout();
            // 
            // buttonAddMoney
            // 
            buttonAddMoney.Dock = DockStyle.Left;
            buttonAddMoney.Location = new Point(184, 0);
            buttonAddMoney.Margin = new Padding(5, 3, 5, 3);
            buttonAddMoney.Name = "buttonAddMoney";
            buttonAddMoney.Size = new Size(184, 111);
            buttonAddMoney.TabIndex = 0;
            buttonAddMoney.Text = "Добавить";
            buttonAddMoney.UseVisualStyleBackColor = true;
            buttonAddMoney.Click += buttonAddMoney_Click;
            // 
            // buttonRemoveMoney
            // 
            buttonRemoveMoney.Dock = DockStyle.Left;
            buttonRemoveMoney.Location = new Point(0, 0);
            buttonRemoveMoney.Margin = new Padding(5, 3, 5, 3);
            buttonRemoveMoney.Name = "buttonRemoveMoney";
            buttonRemoveMoney.Size = new Size(184, 111);
            buttonRemoveMoney.TabIndex = 1;
            buttonRemoveMoney.Text = "Потратить";
            buttonRemoveMoney.UseVisualStyleBackColor = true;
            buttonRemoveMoney.Click += buttonRemoveMoney_Click;
            // 
            // operationsField
            // 
            operationsField.Dock = DockStyle.Fill;
            operationsField.FormattingEnabled = true;
            operationsField.ItemHeight = 32;
            operationsField.Location = new Point(5, 5);
            operationsField.Margin = new Padding(5, 3, 5, 3);
            operationsField.Name = "operationsField";
            operationsField.Size = new Size(1031, 402);
            operationsField.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(800, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 5;
            label1.Text = "Общая сумма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 15);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 6;
            label2.Text = "Внесение суммы";
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
            tabControl1.Size = new Size(1049, 457);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(operationsField);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1041, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Операции";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(inputField);
            panel1.Controls.Add(depositField);
            panel1.Controls.Add(buttonAddMoney);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonRemoveMoney);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 111);
            panel1.TabIndex = 9;
            // 
            // inputField
            // 
            inputField.DecimalPlaces = 2;
            inputField.Location = new Point(437, 51);
            inputField.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            inputField.Minimum = new decimal(new int[] { -1294967296, 0, 0, int.MinValue });
            inputField.Name = "inputField";
            inputField.Size = new Size(201, 39);
            inputField.TabIndex = 11;
            // 
            // depositField
            // 
            depositField.DecimalPlaces = 2;
            depositField.Location = new Point(800, 51);
            depositField.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            depositField.Minimum = new decimal(new int[] { -1294967296, 0, 0, int.MinValue });
            depositField.Name = "depositField";
            depositField.Size = new Size(166, 39);
            depositField.TabIndex = 10;
            //depositField.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1041, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Статистика";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1049, 457);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputField).EndInit();
            ((System.ComponentModel.ISupportInitialize)depositField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddMoney;
        private Button buttonRemoveMoney;
        private ListBox operationsField;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private NumericUpDown depositField;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private NumericUpDown inputField;
    }
}