namespace FunctionsApplication
{
    partial class WorkForm5
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
            this.buttonLoadFromTxt = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.labelTotalSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadFromTxt
            // 
            this.buttonLoadFromTxt.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLoadFromTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadFromTxt.Location = new System.Drawing.Point(33, 346);
            this.buttonLoadFromTxt.Name = "buttonLoadFromTxt";
            this.buttonLoadFromTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLoadFromTxt.Size = new System.Drawing.Size(528, 29);
            this.buttonLoadFromTxt.TabIndex = 6;
            this.buttonLoadFromTxt.Text = "Click here to make a report about the order";
            this.buttonLoadFromTxt.UseVisualStyleBackColor = false;
            this.buttonLoadFromTxt.Click += new System.EventHandler(this.buttonMakeReport_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(423, 393);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonReturn.Size = new System.Drawing.Size(138, 29);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return to menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(33, 27);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(528, 246);
            this.dataGridViewOrders.TabIndex = 10;
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Location = new System.Drawing.Point(285, 305);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.Size = new System.Drawing.Size(276, 22);
            this.textBoxTotalSum.TabIndex = 11;
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Location = new System.Drawing.Point(30, 311);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(82, 16);
            this.labelTotalSum.TabIndex = 12;
            this.labelTotalSum.Text = "Total sum is:";
            // 
            // WorkForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.labelTotalSum);
            this.Controls.Add(this.textBoxTotalSum);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonLoadFromTxt);
            this.Name = "WorkForm5";
            this.Text = "WorkForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoadFromTxt;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.Label labelTotalSum;
    }
}