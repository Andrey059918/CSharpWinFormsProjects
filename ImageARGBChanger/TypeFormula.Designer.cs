namespace ImageARGBChanger
{
    partial class TypeFormula
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FormulaA = new System.Windows.Forms.TextBox();
            this.FormulaR = new System.Windows.Forms.TextBox();
            this.FormulaG = new System.Windows.Forms.TextBox();
            this.FormulaB = new System.Windows.Forms.TextBox();
            this.ResetA = new System.Windows.Forms.Button();
            this.ResetR = new System.Windows.Forms.Button();
            this.ResetG = new System.Windows.Forms.Button();
            this.ResetB = new System.Windows.Forms.Button();
            this.ElementsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ElementsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 138);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(150, 24);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(194, 138);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 24);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormulaA
            // 
            this.FormulaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormulaA.ForeColor = System.Drawing.Color.DarkGray;
            this.FormulaA.Location = new System.Drawing.Point(3, 3);
            this.FormulaA.Name = "FormulaA";
            this.FormulaA.Size = new System.Drawing.Size(250, 24);
            this.FormulaA.TabIndex = 3;
            this.FormulaA.Tag = "Введите формулы для ARGB:";
            this.FormulaA.Text = "Введите формулы для ARGB:";
            this.FormulaA.Click += new System.EventHandler(this.FormulaBox_Click);
            this.FormulaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormulaBox_KeyPress);
            // 
            // FormulaR
            // 
            this.FormulaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormulaR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormulaR.Location = new System.Drawing.Point(3, 33);
            this.FormulaR.Name = "FormulaR";
            this.FormulaR.Size = new System.Drawing.Size(250, 24);
            this.FormulaR.TabIndex = 4;
            this.FormulaR.Tag = "Разрешены: 0-255; A R G B; + - * /";
            this.FormulaR.Text = "Разрешены: 0-255; A R G B; + - * /";
            this.FormulaR.Click += new System.EventHandler(this.FormulaBox_Click);
            this.FormulaR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormulaBox_KeyPress);
            // 
            // FormulaG
            // 
            this.FormulaG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormulaG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormulaG.Location = new System.Drawing.Point(3, 63);
            this.FormulaG.Name = "FormulaG";
            this.FormulaG.Size = new System.Drawing.Size(250, 24);
            this.FormulaG.TabIndex = 5;
            this.FormulaG.Tag = "Пример: 19/75R+200-0,57G";
            this.FormulaG.Text = "Пример: 19/75R+200-0,57G";
            this.FormulaG.Click += new System.EventHandler(this.FormulaBox_Click);
            this.FormulaG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormulaBox_KeyPress);
            // 
            // FormulaB
            // 
            this.FormulaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormulaB.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormulaB.Location = new System.Drawing.Point(3, 93);
            this.FormulaB.Name = "FormulaB";
            this.FormulaB.Size = new System.Drawing.Size(250, 24);
            this.FormulaB.TabIndex = 6;
            this.FormulaB.Tag = "Пустое поле - не изменять цвет";
            this.FormulaB.Text = "Пустое поле - не изменять цвет";
            this.FormulaB.Click += new System.EventHandler(this.FormulaBox_Click);
            this.FormulaB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormulaBox_KeyPress);
            // 
            // ResetA
            // 
            this.ResetA.Location = new System.Drawing.Point(259, 3);
            this.ResetA.Name = "ResetA";
            this.ResetA.Size = new System.Drawing.Size(70, 24);
            this.ResetA.TabIndex = 7;
            this.ResetA.Text = "Сброс";
            this.ResetA.UseVisualStyleBackColor = true;
            this.ResetA.Click += new System.EventHandler(this.FormulaReset_Click);
            // 
            // ResetR
            // 
            this.ResetR.Location = new System.Drawing.Point(259, 33);
            this.ResetR.Name = "ResetR";
            this.ResetR.Size = new System.Drawing.Size(70, 24);
            this.ResetR.TabIndex = 8;
            this.ResetR.Text = "Сброс";
            this.ResetR.UseVisualStyleBackColor = true;
            this.ResetR.Click += new System.EventHandler(this.FormulaReset_Click);
            // 
            // ResetG
            // 
            this.ResetG.Location = new System.Drawing.Point(259, 63);
            this.ResetG.Name = "ResetG";
            this.ResetG.Size = new System.Drawing.Size(70, 24);
            this.ResetG.TabIndex = 9;
            this.ResetG.Text = "Сброс";
            this.ResetG.UseVisualStyleBackColor = true;
            this.ResetG.Click += new System.EventHandler(this.FormulaReset_Click);
            // 
            // ResetB
            // 
            this.ResetB.Location = new System.Drawing.Point(259, 93);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(70, 24);
            this.ResetB.TabIndex = 10;
            this.ResetB.Text = "Сброс";
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.FormulaReset_Click);
            // 
            // ElementsTable
            // 
            this.ElementsTable.AutoSize = true;
            this.ElementsTable.ColumnCount = 2;
            this.ElementsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ElementsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ElementsTable.Controls.Add(this.FormulaA, 0, 0);
            this.ElementsTable.Controls.Add(this.ResetB, 1, 3);
            this.ElementsTable.Controls.Add(this.FormulaR, 0, 1);
            this.ElementsTable.Controls.Add(this.ResetG, 1, 2);
            this.ElementsTable.Controls.Add(this.FormulaG, 0, 2);
            this.ElementsTable.Controls.Add(this.ResetR, 1, 1);
            this.ElementsTable.Controls.Add(this.FormulaB, 0, 3);
            this.ElementsTable.Controls.Add(this.ResetA, 1, 0);
            this.ElementsTable.Location = new System.Drawing.Point(12, 12);
            this.ElementsTable.Name = "ElementsTable";
            this.ElementsTable.RowCount = 4;
            this.ElementsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ElementsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ElementsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ElementsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ElementsTable.Size = new System.Drawing.Size(332, 120);
            this.ElementsTable.TabIndex = 11;
            // 
            // TypeFormula
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(356, 174);
            this.Controls.Add(this.ElementsTable);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "TypeFormula";
            this.Text = "TypeFormula";
            this.ElementsTable.ResumeLayout(false);
            this.ElementsTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox FormulaA;
        private System.Windows.Forms.TextBox FormulaR;
        private System.Windows.Forms.TextBox FormulaG;
        private System.Windows.Forms.TextBox FormulaB;
        private System.Windows.Forms.Button ResetA;
        private System.Windows.Forms.Button ResetR;
        private System.Windows.Forms.Button ResetG;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.TableLayoutPanel ElementsTable;
    }
}