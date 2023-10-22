namespace FunctionsApplication
{
    partial class WorkForm6
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonCheckStudent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurname.Location = new System.Drawing.Point(303, 134);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(138, 22);
            this.textBoxSurname.TabIndex = 0;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(104, 136);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(173, 16);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Write the student\'s surname:";
            // 
            // buttonCheckStudent
            // 
            this.buttonCheckStudent.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCheckStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckStudent.Location = new System.Drawing.Point(107, 185);
            this.buttonCheckStudent.Name = "buttonCheckStudent";
            this.buttonCheckStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCheckStudent.Size = new System.Drawing.Size(334, 29);
            this.buttonCheckStudent.TabIndex = 6;
            this.buttonCheckStudent.Text = "Click here to check the student";
            this.buttonCheckStudent.UseVisualStyleBackColor = false;
            this.buttonCheckStudent.Click += new System.EventHandler(this.buttonCheckStudent_Click);
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
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(104, 93);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(173, 16);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "Write the student\'s surname:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Location = new System.Drawing.Point(303, 91);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(138, 22);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // WorkForm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCheckStudent);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Name = "WorkForm6";
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonCheckStudent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
    }
}