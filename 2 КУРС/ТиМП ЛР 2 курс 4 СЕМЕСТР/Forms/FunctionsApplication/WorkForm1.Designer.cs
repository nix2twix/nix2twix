namespace FunctionsApplication
{
    partial class WorkForm1
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
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Location = new System.Drawing.Point(233, 44);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(138, 22);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Location = new System.Drawing.Point(233, 86);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(138, 22);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // textBoxC
            // 
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxC.Location = new System.Drawing.Point(233, 130);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(138, 22);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxC_KeyPress);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(59, 50);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(150, 16);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Write the first parameter:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(34, 92);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(175, 16);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Write the second parameter:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(54, 136);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(155, 16);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "Write the third parameter:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Location = new System.Drawing.Point(233, 171);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCalc.Size = new System.Drawing.Size(138, 29);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(233, 225);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(138, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(71, 228);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(138, 16);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Result is (A+B+C) * 2 =";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(233, 276);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return to menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}