namespace assignment7
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
            this.lbStart = new System.Windows.Forms.Label();
            this.txtBoxStart = new System.Windows.Forms.TextBox();
            this.lbEnd = new System.Windows.Forms.Label();
            this.txtBoxEnd = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btErase = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbVat = new System.Windows.Forms.Label();
            this.lbVatValue = new System.Windows.Forms.Label();
            this.lbExcl = new System.Windows.Forms.Label();
            this.lbPriceExcl = new System.Windows.Forms.Label();
            this.lbIncl = new System.Windows.Forms.Label();
            this.lbPriceIncl = new System.Windows.Forms.Label();
            this.lbPriceExclValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(39, 55);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(64, 20);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "Start km";
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Location = new System.Drawing.Point(209, 52);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.Size = new System.Drawing.Size(125, 27);
            this.txtBoxStart.TabIndex = 1;
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(39, 98);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(58, 20);
            this.lbEnd.TabIndex = 2;
            this.lbEnd.Text = "End km";
            // 
            // txtBoxEnd
            // 
            this.txtBoxEnd.Location = new System.Drawing.Point(209, 95);
            this.txtBoxEnd.Name = "txtBoxEnd";
            this.txtBoxEnd.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEnd.TabIndex = 3;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(39, 149);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(75, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price / km";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(209, 146);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPrice.TabIndex = 5;
            // 
            // btErase
            // 
            this.btErase.Location = new System.Drawing.Point(392, 46);
            this.btErase.Name = "btErase";
            this.btErase.Size = new System.Drawing.Size(94, 29);
            this.btErase.TabIndex = 6;
            this.btErase.Text = "Erase";
            this.btErase.UseVisualStyleBackColor = true;
            this.btErase.Click += new System.EventHandler(this.btErase_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(392, 145);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(94, 29);
            this.btCalculate.TabIndex = 7;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbVat
            // 
            this.lbVat.AutoSize = true;
            this.lbVat.Location = new System.Drawing.Point(211, 279);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(34, 20);
            this.lbVat.TabIndex = 8;
            this.lbVat.Text = "VAT";
            // 
            // lbVatValue
            // 
            this.lbVatValue.AutoSize = true;
            this.lbVatValue.Location = new System.Drawing.Point(211, 338);
            this.lbVatValue.Name = "lbVatValue";
            this.lbVatValue.Size = new System.Drawing.Size(18, 20);
            this.lbVatValue.TabIndex = 9;
            this.lbVatValue.Text = "...";
            // 
            // lbExcl
            // 
            this.lbExcl.AutoSize = true;
            this.lbExcl.Location = new System.Drawing.Point(39, 279);
            this.lbExcl.Name = "lbExcl";
            this.lbExcl.Size = new System.Drawing.Size(100, 20);
            this.lbExcl.TabIndex = 10;
            this.lbExcl.Text = "Price excl VAT";
            // 
            // lbPriceExcl
            // 
            this.lbPriceExcl.Location = new System.Drawing.Point(0, 0);
            this.lbPriceExcl.Name = "lbPriceExcl";
            this.lbPriceExcl.Size = new System.Drawing.Size(100, 23);
            this.lbPriceExcl.TabIndex = 14;
            // 
            // lbIncl
            // 
            this.lbIncl.AutoSize = true;
            this.lbIncl.Location = new System.Drawing.Point(379, 280);
            this.lbIncl.Name = "lbIncl";
            this.lbIncl.Size = new System.Drawing.Size(97, 20);
            this.lbIncl.TabIndex = 12;
            this.lbIncl.Text = "Price incl VAT";
            // 
            // lbPriceIncl
            // 
            this.lbPriceIncl.AutoSize = true;
            this.lbPriceIncl.Location = new System.Drawing.Point(378, 335);
            this.lbPriceIncl.Name = "lbPriceIncl";
            this.lbPriceIncl.Size = new System.Drawing.Size(18, 20);
            this.lbPriceIncl.TabIndex = 13;
            this.lbPriceIncl.Text = "...";
            this.lbPriceIncl.Click += new System.EventHandler(this.ibPriceIncl_Click);
            // 
            // lbPriceExclValue
            // 
            this.lbPriceExclValue.AutoSize = true;
            this.lbPriceExclValue.Location = new System.Drawing.Point(40, 332);
            this.lbPriceExclValue.Name = "lbPriceExclValue";
            this.lbPriceExclValue.Size = new System.Drawing.Size(18, 20);
            this.lbPriceExclValue.TabIndex = 15;
            this.lbPriceExclValue.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 389);
            this.Controls.Add(this.lbPriceExclValue);
            this.Controls.Add(this.lbPriceIncl);
            this.Controls.Add(this.lbIncl);
            this.Controls.Add(this.lbPriceExcl);
            this.Controls.Add(this.lbExcl);
            this.Controls.Add(this.lbVatValue);
            this.Controls.Add(this.lbVat);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.btErase);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtBoxEnd);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.txtBoxStart);
            this.Controls.Add(this.lbStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbStart;
        private TextBox txtBoxStart;
        private Label lbEnd;
        private TextBox txtBoxEnd;
        private Label lbPrice;
        private TextBox txtBoxPrice;
        private Button btErase;
        private Button btCalculate;
        private Label lbVat;
        private Label lbVatValue;
        private Label lbExcl;
        private Label lbPriceExcl;
        private Label lbIncl;
        private Label lbPriceIncl;
        private Label lbPriceExclValue;
    }
}