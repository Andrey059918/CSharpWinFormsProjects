namespace ImageARGBChanger
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
            this._PanelImageSource = new System.Windows.Forms.FlowLayoutPanel();
            this._PanelInfo = new System.Windows.Forms.RichTextBox();
            this._PSC_ColorAlpha = new System.Windows.Forms.TextBox();
            this._PSC_ColorRed = new System.Windows.Forms.TextBox();
            this._PSC_ColorGreen = new System.Windows.Forms.TextBox();
            this._PSC_ColorBlue = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this._PSC_CycleAlpha = new System.Windows.Forms.NumericUpDown();
            this._PSC_CycleRed = new System.Windows.Forms.NumericUpDown();
            this._PSC_CycleGreen = new System.Windows.Forms.NumericUpDown();
            this._PSC_CycleBlue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._PanelSettingsColors = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._PSC_ColorHelp = new System.Windows.Forms.Label();
            this._PanelSettingsOutput = new System.Windows.Forms.Panel();
            this._PSO_OutToggle = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._PSO_OutHelp = new System.Windows.Forms.Label();
            this._PSO_OutFolder = new System.Windows.Forms.Button();
            this._PSO_OutMask = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this._PanelToolBar = new System.Windows.Forms.Panel();
            this._PTB_SaveFiles = new System.Windows.Forms.Button();
            this._PTB_ProcessImages = new System.Windows.Forms.Button();
            this._PTB_OpenFolders = new System.Windows.Forms.Button();
            this._PTB_OpenFiles = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this._PanelImageResult = new System.Windows.Forms.FlowLayoutPanel();
            this._ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleBlue)).BeginInit();
            this._PanelSettingsColors.SuspendLayout();
            this._PanelSettingsOutput.SuspendLayout();
            this._PanelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _PanelImageSource
            // 
            this._PanelImageSource.AutoScroll = true;
            this._PanelImageSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PanelImageSource.Location = new System.Drawing.Point(0, 0);
            this._PanelImageSource.Margin = new System.Windows.Forms.Padding(0);
            this._PanelImageSource.Name = "_PanelImageSource";
            this._PanelImageSource.Size = new System.Drawing.Size(200, 400);
            this._PanelImageSource.TabIndex = 0;
            // 
            // _PanelInfo
            // 
            this._PanelInfo.Location = new System.Drawing.Point(0, 400);
            this._PanelInfo.Margin = new System.Windows.Forms.Padding(0);
            this._PanelInfo.Name = "_PanelInfo";
            this._PanelInfo.Size = new System.Drawing.Size(800, 200);
            this._PanelInfo.TabIndex = 1;
            this._PanelInfo.Text = "";
            // 
            // _PSC_ColorAlpha
            // 
            this._PSC_ColorAlpha.Location = new System.Drawing.Point(10, 30);
            this._PSC_ColorAlpha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this._PSC_ColorAlpha.Name = "_PSC_ColorAlpha";
            this._PSC_ColorAlpha.Size = new System.Drawing.Size(270, 20);
            this._PSC_ColorAlpha.TabIndex = 2;
            this._PSC_ColorAlpha.Text = "A";
            // 
            // _PSC_ColorRed
            // 
            this._PSC_ColorRed.Location = new System.Drawing.Point(10, 55);
            this._PSC_ColorRed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this._PSC_ColorRed.Name = "_PSC_ColorRed";
            this._PSC_ColorRed.Size = new System.Drawing.Size(270, 20);
            this._PSC_ColorRed.TabIndex = 3;
            this._PSC_ColorRed.Text = "R";
            // 
            // _PSC_ColorGreen
            // 
            this._PSC_ColorGreen.Location = new System.Drawing.Point(10, 80);
            this._PSC_ColorGreen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this._PSC_ColorGreen.Name = "_PSC_ColorGreen";
            this._PSC_ColorGreen.Size = new System.Drawing.Size(270, 20);
            this._PSC_ColorGreen.TabIndex = 4;
            this._PSC_ColorGreen.Text = "G";
            // 
            // _PSC_ColorBlue
            // 
            this._PSC_ColorBlue.Location = new System.Drawing.Point(10, 105);
            this._PSC_ColorBlue.Margin = new System.Windows.Forms.Padding(5);
            this._PSC_ColorBlue.Name = "_PSC_ColorBlue";
            this._PSC_ColorBlue.Size = new System.Drawing.Size(270, 20);
            this._PSC_ColorBlue.TabIndex = 5;
            this._PSC_ColorBlue.Text = "B";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(412, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 20);
            this.textBox5.TabIndex = 6;
            // 
            // _PSC_CycleAlpha
            // 
            this._PSC_CycleAlpha.Location = new System.Drawing.Point(290, 30);
            this._PSC_CycleAlpha.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this._PSC_CycleAlpha.Name = "_PSC_CycleAlpha";
            this._PSC_CycleAlpha.Size = new System.Drawing.Size(100, 20);
            this._PSC_CycleAlpha.TabIndex = 7;
            this._PSC_CycleAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _PSC_CycleRed
            // 
            this._PSC_CycleRed.Location = new System.Drawing.Point(290, 55);
            this._PSC_CycleRed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this._PSC_CycleRed.Name = "_PSC_CycleRed";
            this._PSC_CycleRed.Size = new System.Drawing.Size(100, 20);
            this._PSC_CycleRed.TabIndex = 8;
            this._PSC_CycleRed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _PSC_CycleGreen
            // 
            this._PSC_CycleGreen.Location = new System.Drawing.Point(290, 80);
            this._PSC_CycleGreen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this._PSC_CycleGreen.Name = "_PSC_CycleGreen";
            this._PSC_CycleGreen.Size = new System.Drawing.Size(100, 20);
            this._PSC_CycleGreen.TabIndex = 9;
            this._PSC_CycleGreen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _PSC_CycleBlue
            // 
            this._PSC_CycleBlue.Location = new System.Drawing.Point(290, 105);
            this._PSC_CycleBlue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this._PSC_CycleBlue.Name = "_PSC_CycleBlue";
            this._PSC_CycleBlue.Size = new System.Drawing.Size(100, 20);
            this._PSC_CycleBlue.TabIndex = 10;
            this._PSC_CycleBlue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Параметры преобразования цветов";
            // 
            // _PanelSettingsColors
            // 
            this._PanelSettingsColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PanelSettingsColors.Controls.Add(this.label2);
            this._PanelSettingsColors.Controls.Add(this._PSC_ColorHelp);
            this._PanelSettingsColors.Controls.Add(this.label1);
            this._PanelSettingsColors.Controls.Add(this._PSC_CycleBlue);
            this._PanelSettingsColors.Controls.Add(this._PSC_ColorAlpha);
            this._PanelSettingsColors.Controls.Add(this._PSC_CycleGreen);
            this._PanelSettingsColors.Controls.Add(this._PSC_ColorRed);
            this._PanelSettingsColors.Controls.Add(this._PSC_CycleRed);
            this._PanelSettingsColors.Controls.Add(this._PSC_ColorGreen);
            this._PanelSettingsColors.Controls.Add(this._PSC_CycleAlpha);
            this._PanelSettingsColors.Controls.Add(this._PSC_ColorBlue);
            this._PanelSettingsColors.Controls.Add(this.textBox5);
            this._PanelSettingsColors.Location = new System.Drawing.Point(200, 0);
            this._PanelSettingsColors.Margin = new System.Windows.Forms.Padding(0);
            this._PanelSettingsColors.Name = "_PanelSettingsColors";
            this._PanelSettingsColors.Padding = new System.Windows.Forms.Padding(5);
            this._PanelSettingsColors.Size = new System.Drawing.Size(400, 155);
            this._PanelSettingsColors.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "В цикле";
            // 
            // _PSC_ColorHelp
            // 
            this._PSC_ColorHelp.AutoSize = true;
            this._PSC_ColorHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._PSC_ColorHelp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._PSC_ColorHelp.Location = new System.Drawing.Point(10, 130);
            this._PSC_ColorHelp.Margin = new System.Windows.Forms.Padding(5);
            this._PSC_ColorHelp.Name = "_PSC_ColorHelp";
            this._PSC_ColorHelp.Size = new System.Drawing.Size(233, 16);
            this._PSC_ColorHelp.TabIndex = 13;
            this._PSC_ColorHelp.Text = "Помощь по настройке параметров";
            // 
            // _PanelSettingsOutput
            // 
            this._PanelSettingsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PanelSettingsOutput.Controls.Add(this._PSO_OutToggle);
            this._PanelSettingsOutput.Controls.Add(this.label5);
            this._PanelSettingsOutput.Controls.Add(this.label4);
            this._PanelSettingsOutput.Controls.Add(this._PSO_OutHelp);
            this._PanelSettingsOutput.Controls.Add(this._PSO_OutFolder);
            this._PanelSettingsOutput.Controls.Add(this._PSO_OutMask);
            this._PanelSettingsOutput.Controls.Add(this.textBox10);
            this._PanelSettingsOutput.Location = new System.Drawing.Point(200, 155);
            this._PanelSettingsOutput.Margin = new System.Windows.Forms.Padding(0);
            this._PanelSettingsOutput.Name = "_PanelSettingsOutput";
            this._PanelSettingsOutput.Padding = new System.Windows.Forms.Padding(5);
            this._PanelSettingsOutput.Size = new System.Drawing.Size(400, 155);
            this._PanelSettingsOutput.TabIndex = 13;
            // 
            // _PSO_OutToggle
            // 
            this._PSO_OutToggle.AutoSize = true;
            this._PSO_OutToggle.Checked = true;
            this._PSO_OutToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this._PSO_OutToggle.Location = new System.Drawing.Point(10, 60);
            this._PSO_OutToggle.Margin = new System.Windows.Forms.Padding(5);
            this._PSO_OutToggle.Name = "_PSO_OutToggle";
            this._PSO_OutToggle.Size = new System.Drawing.Size(257, 17);
            this._PSO_OutToggle.TabIndex = 14;
            this._PSO_OutToggle.Text = "Каждое изображение в свою исходную папку";
            this._PSO_OutToggle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Маска имени файлов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выходная папка изображений";
            // 
            // _PSO_OutHelp
            // 
            this._PSO_OutHelp.AutoSize = true;
            this._PSO_OutHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._PSO_OutHelp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._PSO_OutHelp.Location = new System.Drawing.Point(10, 130);
            this._PSO_OutHelp.Margin = new System.Windows.Forms.Padding(5);
            this._PSO_OutHelp.Name = "_PSO_OutHelp";
            this._PSO_OutHelp.Size = new System.Drawing.Size(246, 16);
            this._PSO_OutHelp.TabIndex = 14;
            this._PSO_OutHelp.Text = "Помощь по маскам и доступные теги";
            // 
            // _PSO_OutFolder
            // 
            this._PSO_OutFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._PSO_OutFolder.Location = new System.Drawing.Point(10, 30);
            this._PSO_OutFolder.Margin = new System.Windows.Forms.Padding(5);
            this._PSO_OutFolder.Name = "_PSO_OutFolder";
            this._PSO_OutFolder.Size = new System.Drawing.Size(380, 25);
            this._PSO_OutFolder.TabIndex = 17;
            this._PSO_OutFolder.UseVisualStyleBackColor = true;
            this._PSO_OutFolder.Click += new System.EventHandler(this._PSO_OutFolder_Click);
            // 
            // _PSO_OutMask
            // 
            this._PSO_OutMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._PSO_OutMask.Location = new System.Drawing.Point(10, 105);
            this._PSO_OutMask.Margin = new System.Windows.Forms.Padding(5);
            this._PSO_OutMask.Name = "_PSO_OutMask";
            this._PSO_OutMask.Size = new System.Drawing.Size(380, 22);
            this._PSO_OutMask.TabIndex = 13;
            this._PSO_OutMask.Text = "%NEdited";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(311, 74);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(0, 20);
            this.textBox10.TabIndex = 6;
            // 
            // _PanelToolBar
            // 
            this._PanelToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PanelToolBar.Controls.Add(this._PTB_SaveFiles);
            this._PanelToolBar.Controls.Add(this._PTB_ProcessImages);
            this._PanelToolBar.Controls.Add(this._PTB_OpenFolders);
            this._PanelToolBar.Controls.Add(this._PTB_OpenFiles);
            this._PanelToolBar.Controls.Add(this.textBox8);
            this._PanelToolBar.Location = new System.Drawing.Point(200, 310);
            this._PanelToolBar.Margin = new System.Windows.Forms.Padding(0);
            this._PanelToolBar.Name = "_PanelToolBar";
            this._PanelToolBar.Padding = new System.Windows.Forms.Padding(5);
            this._PanelToolBar.Size = new System.Drawing.Size(400, 90);
            this._PanelToolBar.TabIndex = 18;
            // 
            // _PTB_SaveFiles
            // 
            this._PTB_SaveFiles.BackgroundImage = global::ImageARGBChanger.Properties.Resources.SaveFileIcon;
            this._PTB_SaveFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._PTB_SaveFiles.Location = new System.Drawing.Point(320, 10);
            this._PTB_SaveFiles.Margin = new System.Windows.Forms.Padding(5);
            this._PTB_SaveFiles.Name = "_PTB_SaveFiles";
            this._PTB_SaveFiles.Size = new System.Drawing.Size(70, 70);
            this._PTB_SaveFiles.TabIndex = 10;
            this._PTB_SaveFiles.UseVisualStyleBackColor = true;
            this._PTB_SaveFiles.Click += new System.EventHandler(this._PTB_SaveFiles_Click);
            // 
            // _PTB_ProcessImages
            // 
            this._PTB_ProcessImages.BackgroundImage = global::ImageARGBChanger.Properties.Resources.ProcessImageIcon;
            this._PTB_ProcessImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._PTB_ProcessImages.Location = new System.Drawing.Point(240, 10);
            this._PTB_ProcessImages.Margin = new System.Windows.Forms.Padding(5);
            this._PTB_ProcessImages.Name = "_PTB_ProcessImages";
            this._PTB_ProcessImages.Size = new System.Drawing.Size(70, 70);
            this._PTB_ProcessImages.TabIndex = 9;
            this._PTB_ProcessImages.UseVisualStyleBackColor = true;
            this._PTB_ProcessImages.Click += new System.EventHandler(this._PTB_ProcessImages_Click);
            // 
            // _PTB_OpenFolders
            // 
            this._PTB_OpenFolders.BackgroundImage = global::ImageARGBChanger.Properties.Resources.OpenFolderIcon;
            this._PTB_OpenFolders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._PTB_OpenFolders.Location = new System.Drawing.Point(90, 10);
            this._PTB_OpenFolders.Margin = new System.Windows.Forms.Padding(5);
            this._PTB_OpenFolders.Name = "_PTB_OpenFolders";
            this._PTB_OpenFolders.Size = new System.Drawing.Size(70, 70);
            this._PTB_OpenFolders.TabIndex = 8;
            this._PTB_OpenFolders.UseVisualStyleBackColor = true;
            this._PTB_OpenFolders.Click += new System.EventHandler(this._PTB_OpenFolders_Click);
            // 
            // _PTB_OpenFiles
            // 
            this._PTB_OpenFiles.BackgroundImage = global::ImageARGBChanger.Properties.Resources.OpenFileIcon;
            this._PTB_OpenFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._PTB_OpenFiles.Location = new System.Drawing.Point(10, 10);
            this._PTB_OpenFiles.Margin = new System.Windows.Forms.Padding(5);
            this._PTB_OpenFiles.Name = "_PTB_OpenFiles";
            this._PTB_OpenFiles.Size = new System.Drawing.Size(70, 70);
            this._PTB_OpenFiles.TabIndex = 7;
            this._PTB_OpenFiles.Click += new System.EventHandler(this._PTB_OpenFiles_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(311, 74);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(0, 20);
            this.textBox8.TabIndex = 6;
            // 
            // _PanelImageResult
            // 
            this._PanelImageResult.AutoScroll = true;
            this._PanelImageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PanelImageResult.Location = new System.Drawing.Point(600, 0);
            this._PanelImageResult.Margin = new System.Windows.Forms.Padding(0);
            this._PanelImageResult.Name = "_PanelImageResult";
            this._PanelImageResult.Size = new System.Drawing.Size(200, 400);
            this._PanelImageResult.TabIndex = 1;
            // 
            // _ProgressBar
            // 
            this._ProgressBar.Location = new System.Drawing.Point(0, 600);
            this._ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this._ProgressBar.Name = "_ProgressBar";
            this._ProgressBar.Size = new System.Drawing.Size(800, 30);
            this._ProgressBar.Step = 1;
            this._ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._ProgressBar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this._ProgressBar);
            this.Controls.Add(this._PanelImageResult);
            this.Controls.Add(this._PanelToolBar);
            this.Controls.Add(this._PanelSettingsOutput);
            this.Controls.Add(this._PanelSettingsColors);
            this.Controls.Add(this._PanelInfo);
            this.Controls.Add(this._PanelImageSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PSC_CycleBlue)).EndInit();
            this._PanelSettingsColors.ResumeLayout(false);
            this._PanelSettingsColors.PerformLayout();
            this._PanelSettingsOutput.ResumeLayout(false);
            this._PanelSettingsOutput.PerformLayout();
            this._PanelToolBar.ResumeLayout(false);
            this._PanelToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _PanelImageSource;
        private System.Windows.Forms.RichTextBox _PanelInfo;
        private System.Windows.Forms.TextBox _PSC_ColorAlpha;
        private System.Windows.Forms.TextBox _PSC_ColorRed;
        private System.Windows.Forms.TextBox _PSC_ColorGreen;
        private System.Windows.Forms.TextBox _PSC_ColorBlue;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown _PSC_CycleAlpha;
        private System.Windows.Forms.NumericUpDown _PSC_CycleRed;
        private System.Windows.Forms.NumericUpDown _PSC_CycleGreen;
        private System.Windows.Forms.NumericUpDown _PSC_CycleBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _PanelSettingsColors;
        private System.Windows.Forms.Panel _PanelSettingsOutput;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button _PSO_OutFolder;
        private System.Windows.Forms.TextBox _PSO_OutMask;
        private System.Windows.Forms.Label _PSC_ColorHelp;
        private System.Windows.Forms.CheckBox _PSO_OutToggle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _PSO_OutHelp;
        private System.Windows.Forms.Panel _PanelToolBar;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.FlowLayoutPanel _PanelImageResult;
        private System.Windows.Forms.Button _PTB_SaveFiles;
        private System.Windows.Forms.Button _PTB_ProcessImages;
        private System.Windows.Forms.Button _PTB_OpenFolders;
        private System.Windows.Forms.Button _PTB_OpenFiles;
        private System.Windows.Forms.ProgressBar _ProgressBar;
        private System.Windows.Forms.Label label2;
    }
}

