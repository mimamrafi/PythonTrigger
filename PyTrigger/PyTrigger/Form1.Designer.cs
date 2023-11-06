namespace PyTrigger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            TB_PyDirPath = new TextBox();
            PB_Browse = new Button();
            LBL_PlottingTime = new Label();
            TB_PlottingTime = new TextBox();
            CB_Record = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222233F));
            tableLayoutPanel1.Controls.Add(TB_PyDirPath, 0, 0);
            tableLayoutPanel1.Controls.Add(PB_Browse, 2, 0);
            tableLayoutPanel1.Controls.Add(LBL_PlottingTime, 0, 1);
            tableLayoutPanel1.Controls.Add(TB_PlottingTime, 1, 1);
            tableLayoutPanel1.Controls.Add(CB_Record, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(514, 78);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TB_PyDirPath
            // 
            TB_PyDirPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(TB_PyDirPath, 2);
            TB_PyDirPath.Location = new Point(3, 3);
            TB_PyDirPath.Name = "TB_PyDirPath";
            TB_PyDirPath.PlaceholderText = "Input Python Directory File";
            TB_PyDirPath.Size = new Size(393, 23);
            TB_PyDirPath.TabIndex = 0;
            // 
            // PB_Browse
            // 
            PB_Browse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PB_Browse.Cursor = Cursors.Hand;
            PB_Browse.Location = new Point(402, 3);
            PB_Browse.Name = "PB_Browse";
            PB_Browse.Size = new Size(109, 23);
            PB_Browse.TabIndex = 1;
            PB_Browse.Text = "Browse";
            PB_Browse.UseVisualStyleBackColor = true;
            PB_Browse.Click += PB_Browse_Click;
            // 
            // LBL_PlottingTime
            // 
            LBL_PlottingTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBL_PlottingTime.AutoSize = true;
            LBL_PlottingTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_PlottingTime.Location = new Point(194, 39);
            LBL_PlottingTime.Name = "LBL_PlottingTime";
            LBL_PlottingTime.Size = new Size(145, 21);
            LBL_PlottingTime.TabIndex = 2;
            LBL_PlottingTime.Text = "Plotting for each (s)";
            // 
            // TB_PlottingTime
            // 
            TB_PlottingTime.Location = new Point(345, 42);
            TB_PlottingTime.Name = "TB_PlottingTime";
            TB_PlottingTime.PlaceholderText = "Number";
            TB_PlottingTime.Size = new Size(51, 23);
            TB_PlottingTime.TabIndex = 3;
            // 
            // CB_Record
            // 
            CB_Record.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CB_Record.Appearance = Appearance.Button;
            CB_Record.AutoSize = true;
            CB_Record.CheckAlign = ContentAlignment.MiddleCenter;
            CB_Record.Cursor = Cursors.Hand;
            CB_Record.Location = new Point(402, 42);
            CB_Record.Name = "CB_Record";
            CB_Record.Size = new Size(109, 25);
            CB_Record.TabIndex = 4;
            CB_Record.Text = "Run";
            CB_Record.TextAlign = ContentAlignment.MiddleCenter;
            CB_Record.UseVisualStyleBackColor = true;
            CB_Record.CheckedChanged += CB_Record_CheckedChanged;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 78);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(530, 100);
            Name = "Form1";
            Text = "Auto Report";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TB_PyDirPath;
        private Button PB_Browse;
        private Label LBL_PlottingTime;
        private TextBox TB_PlottingTime;
        private CheckBox CB_Record;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}