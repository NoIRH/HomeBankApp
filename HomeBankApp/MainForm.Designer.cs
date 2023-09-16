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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewOpeartions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBoxTotalSum = new GroupBox();
            outPutFirld = new TextBox();
            groupBoxInput = new GroupBox();
            inputField = new NumericUpDown();
            groupBoxOperation = new GroupBox();
            buttonRemoveMoney = new Button();
            buttonAddMoney = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonYearStatistic = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpeartions).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxTotalSum.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputField).BeginInit();
            groupBoxOperation.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOpeartions
            // 
            dataGridViewOpeartions.AllowUserToDeleteRows = false;
            dataGridViewOpeartions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOpeartions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewOpeartions.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOpeartions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOpeartions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOpeartions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOpeartions.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOpeartions.Dock = DockStyle.Fill;
            dataGridViewOpeartions.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewOpeartions.Location = new Point(3, 101);
            dataGridViewOpeartions.Name = "dataGridViewOpeartions";
            dataGridViewOpeartions.RowHeadersVisible = false;
            dataGridViewOpeartions.RowHeadersWidth = 51;
            dataGridViewOpeartions.RowTemplate.Height = 29;
            dataGridViewOpeartions.Size = new Size(867, 389);
            dataGridViewOpeartions.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Операция";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Дата";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(888, 542);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(880, 501);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Счёт";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridViewOpeartions, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(872, 493);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTotalSum);
            panel1.Controls.Add(groupBoxInput);
            panel1.Controls.Add(groupBoxOperation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 92);
            panel1.TabIndex = 1;
            // 
            // groupBoxTotalSum
            // 
            groupBoxTotalSum.Controls.Add(outPutFirld);
            groupBoxTotalSum.Dock = DockStyle.Right;
            groupBoxTotalSum.Location = new Point(563, 0);
            groupBoxTotalSum.Name = "groupBoxTotalSum";
            groupBoxTotalSum.Size = new Size(304, 92);
            groupBoxTotalSum.TabIndex = 4;
            groupBoxTotalSum.TabStop = false;
            groupBoxTotalSum.Text = "Общая сумма за месяц";
            // 
            // outPutFirld
            // 
            outPutFirld.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outPutFirld.Enabled = false;
            outPutFirld.Location = new Point(6, 40);
            outPutFirld.Name = "outPutFirld";
            outPutFirld.Size = new Size(287, 34);
            outPutFirld.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(inputField);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(268, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(599, 92);
            groupBoxInput.TabIndex = 3;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Операции";
            // 
            // inputField
            // 
            inputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputField.DecimalPlaces = 2;
            inputField.Location = new Point(6, 41);
            inputField.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            inputField.Name = "inputField";
            inputField.Size = new Size(256, 34);
            inputField.TabIndex = 0;
            // 
            // groupBoxOperation
            // 
            groupBoxOperation.Controls.Add(buttonRemoveMoney);
            groupBoxOperation.Controls.Add(buttonAddMoney);
            groupBoxOperation.Dock = DockStyle.Left;
            groupBoxOperation.Location = new Point(0, 0);
            groupBoxOperation.Name = "groupBoxOperation";
            groupBoxOperation.Size = new Size(268, 92);
            groupBoxOperation.TabIndex = 2;
            groupBoxOperation.TabStop = false;
            groupBoxOperation.Text = "Операции";
            // 
            // buttonRemoveMoney
            // 
            buttonRemoveMoney.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemoveMoney.Location = new Point(127, 33);
            buttonRemoveMoney.Name = "buttonRemoveMoney";
            buttonRemoveMoney.Size = new Size(117, 48);
            buttonRemoveMoney.TabIndex = 1;
            buttonRemoveMoney.Text = "Потратить";
            buttonRemoveMoney.UseVisualStyleBackColor = true;
            buttonRemoveMoney.Click += buttonRemoveMoney_Click;
            // 
            // buttonAddMoney
            // 
            buttonAddMoney.Location = new Point(17, 33);
            buttonAddMoney.Name = "buttonAddMoney";
            buttonAddMoney.Size = new Size(94, 48);
            buttonAddMoney.TabIndex = 0;
            buttonAddMoney.Text = "Внести";
            buttonAddMoney.UseVisualStyleBackColor = true;
            buttonAddMoney.Click += buttonAddMoney_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(880, 501);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Статистика";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(buttonYearStatistic, 0, 0);
            tableLayoutPanel3.Controls.Add(formsPlot1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Size = new Size(872, 493);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonYearStatistic
            // 
            buttonYearStatistic.Dock = DockStyle.Left;
            buttonYearStatistic.Location = new Point(3, 3);
            buttonYearStatistic.Name = "buttonYearStatistic";
            buttonYearStatistic.Size = new Size(224, 43);
            buttonYearStatistic.TabIndex = 0;
            buttonYearStatistic.Text = "Текущий год";
            buttonYearStatistic.UseVisualStyleBackColor = true;
            buttonYearStatistic.Click += buttonYearStatistic_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(5, 53);
            formsPlot1.Margin = new Padding(5, 4, 5, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(862, 436);
            formsPlot1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Операция";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Дата";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 92);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(563, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 92);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Общая сумма за месяц";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Enabled = false;
            textBox1.Location = new Point(6, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(268, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(599, 92);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Операции";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(6, 41);
            numericUpDown1.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(655, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 92);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Операции";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(195, 33);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 1;
            button1.Text = "Потратить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonRemoveMoney_Click;
            // 
            // button2
            // 
            button2.Location = new Point(17, 33);
            button2.Name = "button2";
            button2.Size = new Size(94, 48);
            button2.TabIndex = 0;
            button2.Text = "Внести";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonAddMoney_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(888, 542);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Мой домашний банк";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpeartions).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBoxTotalSum.ResumeLayout(false);
            groupBoxTotalSum.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputField).EndInit();
            groupBoxOperation.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewOpeartions;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel1;
        private GroupBox groupBoxOperation;
        private Button buttonRemoveMoney;
        private Button buttonAddMoney;
        private GroupBox groupBoxTotalSum;
        private TextBox outPutFirld;
        private GroupBox groupBoxInput;
        private NumericUpDown inputField;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonYearStatistic;
        private ScottPlot.FormsPlot formsPlot1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
    }
}