namespace assignment6
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
            this.lbSeconds = new System.Windows.Forms.Label();
            this.txtBoxSeconds = new System.Windows.Forms.TextBox();
            this.calculateTime = new System.Windows.Forms.Button();
            this.lbTimeFormat = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Location = new System.Drawing.Point(39, 55);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(67, 20);
            this.lbSeconds.TabIndex = 0;
            this.lbSeconds.Text = "Seconds:";
            // 
            // txtBoxSeconds
            // 
            this.txtBoxSeconds.Location = new System.Drawing.Point(223, 52);
            this.txtBoxSeconds.Name = "txtBoxSeconds";
            this.txtBoxSeconds.Size = new System.Drawing.Size(125, 27);
            this.txtBoxSeconds.TabIndex = 1;
            // 
            // calculateTime
            // 
            this.calculateTime.Location = new System.Drawing.Point(81, 145);
            this.calculateTime.Name = "calculateTime";
            this.calculateTime.Size = new System.Drawing.Size(222, 36);
            this.calculateTime.TabIndex = 2;
            this.calculateTime.Text = "Calculate time";
            this.calculateTime.UseVisualStyleBackColor = true;
            this.calculateTime.Click += new System.EventHandler(this.calculateTime_Click);
            // 
            // lbTimeFormat
            // 
            this.lbTimeFormat.AutoSize = true;
            this.lbTimeFormat.Location = new System.Drawing.Point(49, 259);
            this.lbTimeFormat.Name = "lbTimeFormat";
            this.lbTimeFormat.Size = new System.Drawing.Size(172, 20);
            this.lbTimeFormat.TabIndex = 3;
            this.lbTimeFormat.Text = "hours : minutes : seconds";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(49, 304);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(18, 20);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 387);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTimeFormat);
            this.Controls.Add(this.calculateTime);
            this.Controls.Add(this.txtBoxSeconds);
            this.Controls.Add(this.lbSeconds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSeconds;
        private TextBox txtBoxSeconds;
        private Button calculateTime;
        private Label lbTimeFormat;
        private Label lbTime;
    }
}