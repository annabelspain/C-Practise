namespace PizzaForm
{
    partial class HomePage
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
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.FindDiscountButton = new System.Windows.Forms.Button();
            this.WeekendCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersGrid.Location = new System.Drawing.Point(0, 0);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGrid.Size = new System.Drawing.Size(533, 236);
            this.OrdersGrid.TabIndex = 0;
            // 
            // FindDiscountButton
            // 
            this.FindDiscountButton.Location = new System.Drawing.Point(87, 245);
            this.FindDiscountButton.Name = "FindDiscountButton";
            this.FindDiscountButton.Size = new System.Drawing.Size(94, 35);
            this.FindDiscountButton.TabIndex = 1;
            this.FindDiscountButton.Text = "Find Discount";
            this.FindDiscountButton.UseVisualStyleBackColor = true;
            this.FindDiscountButton.Click += new System.EventHandler(this.FindDiscountButton_Click);
            // 
            // WeekendCheckBox
            // 
            this.WeekendCheckBox.AutoSize = true;
            this.WeekendCheckBox.Location = new System.Drawing.Point(8, 254);
            this.WeekendCheckBox.Name = "WeekendCheckBox";
            this.WeekendCheckBox.Size = new System.Drawing.Size(73, 17);
            this.WeekendCheckBox.TabIndex = 2;
            this.WeekendCheckBox.Text = "Weekend";
            this.WeekendCheckBox.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.WeekendCheckBox);
            this.Controls.Add(this.FindDiscountButton);
            this.Controls.Add(this.OrdersGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Button FindDiscountButton;
        private System.Windows.Forms.CheckBox WeekendCheckBox;
    }
}

