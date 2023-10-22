using System.Data;

namespace BooleanAlgebra
{
    partial class Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dgvTruthTable = new System.Windows.Forms.DataGridView();
            this.calculateButton = new System.Windows.Forms.Button();
            this.formulaTextBox = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruthTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTruthTable
            // 
            this.dgvTruthTable.AllowUserToAddRows = false;
            this.dgvTruthTable.AllowUserToDeleteRows = false;
            this.dgvTruthTable.AllowUserToResizeColumns = false;
            this.dgvTruthTable.AllowUserToResizeRows = false;
            this.dgvTruthTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTruthTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTruthTable.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvTruthTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTruthTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTruthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTruthTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTruthTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTruthTable.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTruthTable.Location = new System.Drawing.Point(286, 25);
            this.dgvTruthTable.Name = "dgvTruthTable";
            this.dgvTruthTable.ReadOnly = true;
            this.dgvTruthTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTruthTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTruthTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTruthTable.RowTemplate.Height = 31;
            this.dgvTruthTable.ShowCellErrors = false;
            this.dgvTruthTable.ShowCellToolTips = false;
            this.dgvTruthTable.ShowEditingIcon = false;
            this.dgvTruthTable.ShowRowErrors = false;
            this.dgvTruthTable.Size = new System.Drawing.Size(478, 348);
            this.dgvTruthTable.StandardTab = true;
            this.dgvTruthTable.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(22, 337);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 36);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateClickEventHandler);
            // 
            // formulaTextBox
            // 
            this.formulaTextBox.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formulaTextBox.Location = new System.Drawing.Point(22, 302);
            this.formulaTextBox.Name = "formulaTextBox";
            this.formulaTextBox.Size = new System.Drawing.Size(200, 29);
            this.formulaTextBox.TabIndex = 0;
            this.formulaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculateButton_KeyPress);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLabel.Location = new System.Drawing.Point(22, 274);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(173, 25);
            this.textBoxLabel.TabIndex = 3;
            this.textBoxLabel.Text = "Write the formula:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(22, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 205);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Disjunction is \"+\"\r\nConjunction is \"*\"\r\nNegation is \"!\"\r\nEquivalence is \"~\"\r\nImpl" +
    "ication is\">\" or \"<\"\r\nSymmetric difference is \"^\"\r\nSheffer function is \"|\"\r\nPeir" +
    "ce function is \"↓\"";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvTruthTable);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.formulaTextBox);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Boolean Algebra Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruthTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvTruthTable;
        private Button calculateButton;
        public TextBox formulaTextBox;
        private Label textBoxLabel;
        private TextBox textBox1;
    }
}