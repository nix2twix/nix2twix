namespace FunctionsApplication
{
    partial class WorkForm2
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.buttonLoadFromExel = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Location = new System.Drawing.Point(303, 96);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(138, 22);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Location = new System.Drawing.Point(303, 138);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(138, 22);
            this.textBoxB.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(129, 102);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(122, 16);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "The first parameter:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(104, 144);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(147, 16);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "The second parameter:";
            // 
            // buttonLoadFromExel
            // 
            this.buttonLoadFromExel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLoadFromExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadFromExel.Location = new System.Drawing.Point(107, 229);
            this.buttonLoadFromExel.Name = "buttonLoadFromExel";
            this.buttonLoadFromExel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLoadFromExel.Size = new System.Drawing.Size(334, 29);
            this.buttonLoadFromExel.TabIndex = 6;
            this.buttonLoadFromExel.Text = "Click here to work with data from Exel";
            this.buttonLoadFromExel.UseVisualStyleBackColor = false;
            this.buttonLoadFromExel.Click += new System.EventHandler(this.buttonLoadFromExel_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(303, 180);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(138, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(129, 186);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(122, 16);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Result is (A+B) * 3 =";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(303, 281);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonReturn.Size = new System.Drawing.Size(138, 29);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return to menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // WorkForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonLoadFromExel);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "WorkForm2";
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button buttonLoadFromExel;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonReturn;
    }
}