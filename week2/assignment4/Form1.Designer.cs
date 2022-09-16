namespace assignment4
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
            this.btDetermineVat = new System.Windows.Forms.Button();
            this.lbPriceEnter = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPriceOut = new System.Windows.Forms.Label();
            this.lbVatOut = new System.Windows.Forms.Label();
            this.lbTotalOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDetermineVat
            // 
            this.btDetermineVat.Location = new System.Drawing.Point(40, 160);
            this.btDetermineVat.Name = "btDetermineVat";
            this.btDetermineVat.Size = new System.Drawing.Size(332, 39);
            this.btDetermineVat.TabIndex = 0;
            this.btDetermineVat.Text = "Determine VAT";
            this.btDetermineVat.UseVisualStyleBackColor = true;
            this.btDetermineVat.Click += new System.EventHandler(this.btDetermineVat_Click);
            // 
            // lbPriceEnter
            // 
            this.lbPriceEnter.AutoSize = true;
            this.lbPriceEnter.Location = new System.Drawing.Point(40, 59);
            this.lbPriceEnter.Name = "lbPriceEnter";
            this.lbPriceEnter.Size = new System.Drawing.Size(105, 20);
            this.lbPriceEnter.TabIndex = 1;
            this.lbPriceEnter.Text = "Enter the price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(216, 59);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPrice.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(40, 293);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price: ";
            // 
            // lbVat
            // 
            this.lbVat.AutoSize = true;
            this.lbVat.Location = new System.Drawing.Point(40, 342);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(33, 20);
            this.lbVat.TabIndex = 4;
            this.lbVat.Text = "Vat:";
            this.lbVat.Click += new System.EventHandler(this.lbVat_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(40, 388);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 20);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "Total: ";
            // 
            // lbPriceOut
            // 
            this.lbPriceOut.AutoSize = true;
            this.lbPriceOut.Location = new System.Drawing.Point(291, 293);
            this.lbPriceOut.Name = "lbPriceOut";
            this.lbPriceOut.Size = new System.Drawing.Size(18, 20);
            this.lbPriceOut.TabIndex = 6;
            this.lbPriceOut.Text = "...";
            // 
            // lbVatOut
            // 
            this.lbVatOut.AutoSize = true;
            this.lbVatOut.Location = new System.Drawing.Point(291, 342);
            this.lbVatOut.Name = "lbVatOut";
            this.lbVatOut.Size = new System.Drawing.Size(18, 20);
            this.lbVatOut.TabIndex = 8;
            this.lbVatOut.Text = "...";
            this.lbVatOut.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTotalOut
            // 
            this.lbTotalOut.AutoSize = true;
            this.lbTotalOut.Location = new System.Drawing.Point(291, 388);
            this.lbTotalOut.Name = "lbTotalOut";
            this.lbTotalOut.Size = new System.Drawing.Size(18, 20);
            this.lbTotalOut.TabIndex = 9;
            this.lbTotalOut.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 462);
            this.Controls.Add(this.lbTotalOut);
            this.Controls.Add(this.lbVatOut);
            this.Controls.Add(this.lbPriceOut);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbVat);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lbPriceEnter);
            this.Controls.Add(this.btDetermineVat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btDetermineVat;
        private Label lbPriceEnter;
        private TextBox txtBoxPrice;
        private Label lbPrice;
        private Label lbVat;
        private Label lbTotal;
        private Label lbPriceOut;
        private Label lbVatOut;
        private Label lbTotalOut;
    }
}