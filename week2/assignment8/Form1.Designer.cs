namespace assignment8
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
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbTshirtNo = new System.Windows.Forms.Label();
            this.txtBoxTshirtNo = new System.Windows.Forms.TextBox();
            this.lbJeansNo = new System.Windows.Forms.Label();
            this.txtBoxJeansNo = new System.Windows.Forms.TextBox();
            this.grBoxInvoice = new System.Windows.Forms.GroupBox();
            this.lbTotalValue = new System.Windows.Forms.Label();
            this.lbVatValue = new System.Windows.Forms.Label();
            this.lbPriceValue = new System.Windows.Forms.Label();
            this.lbDateValue = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.grBoxInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btCalculate.Image")));
            this.btCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalculate.Location = new System.Drawing.Point(32, 163);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCalculate.Size = new System.Drawing.Size(292, 54);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbTshirtNo
            // 
            this.lbTshirtNo.AutoSize = true;
            this.lbTshirtNo.Location = new System.Drawing.Point(32, 40);
            this.lbTshirtNo.Name = "lbTshirtNo";
            this.lbTshirtNo.Size = new System.Drawing.Size(208, 20);
            this.lbTshirtNo.TabIndex = 2;
            this.lbTshirtNo.Text = "Number of T-shors (x € 30.00):";
            // 
            // txtBoxTshirtNo
            // 
            this.txtBoxTshirtNo.Location = new System.Drawing.Point(264, 37);
            this.txtBoxTshirtNo.Name = "txtBoxTshirtNo";
            this.txtBoxTshirtNo.Size = new System.Drawing.Size(60, 27);
            this.txtBoxTshirtNo.TabIndex = 3;
            // 
            // lbJeansNo
            // 
            this.lbJeansNo.AutoSize = true;
            this.lbJeansNo.Location = new System.Drawing.Point(32, 95);
            this.lbJeansNo.Name = "lbJeansNo";
            this.lbJeansNo.Size = new System.Drawing.Size(202, 20);
            this.lbJeansNo.TabIndex = 4;
            this.lbJeansNo.Text = "Number of jeans (x € 100.00):";
            // 
            // txtBoxJeansNo
            // 
            this.txtBoxJeansNo.Location = new System.Drawing.Point(264, 92);
            this.txtBoxJeansNo.Name = "txtBoxJeansNo";
            this.txtBoxJeansNo.Size = new System.Drawing.Size(60, 27);
            this.txtBoxJeansNo.TabIndex = 5;
            // 
            // grBoxInvoice
            // 
            this.grBoxInvoice.Controls.Add(this.lbTotalValue);
            this.grBoxInvoice.Controls.Add(this.lbVatValue);
            this.grBoxInvoice.Controls.Add(this.lbPriceValue);
            this.grBoxInvoice.Controls.Add(this.lbDateValue);
            this.grBoxInvoice.Controls.Add(this.lbTotal);
            this.grBoxInvoice.Controls.Add(this.lbVat);
            this.grBoxInvoice.Controls.Add(this.lbPrice);
            this.grBoxInvoice.Controls.Add(this.lbDate);
            this.grBoxInvoice.Location = new System.Drawing.Point(30, 263);
            this.grBoxInvoice.Name = "grBoxInvoice";
            this.grBoxInvoice.Size = new System.Drawing.Size(309, 181);
            this.grBoxInvoice.TabIndex = 6;
            this.grBoxInvoice.TabStop = false;
            this.grBoxInvoice.Text = "Invoice";
            this.grBoxInvoice.Enter += new System.EventHandler(this.grBoxInvoice_Enter);
            // 
            // lbTotalValue
            // 
            this.lbTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalValue.AutoSize = true;
            this.lbTotalValue.Location = new System.Drawing.Point(276, 140);
            this.lbTotalValue.Name = "lbTotalValue";
            this.lbTotalValue.Size = new System.Drawing.Size(18, 20);
            this.lbTotalValue.TabIndex = 7;
            this.lbTotalValue.Text = "...";
            this.lbTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbVatValue
            // 
            this.lbVatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVatValue.AutoSize = true;
            this.lbVatValue.Location = new System.Drawing.Point(276, 96);
            this.lbVatValue.Name = "lbVatValue";
            this.lbVatValue.Size = new System.Drawing.Size(18, 20);
            this.lbVatValue.TabIndex = 6;
            this.lbVatValue.Text = "...";
            this.lbVatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPriceValue
            // 
            this.lbPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPriceValue.AutoSize = true;
            this.lbPriceValue.Location = new System.Drawing.Point(276, 66);
            this.lbPriceValue.Name = "lbPriceValue";
            this.lbPriceValue.Size = new System.Drawing.Size(18, 20);
            this.lbPriceValue.TabIndex = 5;
            this.lbPriceValue.Text = "...";
            this.lbPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPriceValue.Click += new System.EventHandler(this.lbPriceValue_Click);
            // 
            // lbDateValue
            // 
            this.lbDateValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDateValue.AutoSize = true;
            this.lbDateValue.Location = new System.Drawing.Point(276, 36);
            this.lbDateValue.Name = "lbDateValue";
            this.lbDateValue.Size = new System.Drawing.Size(18, 20);
            this.lbDateValue.TabIndex = 4;
            this.lbDateValue.Text = "...";
            this.lbDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(14, 140);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(82, 20);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total price:";
            // 
            // lbVat
            // 
            this.lbVat.AutoSize = true;
            this.lbVat.Location = new System.Drawing.Point(14, 96);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(37, 20);
            this.lbVat.TabIndex = 2;
            this.lbVat.Text = "VAT:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(14, 66);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 20);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price:";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(14, 36);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 20);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 456);
            this.Controls.Add(this.grBoxInvoice);
            this.Controls.Add(this.txtBoxJeansNo);
            this.Controls.Add(this.lbJeansNo);
            this.Controls.Add(this.txtBoxTshirtNo);
            this.Controls.Add(this.lbTshirtNo);
            this.Controls.Add(this.btCalculate);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBoxInvoice.ResumeLayout(false);
            this.grBoxInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCalculate;
        private Label lbTshirtNo;
        private TextBox txtBoxTshirtNo;
        private Label lbJeansNo;
        private TextBox txtBoxJeansNo;
        private GroupBox grBoxInvoice;
        private Label lbTotal;
        private Label lbVat;
        private Label lbPrice;
        private Label lbDate;
        private Label lbVatValue;
        private Label lbPriceValue;
        private Label lbDateValue;
        private Label lbTotalValue;
    }
}