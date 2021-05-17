
namespace TiK_LR__6
{
    partial class Form1
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
            this.message16_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculatedCRC_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.message2_textBox = new System.Windows.Forms.TextBox();
            this.CalculateCRC_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckData_button = new System.Windows.Forms.Button();
            this.InputCRC_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageForCheck_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // message16_textBox
            // 
            this.message16_textBox.Location = new System.Drawing.Point(92, 40);
            this.message16_textBox.Name = "message16_textBox";
            this.message16_textBox.Size = new System.Drawing.Size(273, 20);
            this.message16_textBox.TabIndex = 0;
            this.message16_textBox.Text = "4e 61 6e 67";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входные данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CRC:";
            // 
            // CalculatedCRC_textBox
            // 
            this.CalculatedCRC_textBox.Location = new System.Drawing.Point(92, 140);
            this.CalculatedCRC_textBox.Name = "CalculatedCRC_textBox";
            this.CalculatedCRC_textBox.Size = new System.Drawing.Size(273, 20);
            this.CalculatedCRC_textBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.message2_textBox);
            this.groupBox1.Controls.Add(this.CalculateCRC_button);
            this.groupBox1.Controls.Add(this.CalculatedCRC_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.message16_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вычисление CRC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Base:  2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(45, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "16";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Base:  2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Base:";
            // 
            // message2_textBox
            // 
            this.message2_textBox.Location = new System.Drawing.Point(92, 66);
            this.message2_textBox.Name = "message2_textBox";
            this.message2_textBox.ReadOnly = true;
            this.message2_textBox.Size = new System.Drawing.Size(273, 20);
            this.message2_textBox.TabIndex = 5;
            // 
            // CalculateCRC_button
            // 
            this.CalculateCRC_button.Location = new System.Drawing.Point(158, 92);
            this.CalculateCRC_button.Name = "CalculateCRC_button";
            this.CalculateCRC_button.Size = new System.Drawing.Size(111, 23);
            this.CalculateCRC_button.TabIndex = 4;
            this.CalculateCRC_button.Text = "Вычислить CRC";
            this.CalculateCRC_button.UseVisualStyleBackColor = true;
            this.CalculateCRC_button.Click += new System.EventHandler(this.CalculateCRC_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CheckResultLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CheckData_button);
            this.groupBox2.Controls.Add(this.InputCRC_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.messageForCheck_textBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(403, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Проверка данных";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(51, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(41, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Base:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Base: 2";
            // 
            // CheckResultLabel
            // 
            this.CheckResultLabel.AutoSize = true;
            this.CheckResultLabel.Location = new System.Drawing.Point(11, 156);
            this.CheckResultLabel.Name = "CheckResultLabel";
            this.CheckResultLabel.Size = new System.Drawing.Size(0, 13);
            this.CheckResultLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результат:";
            // 
            // CheckData_button
            // 
            this.CheckData_button.Location = new System.Drawing.Point(164, 108);
            this.CheckData_button.Name = "CheckData_button";
            this.CheckData_button.Size = new System.Drawing.Size(111, 23);
            this.CheckData_button.TabIndex = 5;
            this.CheckData_button.Text = "Проверить";
            this.CheckData_button.UseVisualStyleBackColor = true;
            this.CheckData_button.Click += new System.EventHandler(this.CheckData_button_Click);
            // 
            // InputCRC_textBox
            // 
            this.InputCRC_textBox.Location = new System.Drawing.Point(97, 41);
            this.InputCRC_textBox.Name = "InputCRC_textBox";
            this.InputCRC_textBox.ReadOnly = true;
            this.InputCRC_textBox.Size = new System.Drawing.Size(271, 20);
            this.InputCRC_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CRC:";
            // 
            // messageForCheck_textBox
            // 
            this.messageForCheck_textBox.Location = new System.Drawing.Point(97, 82);
            this.messageForCheck_textBox.Name = "messageForCheck_textBox";
            this.messageForCheck_textBox.Size = new System.Drawing.Size(271, 20);
            this.messageForCheck_textBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Входные данные:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox message16_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CalculatedCRC_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalculateCRC_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CheckResultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CheckData_button;
        private System.Windows.Forms.TextBox InputCRC_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageForCheck_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox message2_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

