namespace Example
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
            this.BtCalculateAmount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfLiter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAmountToBePaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtCalculateAmount
            // 
            this.BtCalculateAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtCalculateAmount.Location = new System.Drawing.Point(70, 171);
            this.BtCalculateAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtCalculateAmount.Name = "BtCalculateAmount";
            this.BtCalculateAmount.Size = new System.Drawing.Size(279, 44);
            this.BtCalculateAmount.TabIndex = 0;
            this.BtCalculateAmount.Text = "Calculate amount";
            this.BtCalculateAmount.UseVisualStyleBackColor = true;
            this.BtCalculateAmount.Click += new System.EventHandler(this.BtCalculateAmount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of liters:\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumberOfLiter
            // 
            this.txtNumberOfLiter.Location = new System.Drawing.Point(248, 110);
            this.txtNumberOfLiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberOfLiter.Name = "txtNumberOfLiter";
            this.txtNumberOfLiter.Size = new System.Drawing.Size(170, 30);
            this.txtNumberOfLiter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount to be paid";
            // 
            // lbAmountToBePaid
            // 
            this.lbAmountToBePaid.AutoSize = true;
            this.lbAmountToBePaid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmountToBePaid.Location = new System.Drawing.Point(316, 259);
            this.lbAmountToBePaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmountToBePaid.Name = "lbAmountToBePaid";
            this.lbAmountToBePaid.Size = new System.Drawing.Size(24, 25);
            this.lbAmountToBePaid.TabIndex = 4;
            this.lbAmountToBePaid.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 517);
            this.Controls.Add(this.lbAmountToBePaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfLiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtCalculateAmount);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "Windows Forms example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtCalculateAmount;
        private Label label1;
        private TextBox txtNumberOfLiter;
        private Label label2;
        private Label lbAmountToBePaid;
    }
}