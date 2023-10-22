namespace FormTMP
{
    partial class FormTMP
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonClose.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.Brown;
            this.buttonClose.Location = new System.Drawing.Point(12, 64);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(167, 43);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogo.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonLogo.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogo.ForeColor = System.Drawing.Color.Black;
            this.buttonLogo.Location = new System.Drawing.Point(12, 12);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(167, 46);
            this.buttonLogo.TabIndex = 2;
            this.buttonLogo.Text = "Логотип вуза";
            this.buttonLogo.UseVisualStyleBackColor = false;
            this.buttonLogo.Click += new System.EventHandler(this.buttonLogo_Click);
            // 
            // FormTMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 146);
            this.Controls.Add(this.buttonLogo);
            this.Controls.Add(this.buttonClose);
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.Name = "FormTMP";
            this.Text = "Финуниверситет";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonClose;
        private Button buttonLogo;
    }
}