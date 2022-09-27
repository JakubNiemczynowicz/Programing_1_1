namespace assignment9
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
            this.RadioBtFootball = new System.Windows.Forms.RadioButton();
            this.RadioBtHandball = new System.Windows.Forms.RadioButton();
            this.lbSport = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMembership = new System.Windows.Forms.TextBox();
            this.lbFeeToBePaid = new System.Windows.Forms.Label();
            this.lbFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(81, 244);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(169, 29);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Calculate Fee";
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // RadioBtFootball
            // 
            this.RadioBtFootball.AutoSize = true;
            this.RadioBtFootball.Location = new System.Drawing.Point(186, 42);
            this.RadioBtFootball.Name = "RadioBtFootball";
            this.RadioBtFootball.Size = new System.Drawing.Size(85, 24);
            this.RadioBtFootball.TabIndex = 1;
            this.RadioBtFootball.TabStop = true;
            this.RadioBtFootball.Text = "Football";
            this.RadioBtFootball.UseVisualStyleBackColor = true;
            // 
            // RadioBtHandball
            // 
            this.RadioBtHandball.AutoSize = true;
            this.RadioBtHandball.Location = new System.Drawing.Point(186, 87);
            this.RadioBtHandball.Name = "RadioBtHandball";
            this.RadioBtHandball.Size = new System.Drawing.Size(91, 24);
            this.RadioBtHandball.TabIndex = 2;
            this.RadioBtHandball.TabStop = true;
            this.RadioBtHandball.Text = "Handball";
            this.RadioBtHandball.UseVisualStyleBackColor = true;
            // 
            // lbSport
            // 
            this.lbSport.AutoSize = true;
            this.lbSport.Location = new System.Drawing.Point(31, 45);
            this.lbSport.Name = "lbSport";
            this.lbSport.Size = new System.Drawing.Size(45, 20);
            this.lbSport.TabIndex = 3;
            this.lbSport.Text = "Sport";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(12, 149);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(36, 20);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Age";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(186, 146);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(125, 27);
            this.txtBoxAge.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Membership duration";
            // 
            // txtBoxMembership
            // 
            this.txtBoxMembership.Location = new System.Drawing.Point(186, 186);
            this.txtBoxMembership.Name = "txtBoxMembership";
            this.txtBoxMembership.Size = new System.Drawing.Size(125, 27);
            this.txtBoxMembership.TabIndex = 7;
            // 
            // lbFeeToBePaid
            // 
            this.lbFeeToBePaid.AutoSize = true;
            this.lbFeeToBePaid.Location = new System.Drawing.Point(29, 309);
            this.lbFeeToBePaid.Name = "lbFeeToBePaid";
            this.lbFeeToBePaid.Size = new System.Drawing.Size(105, 20);
            this.lbFeeToBePaid.TabIndex = 8;
            this.lbFeeToBePaid.Text = "Fee to be paid";
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Location = new System.Drawing.Point(221, 309);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(18, 20);
            this.lbFee.TabIndex = 9;
            this.lbFee.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 385);
            this.Controls.Add(this.lbFee);
            this.Controls.Add(this.lbFeeToBePaid);
            this.Controls.Add(this.txtBoxMembership);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbSport);
            this.Controls.Add(this.RadioBtHandball);
            this.Controls.Add(this.RadioBtFootball);
            this.Controls.Add(this.btCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCalculate;
        private RadioButton RadioBtFootball;
        private RadioButton RadioBtHandball;
        private Label lbSport;
        private Label lbAge;
        private TextBox txtBoxAge;
        private Label label1;
        private TextBox txtBoxMembership;
        private Label lbFeeToBePaid;
        private Label lbFee;
    }
}