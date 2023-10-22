namespace FunctionsApplication
{
    partial class WorkForm4
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonLoadFromTxt = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPath.Location = new System.Drawing.Point(303, 96);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(138, 22);
            this.textBoxPath.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(86, 102);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(183, 16);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Write the full path to output file:";
            // 
            // buttonLoadFromTxt
            // 
            this.buttonLoadFromTxt.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLoadFromTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadFromTxt.Location = new System.Drawing.Point(107, 185);
            this.buttonLoadFromTxt.Name = "buttonLoadFromTxt";
            this.buttonLoadFromTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLoadFromTxt.Size = new System.Drawing.Size(334, 29);
            this.buttonLoadFromTxt.TabIndex = 6;
            this.buttonLoadFromTxt.Text = "Click here to read and output the data";
            this.buttonLoadFromTxt.UseVisualStyleBackColor = false;
            this.buttonLoadFromTxt.Click += new System.EventHandler(this.buttonLoadFromTxt_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(303, 136);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(138, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(121, 138);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(148, 16);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Result is (X + Y + Z) * 3 =";
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
            // WorkForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonLoadFromTxt);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxPath);
            this.Name = "WorkForm4";
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonLoadFromTxt;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonReturn;
    }
}