namespace assignment5
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
            this.CalculateAvereage = new System.Windows.Forms.Button();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.lbNumber3 = new System.Windows.Forms.Label();
            this.txtBoxNb1 = new System.Windows.Forms.TextBox();
            this.txtBoxNb2 = new System.Windows.Forms.TextBox();
            this.txtBoxNb3 = new System.Windows.Forms.TextBox();
            this.lbAverage = new System.Windows.Forms.Label();
            this.lbAverageValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateAvereage
            // 
            this.CalculateAvereage.Location = new System.Drawing.Point(98, 231);
            this.CalculateAvereage.Name = "CalculateAvereage";
            this.CalculateAvereage.Size = new System.Drawing.Size(218, 50);
            this.CalculateAvereage.TabIndex = 0;
            this.CalculateAvereage.Text = "Calculate Average";
            this.CalculateAvereage.UseVisualStyleBackColor = true;
            this.CalculateAvereage.Click += new System.EventHandler(this.CalculateAvereage_Click);
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(42, 51);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(74, 20);
            this.lbNumber1.TabIndex = 1;
            this.lbNumber1.Text = "Number1:";
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Location = new System.Drawing.Point(42, 106);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(74, 20);
            this.lbNumber2.TabIndex = 2;
            this.lbNumber2.Text = "Number2:";
            // 
            // lbNumber3
            // 
            this.lbNumber3.AutoSize = true;
            this.lbNumber3.Location = new System.Drawing.Point(42, 161);
            this.lbNumber3.Name = "lbNumber3";
            this.lbNumber3.Size = new System.Drawing.Size(74, 20);
            this.lbNumber3.TabIndex = 3;
            this.lbNumber3.Text = "Number3:";
            // 
            // txtBoxNb1
            // 
            this.txtBoxNb1.Location = new System.Drawing.Point(229, 48);
            this.txtBoxNb1.Name = "txtBoxNb1";
            this.txtBoxNb1.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNb1.TabIndex = 4;
            // 
            // txtBoxNb2
            // 
            this.txtBoxNb2.Location = new System.Drawing.Point(229, 103);
            this.txtBoxNb2.Name = "txtBoxNb2";
            this.txtBoxNb2.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNb2.TabIndex = 5;
            // 
            // txtBoxNb3
            // 
            this.txtBoxNb3.Location = new System.Drawing.Point(229, 158);
            this.txtBoxNb3.Name = "txtBoxNb3";
            this.txtBoxNb3.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNb3.TabIndex = 6;
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(37, 357);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(67, 20);
            this.lbAverage.TabIndex = 7;
            this.lbAverage.Text = "Average:";
            // 
            // lbAverageValue
            // 
            this.lbAverageValue.AutoSize = true;
            this.lbAverageValue.Location = new System.Drawing.Point(262, 357);
            this.lbAverageValue.Name = "lbAverageValue";
            this.lbAverageValue.Size = new System.Drawing.Size(18, 20);
            this.lbAverageValue.TabIndex = 8;
            this.lbAverageValue.Text = "...";
            this.lbAverageValue.Click += new System.EventHandler(this.lbAverageValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.lbAverageValue);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.txtBoxNb3);
            this.Controls.Add(this.txtBoxNb2);
            this.Controls.Add(this.txtBoxNb1);
            this.Controls.Add(this.lbNumber3);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.lbNumber1);
            this.Controls.Add(this.CalculateAvereage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CalculateAvereage;
        private Label lbNumber1;
        private Label lbNumber2;
        private Label lbNumber3;
        private TextBox txtBoxNb1;
        private TextBox txtBoxNb2;
        private TextBox txtBoxNb3;
        private Label lbAverage;
        private Label lbAverageValue;
    }
}