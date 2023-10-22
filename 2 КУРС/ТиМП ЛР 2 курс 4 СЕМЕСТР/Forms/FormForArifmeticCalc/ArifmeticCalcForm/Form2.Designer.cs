using System.Collections.Generic;

namespace StudentsInfo
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.studentBox = new System.Windows.Forms.ListBox();
            this.optionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Вывод всех данных в Exel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.outputInExel);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(48, 40);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(103, 25);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Фамилия";
            // 
            // studentBox
            // 
            this.studentBox.FormattingEnabled = true;
            this.studentBox.ItemHeight = 16;
            this.studentBox.Items.AddRange(new object[] {
            "Булочкин Игорь Михайлович",
            "Котиков Михаил Юрьевич",
            "Бублик Александр Сергеевич",
            "Яблочков Валерий Ярославович",
            "Кексик Мария Сергеевна"});
            this.studentBox.Location = new System.Drawing.Point(53, 79);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(255, 84);
            this.studentBox.TabIndex = 7;
            // 
            // optionBox
            // 
            this.optionBox.FormattingEnabled = true;
            this.optionBox.Items.AddRange(new object[] {
            "Общая информация",
            "Успеваемость"});
            this.optionBox.Location = new System.Drawing.Point(53, 219);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(255, 24);
            this.optionBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(377, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Действие";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Показать данные о студенте";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showStudentInfoOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Открыть список всех студентов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.showAllStudentsOnClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "StudentsInfo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.ListBox studentBox;
        private System.Windows.Forms.ComboBox optionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

