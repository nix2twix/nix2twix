namespace CalculatorMathPIForm
{
    partial class MathPI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegularPI = new System.Windows.Forms.TextBox();
            this.textBoxRoundPI = new System.Windows.Forms.TextBox();
            this.textBoxDoublePI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вычислить с обычной точностью";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вычислить с двойной точностью";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Вычислить с округлением";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число PI с одинарной точностью";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число PI с двойной точностью";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Число PI с округлением до 5 знаков";
            this.label3.UseMnemonic = false;
            // 
            // textBoxRegularPI
            // 
            this.textBoxRegularPI.Location = new System.Drawing.Point(306, 72);
            this.textBoxRegularPI.Name = "textBoxRegularPI";
            this.textBoxRegularPI.Size = new System.Drawing.Size(121, 22);
            this.textBoxRegularPI.TabIndex = 7;
            // 
            // textBoxRoundPI
            // 
            this.textBoxRoundPI.Location = new System.Drawing.Point(306, 236);
            this.textBoxRoundPI.Name = "textBoxRoundPI";
            this.textBoxRoundPI.Size = new System.Drawing.Size(121, 22);
            this.textBoxRoundPI.TabIndex = 8;
            // 
            // textBoxDoublePI
            // 
            this.textBoxDoublePI.Location = new System.Drawing.Point(306, 154);
            this.textBoxDoublePI.Name = "textBoxDoublePI";
            this.textBoxDoublePI.Size = new System.Drawing.Size(121, 22);
            this.textBoxDoublePI.TabIndex = 9;
            // 
            // MathPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDoublePI);
            this.Controls.Add(this.textBoxRoundPI);
            this.Controls.Add(this.textBoxRegularPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MathPI";
            this.Text = "MathPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegularPI;
        private System.Windows.Forms.TextBox textBoxRoundPI;
        private System.Windows.Forms.TextBox textBoxDoublePI;
    }
}

