namespace TestProject
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
            plotField = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // plotField
            // 
            plotField.Dock = DockStyle.Fill;
            plotField.Location = new Point(0, 0);
            plotField.Margin = new Padding(5, 4, 5, 4);
            plotField.Name = "plotField";
            plotField.Size = new Size(800, 450);
            plotField.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(plotField);
            Name = "MainForm";
            Text = "Test Form";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot plotField;
    }
}