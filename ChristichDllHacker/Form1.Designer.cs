namespace ChristichDllHacker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.OutputString = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.InputFile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вводишь какую-то дичь типа \"shell32.dll\" и 30596 и тычешь сюды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputString
            // 
            this.OutputString.Location = new System.Drawing.Point(12, 93);
            this.OutputString.Name = "OutputString";
            this.OutputString.Size = new System.Drawing.Size(400, 20);
            this.OutputString.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Тыкаешь сюда для быстрого копирования результата";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(12, 12);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(300, 20);
            this.InputFile.TabIndex = 0;
            this.InputFile.Tag = "";
            this.InputFile.Text = "shell32.dll";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Обзор...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InputNumber
            // 
            this.InputNumber.Location = new System.Drawing.Point(12, 38);
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(400, 20);
            this.InputNumber.TabIndex = 6;
            this.InputNumber.Tag = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 154);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OutputString);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DllStringExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputString;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InputFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox InputNumber;
    }
}

