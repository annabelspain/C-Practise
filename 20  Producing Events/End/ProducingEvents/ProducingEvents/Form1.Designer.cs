namespace ConsumingEvents
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrimes = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfPrimes = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPrimes
            // 
            this.btnPrimes.Location = new System.Drawing.Point(165, 132);
            this.btnPrimes.Name = "btnPrimes";
            this.btnPrimes.Size = new System.Drawing.Size(214, 121);
            this.btnPrimes.TabIndex = 0;
            this.btnPrimes.Text = "How many prime numbers";
            this.btnPrimes.UseVisualStyleBackColor = true;
            this.btnPrimes.Click += new System.EventHandler(this.btnPrimes_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(161, 47);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(217, 26);
            this.txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of prime numbers = ";
            // 
            // lblNumberOfPrimes
            // 
            this.lblNumberOfPrimes.AutoSize = true;
            this.lblNumberOfPrimes.Location = new System.Drawing.Point(394, 312);
            this.lblNumberOfPrimes.Name = "lblNumberOfPrimes";
            this.lblNumberOfPrimes.Size = new System.Drawing.Size(76, 20);
            this.lblNumberOfPrimes.TabIndex = 3;
            this.lblNumberOfPrimes.Text = "Unknown";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(159, 366);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 43);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblNumberOfPrimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnPrimes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimes;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfPrimes;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

