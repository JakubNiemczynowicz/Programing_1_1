namespace assignmen10
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
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPriceValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(104, 115);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(161, 29);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Calculate Price";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(40, 54);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(36, 20);
            this.lbAge.TabIndex = 1;
            this.lbAge.Text = "Age";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(202, 51);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(125, 27);
            this.txtBoxAge.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(40, 180);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(81, 20);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price ticket";
            // 
            // lbPriceValue
            // 
            this.lbPriceValue.AutoSize = true;
            this.lbPriceValue.Location = new System.Drawing.Point(284, 180);
            this.lbPriceValue.Name = "lbPriceValue";
            this.lbPriceValue.Size = new System.Drawing.Size(18, 20);
            this.lbPriceValue.TabIndex = 4;
            this.lbPriceValue.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 245);
            this.Controls.Add(this.lbPriceValue);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.btCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCalculate;
        private Label lbAge;
        private TextBox txtBoxAge;
        private Label lbPrice;
        private Label lbPriceValue;
    }
}