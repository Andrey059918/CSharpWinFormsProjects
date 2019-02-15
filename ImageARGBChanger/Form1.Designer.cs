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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolBarButton_Open = new System.Windows.Forms.ToolStripButton();
            this.ToolBarButton_Save = new System.Windows.Forms.ToolStripButton();
            this.ToolBarButton_Colors = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarButton_Open,
            this.ToolBarButton_Save,
            this.ToolBarButton_Colors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(57, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolBarButton_Open
            // 
            this.ToolBarButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarButton_Open.Image = global::ImageARGBChanger.Properties.Resources.OpenFileIcon;
            this.ToolBarButton_Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBarButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarButton_Open.Name = "ToolBarButton_Open";
            this.ToolBarButton_Open.Size = new System.Drawing.Size(54, 68);
            this.ToolBarButton_Open.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolBarButton_Open.Click += new System.EventHandler(this.ToolBarButton_Open_Click);
            // 
            // ToolBarButton_Save
            // 
            this.ToolBarButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarButton_Save.Image = global::ImageARGBChanger.Properties.Resources.SaveFileIcon;
            this.ToolBarButton_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBarButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarButton_Save.Name = "ToolBarButton_Save";
            this.ToolBarButton_Save.Size = new System.Drawing.Size(54, 68);
            this.ToolBarButton_Save.Text = "toolStripButton5";
            this.ToolBarButton_Save.Click += new System.EventHandler(this.ToolBarButton_Save_Click);
            // 
            // ToolBarButton_Colors
            // 
            this.ToolBarButton_Colors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarButton_Colors.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarButton_Colors.Image")));
            this.ToolBarButton_Colors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarButton_Colors.Name = "ToolBarButton_Colors";
            this.ToolBarButton_Colors.Size = new System.Drawing.Size(54, 20);
            this.ToolBarButton_Colors.Text = "toolStripButton1";
            this.ToolBarButton_Colors.Click += new System.EventHandler(this.ToolBarButton_Colors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolBarButton_Open;
        private System.Windows.Forms.ToolStripButton ToolBarButton_Save;
        private System.Windows.Forms.ToolStripButton ToolBarButton_Colors;
    }
}

