namespace FunctionsApplication
{
    partial class WorkForm7
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
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelArray = new System.Windows.Forms.Label();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMax.Location = new System.Drawing.Point(250, 134);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(191, 22);
            this.textBoxMax.TabIndex = 0;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(104, 140);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(107, 16);
            this.labelMax.TabIndex = 3;
            this.labelMax.Text = "The maximum is:";
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(107, 185);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSort.Size = new System.Drawing.Size(334, 29);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Click here to sort the array and find maximum:";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(303, 237);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonReturn.Size = new System.Drawing.Size(138, 29);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return to menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // labelArray
            // 
            this.labelArray.AutoSize = true;
            this.labelArray.Location = new System.Drawing.Point(104, 93);
            this.labelArray.Name = "labelArray";
            this.labelArray.Size = new System.Drawing.Size(126, 16);
            this.labelArray.TabIndex = 11;
            this.labelArray.Text = "Write the array here:";
            // 
            // textBoxArray
            // 
            this.textBoxArray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxArray.Location = new System.Drawing.Point(250, 91);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(191, 22);
            this.textBoxArray.TabIndex = 10;
            // 
            // WorkForm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.labelArray);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.textBoxMax);
            this.Name = "WorkForm7";
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelArray;
        private System.Windows.Forms.TextBox textBoxArray;
    }
}