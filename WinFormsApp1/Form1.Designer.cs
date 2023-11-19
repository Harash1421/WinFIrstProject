namespace WinFormsApp1
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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buApply = new Button();
            edFirstName = new TextBox();
            label2 = new Label();
            edLastName = new TextBox();
            tvWelcome = new Label();
            buClear = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // buApply
            // 
            buApply.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buApply.Location = new Point(3, 3);
            buApply.Name = "buApply";
            buApply.Size = new Size(163, 41);
            buApply.TabIndex = 1;
            buApply.Text = "Apply";
            buApply.UseVisualStyleBackColor = true;
            buApply.Click += buApply_Click;
            // 
            // edFirstName
            // 
            edFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edFirstName.Location = new Point(12, 27);
            edFirstName.Name = "edFirstName";
            edFirstName.Size = new Size(339, 23);
            edFirstName.TabIndex = 2;
            edFirstName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // edLastName
            // 
            edLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edLastName.Location = new Point(12, 80);
            edLastName.Name = "edLastName";
            edLastName.Size = new Size(339, 23);
            edLastName.TabIndex = 4;
            // 
            // tvWelcome
            // 
            tvWelcome.AutoSize = true;
            tvWelcome.Location = new Point(12, 123);
            tvWelcome.Name = "tvWelcome";
            tvWelcome.Size = new Size(38, 15);
            tvWelcome.TabIndex = 5;
            tvWelcome.Text = "label3";
            // 
            // buClear
            // 
            buClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buClear.Location = new Point(172, 3);
            buClear.Name = "buClear";
            buClear.Size = new Size(164, 41);
            buClear.TabIndex = 6;
            buClear.Text = "Clear";
            buClear.UseVisualStyleBackColor = true;
            buClear.Click += buClear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buApply, 0, 0);
            tableLayoutPanel1.Controls.Add(buClear, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 277);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(339, 48);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 377);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tvWelcome);
            Controls.Add(edLastName);
            Controls.Add(label2);
            Controls.Add(edFirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buApply;
        private TextBox edFirstName;
        private Label label2;
        private TextBox edLastName;
        private Label tvWelcome;
        private Button buClear;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
