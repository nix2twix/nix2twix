namespace Calculator
{
    partial class Form
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

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.powButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.textBar = new System.Windows.Forms.TextBox();
            this.simpleLabel = new System.Windows.Forms.Label();
            this.equalButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(106, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonOnClick);
            // 
            // multipleButton
            // 
            this.multipleButton.Location = new System.Drawing.Point(206, 102);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(75, 23);
            this.multipleButton.TabIndex = 1;
            this.multipleButton.Text = "*";
            this.multipleButton.UseVisualStyleBackColor = true;
            this.multipleButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(106, 144);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(206, 144);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // powButton
            // 
            this.powButton.Location = new System.Drawing.Point(106, 186);
            this.powButton.Name = "powButton";
            this.powButton.Size = new System.Drawing.Size(75, 23);
            this.powButton.TabIndex = 4;
            this.powButton.Text = "Pow";
            this.powButton.UseVisualStyleBackColor = true;
            this.powButton.Click += new System.EventHandler(this.powButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(206, 186);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(75, 23);
            this.sqrtButton.TabIndex = 8;
            this.sqrtButton.Text = "Sqrt";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // textBar
            // 
            this.textBar.Location = new System.Drawing.Point(106, 48);
            this.textBar.Name = "textBar";
            this.textBar.Size = new System.Drawing.Size(275, 22);
            this.textBar.TabIndex = 5;
            this.textBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBar_KeyDown);
            // 
            // simpleLabel
            // 
            this.simpleLabel.AutoSize = true;
            this.simpleLabel.Location = new System.Drawing.Point(31, 105);
            this.simpleLabel.Name = "simpleLabel";
            this.simpleLabel.Size = new System.Drawing.Size(49, 16);
            this.simpleLabel.TabIndex = 6;
            this.simpleLabel.Text = "Simple";
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(306, 102);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 23);
            this.equalButton.TabIndex = 9;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clearButtonOnClick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.simpleLabel);
            this.Controls.Add(this.textBar);
            this.Controls.Add(this.powButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multipleButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button powButton;
        private System.Windows.Forms.TextBox textBar;
        private System.Windows.Forms.Label simpleLabel;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button button2;
    }
}

