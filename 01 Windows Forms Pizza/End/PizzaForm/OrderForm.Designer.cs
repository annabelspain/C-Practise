namespace PizzaForm
{
    partial class OrderForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.PizzasGrid = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PizzasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(28, 15);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(35, 13);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "label1";
            // 
            // PizzasGrid
            // 
            this.PizzasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PizzasGrid.Location = new System.Drawing.Point(31, 49);
            this.PizzasGrid.Name = "PizzasGrid";
            this.PizzasGrid.RowHeadersWidth = 62;
            this.PizzasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PizzasGrid.Size = new System.Drawing.Size(473, 198);
            this.PizzasGrid.TabIndex = 1;
            this.PizzasGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.PizzasGrid_UserDeletingRow);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(34, 262);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 27);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save && Quit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PizzasGrid);
            this.Controls.Add(this.MessageLabel);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PizzasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.DataGridView PizzasGrid;
        private System.Windows.Forms.Button SaveButton;
    }
}