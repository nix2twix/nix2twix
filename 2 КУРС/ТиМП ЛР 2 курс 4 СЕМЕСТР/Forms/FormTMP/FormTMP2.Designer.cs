namespace FormTMP
{
    partial class FormTMP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTMP2));
            this.buttonBackToForm1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTSU = new System.Windows.Forms.Label();
            this.labelProfs = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShowHidden = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.labelYearIn = new System.Windows.Forms.Label();
            this.labelYearGradFrom = new System.Windows.Forms.Label();
            this.buttonCalculateGradYear = new System.Windows.Forms.Button();
            this.buttonYearIn = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToForm1
            // 
            this.buttonBackToForm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackToForm1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToForm1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBackToForm1.Location = new System.Drawing.Point(40, 21);
            this.buttonBackToForm1.Name = "buttonBackToForm1";
            this.buttonBackToForm1.Size = new System.Drawing.Size(215, 45);
            this.buttonBackToForm1.TabIndex = 0;
            this.buttonBackToForm1.Text = "Вернуться к форме вуза";
            this.buttonBackToForm1.UseVisualStyleBackColor = false;
            this.buttonBackToForm1.Click += new System.EventHandler(this.buttonBackToForm1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 186);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTSU
            // 
            this.labelTSU.AutoSize = true;
            this.labelTSU.BackColor = System.Drawing.Color.Transparent;
            this.labelTSU.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTSU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTSU.Location = new System.Drawing.Point(41, 292);
            this.labelTSU.Name = "labelTSU";
            this.labelTSU.Size = new System.Drawing.Size(418, 36);
            this.labelTSU.TabIndex = 2;
            this.labelTSU.Text = "Тульский государственный университет";
            this.labelTSU.Visible = false;
            // 
            // labelProfs
            // 
            this.labelProfs.AutoSize = true;
            this.labelProfs.BackColor = System.Drawing.Color.Transparent;
            this.labelProfs.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProfs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProfs.Location = new System.Drawing.Point(41, 328);
            this.labelProfs.Name = "labelProfs";
            this.labelProfs.Size = new System.Drawing.Size(628, 36);
            this.labelProfs.TabIndex = 3;
            this.labelProfs.Text = "Информационная безопасность автоматизированных систем";
            this.labelProfs.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.buttonClose.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.Brown;
            this.buttonClose.Location = new System.Drawing.Point(284, 21);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(189, 45);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonShowHidden
            // 
            this.buttonShowHidden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowHidden.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowHidden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowHidden.Location = new System.Drawing.Point(508, 21);
            this.buttonShowHidden.Name = "buttonShowHidden";
            this.buttonShowHidden.Size = new System.Drawing.Size(215, 45);
            this.buttonShowHidden.TabIndex = 6;
            this.buttonShowHidden.Text = "Показать скрытые поля";
            this.buttonShowHidden.UseVisualStyleBackColor = false;
            this.buttonShowHidden.Click += new System.EventHandler(this.buttonShowHiddenOnClick);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(41, 420);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(184, 29);
            this.textBoxIn.TabIndex = 7;
            this.textBoxIn.Visible = false;
            this.textBoxIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIn_KeyPress);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(578, 420);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(184, 29);
            this.textBoxOut.TabIndex = 8;
            this.textBoxOut.Visible = false;
            this.textBoxOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOut_KeyPress);
            // 
            // labelYearIn
            // 
            this.labelYearIn.AutoSize = true;
            this.labelYearIn.BackColor = System.Drawing.Color.Transparent;
            this.labelYearIn.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYearIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelYearIn.Location = new System.Drawing.Point(40, 381);
            this.labelYearIn.Name = "labelYearIn";
            this.labelYearIn.Size = new System.Drawing.Size(185, 36);
            this.labelYearIn.TabIndex = 9;
            this.labelYearIn.Text = "Год поступления";
            this.labelYearIn.Visible = false;
            // 
            // labelYearGradFrom
            // 
            this.labelYearGradFrom.AutoSize = true;
            this.labelYearGradFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelYearGradFrom.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYearGradFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelYearGradFrom.Location = new System.Drawing.Point(578, 381);
            this.labelYearGradFrom.Name = "labelYearGradFrom";
            this.labelYearGradFrom.Size = new System.Drawing.Size(165, 36);
            this.labelYearGradFrom.TabIndex = 10;
            this.labelYearGradFrom.Text = "Год окончания";
            this.labelYearGradFrom.Visible = false;
            // 
            // buttonCalculateGradYear
            // 
            this.buttonCalculateGradYear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculateGradYear.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculateGradYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalculateGradYear.Location = new System.Drawing.Point(578, 455);
            this.buttonCalculateGradYear.Name = "buttonCalculateGradYear";
            this.buttonCalculateGradYear.Size = new System.Drawing.Size(210, 45);
            this.buttonCalculateGradYear.TabIndex = 11;
            this.buttonCalculateGradYear.Text = "Вычислить год окончания";
            this.buttonCalculateGradYear.UseVisualStyleBackColor = false;
            this.buttonCalculateGradYear.Visible = false;
            this.buttonCalculateGradYear.Click += new System.EventHandler(this.buttonCalcYear_Click);
            // 
            // buttonYearIn
            // 
            this.buttonYearIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonYearIn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonYearIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonYearIn.Location = new System.Drawing.Point(40, 455);
            this.buttonYearIn.Name = "buttonYearIn";
            this.buttonYearIn.Size = new System.Drawing.Size(210, 45);
            this.buttonYearIn.TabIndex = 12;
            this.buttonYearIn.Text = "Ввести год поступления";
            this.buttonYearIn.UseVisualStyleBackColor = false;
            this.buttonYearIn.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(315, 455);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(210, 45);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить даты";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClearYear_Click);
            // 
            // FormTMP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(973, 529);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonYearIn);
            this.Controls.Add(this.buttonCalculateGradYear);
            this.Controls.Add(this.labelYearGradFrom);
            this.Controls.Add(this.labelYearIn);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.buttonShowHidden);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelProfs);
            this.Controls.Add(this.labelTSU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBackToForm1);
            this.Name = "FormTMP2";
            this.Text = "Логотип вуза";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBackToForm1;
        private PictureBox pictureBox1;
        private Label labelTSU;
        private Label labelProfs;
        private Button buttonClose;
        private Button buttonShowHidden;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Label labelYearIn;
        private Label labelYearGradFrom;
        private Button buttonCalculateGradYear;
        private Button buttonYearIn;
        private Button buttonClear;
    }
}