namespace FirstUI
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
            txtPlayerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMode = new TextBox();
            lblStats = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(156, 37);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(100, 23);
            txtPlayerName.TabIndex = 2;
            txtPlayerName.TextChanged += txtPlayerName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Player Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 66);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Mode (if overall, leave blank):";
            label2.Click += label2_Click;
            // 
            // txtMode
            // 
            txtMode.Location = new Point(241, 63);
            txtMode.Name = "txtMode";
            txtMode.Size = new Size(100, 23);
            txtMode.TabIndex = 5;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(53, 119);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(0, 15);
            lblStats.TabIndex = 6;
            lblStats.Click += label3_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(596, 336);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(148, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate stats";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblStats);
            Controls.Add(txtMode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPlayerName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPlayerName;
        private Label label1;
        private Label label2;
        private TextBox txtMode;
        private Label lblStats;
        private Button btnCalculate;
    }
}