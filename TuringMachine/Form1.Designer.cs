namespace TuringMachine
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._MenuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuFileImportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuFileExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationStart = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationStop = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationStep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._MenuSimulationDelay = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationDelay0 = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationDelay100 = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationDelay250 = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationDelay500 = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationDelay1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._MenuSimulationDelayCustom = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSimulationDelayValue = new System.Windows.Forms.ToolStripTextBox();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._DescriptionPanel = new System.Windows.Forms.RichTextBox();
            this._DescriptionLabel = new System.Windows.Forms.Label();
            this._TapePanel = new System.Windows.Forms.FlowLayoutPanel();
            this._TapeLabel = new System.Windows.Forms.Label();
            this._ProgPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._ProgColumnStates = new System.Windows.Forms.FlowLayoutPanel();
            this._ProgLabelHead = new System.Windows.Forms.Label();
            this._ProgColumnSpace = new System.Windows.Forms.FlowLayoutPanel();
            this._ProgLabelSpace = new System.Windows.Forms.Button();
            this._ProgColumnComment = new System.Windows.Forms.FlowLayoutPanel();
            this._ProgLabelComment = new System.Windows.Forms.Label();
            this._ProgLabel = new System.Windows.Forms.Label();
            this._TapePageLeft = new System.Windows.Forms.Button();
            this._TapeCellLeft = new System.Windows.Forms.Button();
            this._TapePageRight = new System.Windows.Forms.Button();
            this._TapeCellRight = new System.Windows.Forms.Button();
            this._ProgControlB2 = new System.Windows.Forms.Button();
            this._ProgControlB1 = new System.Windows.Forms.Button();
            this._ProgControlB3 = new System.Windows.Forms.Button();
            this._ProgControlB4 = new System.Windows.Forms.Button();
            this._ProgControlB8 = new System.Windows.Forms.Button();
            this._ProgControlB7 = new System.Windows.Forms.Button();
            this._ProgControlB6 = new System.Windows.Forms.Button();
            this._ProgControlB5 = new System.Windows.Forms.Button();
            this._ProgControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._ToolsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._ProgTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this._ProgPanel.SuspendLayout();
            this._ProgColumnStates.SuspendLayout();
            this._ProgColumnSpace.SuspendLayout();
            this._ProgColumnComment.SuspendLayout();
            this._ProgControlPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuFile,
            this._MenuSimulation,
            this.помощьToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // _MenuFile
            // 
            this._MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuFileCreate,
            this._MenuFileOpen,
            this._MenuFileSave,
            this.toolStripSeparator3,
            this._MenuFileImport,
            this._MenuFileExport,
            this.toolStripSeparator4,
            this._MenuFileExit});
            this._MenuFile.Name = "_MenuFile";
            this._MenuFile.Size = new System.Drawing.Size(48, 20);
            this._MenuFile.Text = "Файл";
            // 
            // _MenuFileCreate
            // 
            this._MenuFileCreate.Name = "_MenuFileCreate";
            this._MenuFileCreate.Size = new System.Drawing.Size(141, 22);
            this._MenuFileCreate.Text = "Создать...";
            // 
            // _MenuFileOpen
            // 
            this._MenuFileOpen.Name = "_MenuFileOpen";
            this._MenuFileOpen.Size = new System.Drawing.Size(141, 22);
            this._MenuFileOpen.Text = "Открыть...";
            // 
            // _MenuFileSave
            // 
            this._MenuFileSave.Name = "_MenuFileSave";
            this._MenuFileSave.Size = new System.Drawing.Size(141, 22);
            this._MenuFileSave.Text = "Сохранить...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // _MenuFileImport
            // 
            this._MenuFileImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuFileImportExcel});
            this._MenuFileImport.Name = "_MenuFileImport";
            this._MenuFileImport.Size = new System.Drawing.Size(141, 22);
            this._MenuFileImport.Text = "Импорт";
            // 
            // _MenuFileImportExcel
            // 
            this._MenuFileImportExcel.Name = "_MenuFileImportExcel";
            this._MenuFileImportExcel.Size = new System.Drawing.Size(161, 22);
            this._MenuFileImportExcel.Text = "Excel table (.xlsx)";
            this._MenuFileImportExcel.Click += new System.EventHandler(this._MenuFileImportExcel_Click);
            // 
            // _MenuFileExport
            // 
            this._MenuFileExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuFileExportExcel});
            this._MenuFileExport.Name = "_MenuFileExport";
            this._MenuFileExport.Size = new System.Drawing.Size(141, 22);
            this._MenuFileExport.Text = "Экспорт";
            // 
            // _MenuFileExportExcel
            // 
            this._MenuFileExportExcel.Name = "_MenuFileExportExcel";
            this._MenuFileExportExcel.Size = new System.Drawing.Size(161, 22);
            this._MenuFileExportExcel.Text = "Excel table (.xlsx)";
            this._MenuFileExportExcel.Click += new System.EventHandler(this._MenuFileExportExcel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // _MenuFileExit
            // 
            this._MenuFileExit.Name = "_MenuFileExit";
            this._MenuFileExit.Size = new System.Drawing.Size(141, 22);
            this._MenuFileExit.Text = "Выход";
            // 
            // _MenuSimulation
            // 
            this._MenuSimulation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuSimulationStart,
            this._MenuSimulationStop,
            this._MenuSimulationStep,
            this.toolStripSeparator1,
            this._MenuSimulationDelay});
            this._MenuSimulation.Name = "_MenuSimulation";
            this._MenuSimulation.Size = new System.Drawing.Size(89, 20);
            this._MenuSimulation.Text = "Выполнение";
            // 
            // _MenuSimulationStart
            // 
            this._MenuSimulationStart.Name = "_MenuSimulationStart";
            this._MenuSimulationStart.Size = new System.Drawing.Size(157, 22);
            this._MenuSimulationStart.Text = "Выполнить";
            this._MenuSimulationStart.Click += new System.EventHandler(this._MenuSimulationStart_Click);
            // 
            // _MenuSimulationStop
            // 
            this._MenuSimulationStop.Name = "_MenuSimulationStop";
            this._MenuSimulationStop.Size = new System.Drawing.Size(157, 22);
            this._MenuSimulationStop.Text = "Остановить";
            this._MenuSimulationStop.Click += new System.EventHandler(this._MenuSimulationStop_Click);
            // 
            // _MenuSimulationStep
            // 
            this._MenuSimulationStep.Name = "_MenuSimulationStep";
            this._MenuSimulationStep.Size = new System.Drawing.Size(157, 22);
            this._MenuSimulationStep.Text = "Один шаг";
            this._MenuSimulationStep.Click += new System.EventHandler(this._MenuSimulationStep_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // _MenuSimulationDelay
            // 
            this._MenuSimulationDelay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuSimulationDelay0,
            this._MenuSimulationDelay100,
            this._MenuSimulationDelay250,
            this._MenuSimulationDelay500,
            this._MenuSimulationDelay1000,
            this.toolStripSeparator2,
            this._MenuSimulationDelayCustom,
            this._MenuSimulationDelayValue});
            this._MenuSimulationDelay.Name = "_MenuSimulationDelay";
            this._MenuSimulationDelay.Size = new System.Drawing.Size(157, 22);
            this._MenuSimulationDelay.Text = "Задержка (ms):";
            // 
            // _MenuSimulationDelay0
            // 
            this._MenuSimulationDelay0.Name = "_MenuSimulationDelay0";
            this._MenuSimulationDelay0.Size = new System.Drawing.Size(162, 22);
            this._MenuSimulationDelay0.Text = "Без задержки";
            this._MenuSimulationDelay0.Click += new System.EventHandler(this._MenuSimulationDelayChange);
            // 
            // _MenuSimulationDelay100
            // 
            this._MenuSimulationDelay100.Checked = true;
            this._MenuSimulationDelay100.CheckState = System.Windows.Forms.CheckState.Checked;
            this._MenuSimulationDelay100.Name = "_MenuSimulationDelay100";
            this._MenuSimulationDelay100.Size = new System.Drawing.Size(162, 22);
            this._MenuSimulationDelay100.Text = "100 ms";
            this._MenuSimulationDelay100.Click += new System.EventHandler(this._MenuSimulationDelayChange);
            // 
            // _MenuSimulationDelay250
            // 
            this._MenuSimulationDelay250.Name = "_MenuSimulationDelay250";
            this._MenuSimulationDelay250.Size = new System.Drawing.Size(162, 22);
            this._MenuSimulationDelay250.Text = "250 ms";
            this._MenuSimulationDelay250.Click += new System.EventHandler(this._MenuSimulationDelayChange);
            // 
            // _MenuSimulationDelay500
            // 
            this._MenuSimulationDelay500.Name = "_MenuSimulationDelay500";
            this._MenuSimulationDelay500.Size = new System.Drawing.Size(162, 22);
            this._MenuSimulationDelay500.Text = "500 ms";
            this._MenuSimulationDelay500.Click += new System.EventHandler(this._MenuSimulationDelayChange);
            // 
            // _MenuSimulationDelay1000
            // 
            this._MenuSimulationDelay1000.Name = "_MenuSimulationDelay1000";
            this._MenuSimulationDelay1000.Size = new System.Drawing.Size(162, 22);
            this._MenuSimulationDelay1000.Text = "1000 ms";
            this._MenuSimulationDelay1000.Click += new System.EventHandler(this._MenuSimulationDelayChange);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // _MenuSimulationDelayCustom
            // 
            this._MenuSimulationDelayCustom.Name = "_MenuSimulationDelayCustom";
            this._MenuSimulationDelayCustom.Size = new System.Drawing.Size(162, 22);
            this._MenuSimulationDelayCustom.Text = "Настраиваемая:";
            // 
            // _MenuSimulationDelayValue
            // 
            this._MenuSimulationDelayValue.Name = "_MenuSimulationDelayValue";
            this._MenuSimulationDelayValue.Size = new System.Drawing.Size(100, 23);
            this._MenuSimulationDelayValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._MenuSimulationDelayType);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // _DescriptionPanel
            // 
            this._DescriptionPanel.AcceptsTab = true;
            this._DescriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._DescriptionPanel.Location = new System.Drawing.Point(10, 50);
            this._DescriptionPanel.Margin = new System.Windows.Forms.Padding(0);
            this._DescriptionPanel.Name = "_DescriptionPanel";
            this._DescriptionPanel.Size = new System.Drawing.Size(988, 150);
            this._DescriptionPanel.TabIndex = 1;
            this._DescriptionPanel.TabStop = false;
            this._DescriptionPanel.Text = "";
            // 
            // _DescriptionLabel
            // 
            this._DescriptionLabel.AutoSize = true;
            this._DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._DescriptionLabel.Location = new System.Drawing.Point(10, 30);
            this._DescriptionLabel.Name = "_DescriptionLabel";
            this._DescriptionLabel.Size = new System.Drawing.Size(79, 20);
            this._DescriptionLabel.TabIndex = 2;
            this._DescriptionLabel.Text = "Описание";
            // 
            // _TapePanel
            // 
            this._TapePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._TapePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._TapePanel.Location = new System.Drawing.Point(80, 240);
            this._TapePanel.Margin = new System.Windows.Forms.Padding(0);
            this._TapePanel.Name = "_TapePanel";
            this._TapePanel.Size = new System.Drawing.Size(883, 42);
            this._TapePanel.TabIndex = 3;
            this._TapePanel.WrapContents = false;
            // 
            // _TapeLabel
            // 
            this._TapeLabel.AutoSize = true;
            this._TapeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._TapeLabel.Location = new System.Drawing.Point(10, 220);
            this._TapeLabel.Name = "_TapeLabel";
            this._TapeLabel.Size = new System.Drawing.Size(50, 20);
            this._TapeLabel.TabIndex = 4;
            this._TapeLabel.Text = "Лента";
            // 
            // _ProgPanel
            // 
            this._ProgPanel.AutoScroll = true;
            this._ProgPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._ProgPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._ProgPanel.Controls.Add(this._ProgColumnStates);
            this._ProgPanel.Controls.Add(this._ProgColumnSpace);
            this._ProgPanel.Controls.Add(this._ProgColumnComment);
            this._ProgPanel.Location = new System.Drawing.Point(154, 320);
            this._ProgPanel.Margin = new System.Windows.Forms.Padding(0);
            this._ProgPanel.Name = "_ProgPanel";
            this._ProgPanel.Size = new System.Drawing.Size(846, 247);
            this._ProgPanel.TabIndex = 5;
            this._ProgPanel.WrapContents = false;
            // 
            // _ProgColumnStates
            // 
            this._ProgColumnStates.AutoSize = true;
            this._ProgColumnStates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._ProgColumnStates.Controls.Add(this._ProgLabelHead);
            this._ProgColumnStates.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._ProgColumnStates.Location = new System.Drawing.Point(0, 0);
            this._ProgColumnStates.Margin = new System.Windows.Forms.Padding(0);
            this._ProgColumnStates.Name = "_ProgColumnStates";
            this._ProgColumnStates.Size = new System.Drawing.Size(80, 42);
            this._ProgColumnStates.TabIndex = 0;
            this._ProgColumnStates.WrapContents = false;
            // 
            // _ProgLabelHead
            // 
            this._ProgLabelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ProgLabelHead.Image = global::TuringMachine.Properties.Resources.TabliDiagonal;
            this._ProgLabelHead.Location = new System.Drawing.Point(0, 0);
            this._ProgLabelHead.Margin = new System.Windows.Forms.Padding(0);
            this._ProgLabelHead.Name = "_ProgLabelHead";
            this._ProgLabelHead.Size = new System.Drawing.Size(80, 42);
            this._ProgLabelHead.TabIndex = 0;
            // 
            // _ProgColumnSpace
            // 
            this._ProgColumnSpace.AutoSize = true;
            this._ProgColumnSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._ProgColumnSpace.Controls.Add(this._ProgLabelSpace);
            this._ProgColumnSpace.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._ProgColumnSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._ProgColumnSpace.Location = new System.Drawing.Point(80, 0);
            this._ProgColumnSpace.Margin = new System.Windows.Forms.Padding(0);
            this._ProgColumnSpace.Name = "_ProgColumnSpace";
            this._ProgColumnSpace.Size = new System.Drawing.Size(60, 42);
            this._ProgColumnSpace.TabIndex = 1;
            this._ProgColumnSpace.WrapContents = false;
            // 
            // _ProgLabelSpace
            // 
            this._ProgLabelSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgLabelSpace.Image = global::TuringMachine.Properties.Resources.Space;
            this._ProgLabelSpace.Location = new System.Drawing.Point(0, 0);
            this._ProgLabelSpace.Margin = new System.Windows.Forms.Padding(0);
            this._ProgLabelSpace.Name = "_ProgLabelSpace";
            this._ProgLabelSpace.Size = new System.Drawing.Size(60, 42);
            this._ProgLabelSpace.TabIndex = 3;
            this._ProgLabelSpace.Text = " ";
            this._ProgLabelSpace.UseVisualStyleBackColor = true;
            this._ProgLabelSpace.Click += new System.EventHandler(this._ProgLabelSpace_Click);
            // 
            // _ProgColumnComment
            // 
            this._ProgColumnComment.AutoSize = true;
            this._ProgColumnComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._ProgColumnComment.Controls.Add(this._ProgLabelComment);
            this._ProgColumnComment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._ProgColumnComment.Location = new System.Drawing.Point(140, 0);
            this._ProgColumnComment.Margin = new System.Windows.Forms.Padding(0);
            this._ProgColumnComment.Name = "_ProgColumnComment";
            this._ProgColumnComment.Size = new System.Drawing.Size(800, 42);
            this._ProgColumnComment.TabIndex = 2;
            this._ProgColumnComment.WrapContents = false;
            // 
            // _ProgLabelComment
            // 
            this._ProgLabelComment.AutoEllipsis = true;
            this._ProgLabelComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ProgLabelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._ProgLabelComment.Location = new System.Drawing.Point(0, 0);
            this._ProgLabelComment.Margin = new System.Windows.Forms.Padding(0);
            this._ProgLabelComment.Name = "_ProgLabelComment";
            this._ProgLabelComment.Size = new System.Drawing.Size(800, 42);
            this._ProgLabelComment.TabIndex = 2;
            this._ProgLabelComment.Text = "Комментарий";
            this._ProgLabelComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _ProgLabel
            // 
            this._ProgLabel.AutoSize = true;
            this._ProgLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._ProgLabel.Location = new System.Drawing.Point(10, 300);
            this._ProgLabel.Name = "_ProgLabel";
            this._ProgLabel.Size = new System.Drawing.Size(91, 20);
            this._ProgLabel.TabIndex = 6;
            this._ProgLabel.Text = "Программа";
            // 
            // _TapePageLeft
            // 
            this._TapePageLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._TapePageLeft.Location = new System.Drawing.Point(10, 240);
            this._TapePageLeft.Name = "_TapePageLeft";
            this._TapePageLeft.Size = new System.Drawing.Size(40, 42);
            this._TapePageLeft.TabIndex = 7;
            this._TapePageLeft.Text = "-10";
            this._TapePageLeft.UseVisualStyleBackColor = true;
            // 
            // _TapeCellLeft
            // 
            this._TapeCellLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._TapeCellLeft.Location = new System.Drawing.Point(49, 240);
            this._TapeCellLeft.Name = "_TapeCellLeft";
            this._TapeCellLeft.Size = new System.Drawing.Size(30, 42);
            this._TapeCellLeft.TabIndex = 8;
            this._TapeCellLeft.Text = "-1";
            this._TapeCellLeft.UseVisualStyleBackColor = true;
            // 
            // _TapePageRight
            // 
            this._TapePageRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._TapePageRight.Location = new System.Drawing.Point(998, 240);
            this._TapePageRight.Name = "_TapePageRight";
            this._TapePageRight.Size = new System.Drawing.Size(40, 42);
            this._TapePageRight.TabIndex = 10;
            this._TapePageRight.Text = "+10";
            this._TapePageRight.UseVisualStyleBackColor = true;
            // 
            // _TapeCellRight
            // 
            this._TapeCellRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._TapeCellRight.Location = new System.Drawing.Point(968, 240);
            this._TapeCellRight.Name = "_TapeCellRight";
            this._TapeCellRight.Size = new System.Drawing.Size(30, 42);
            this._TapeCellRight.TabIndex = 9;
            this._TapeCellRight.Text = "+1";
            this._TapeCellRight.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB2
            // 
            this._ProgControlB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB2.Location = new System.Drawing.Point(50, 10);
            this._ProgControlB2.Margin = new System.Windows.Forms.Padding(5, 10, 10, 0);
            this._ProgControlB2.Name = "_ProgControlB2";
            this._ProgControlB2.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB2.TabIndex = 0;
            this._ProgControlB2.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB1
            // 
            this._ProgControlB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB1.Location = new System.Drawing.Point(10, 10);
            this._ProgControlB1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 0);
            this._ProgControlB1.Name = "_ProgControlB1";
            this._ProgControlB1.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB1.TabIndex = 1;
            this._ProgControlB1.UseVisualStyleBackColor = true;
            this._ProgControlB1.Click += new System.EventHandler(this.CreateRow);
            // 
            // _ProgControlB3
            // 
            this._ProgControlB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB3.Location = new System.Drawing.Point(10, 50);
            this._ProgControlB3.Margin = new System.Windows.Forms.Padding(10, 10, 5, 0);
            this._ProgControlB3.Name = "_ProgControlB3";
            this._ProgControlB3.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB3.TabIndex = 2;
            this._ProgControlB3.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB4
            // 
            this._ProgControlB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB4.Location = new System.Drawing.Point(50, 50);
            this._ProgControlB4.Margin = new System.Windows.Forms.Padding(5, 10, 10, 0);
            this._ProgControlB4.Name = "_ProgControlB4";
            this._ProgControlB4.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB4.TabIndex = 3;
            this._ProgControlB4.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB8
            // 
            this._ProgControlB8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB8.Location = new System.Drawing.Point(50, 140);
            this._ProgControlB8.Margin = new System.Windows.Forms.Padding(5, 10, 10, 0);
            this._ProgControlB8.Name = "_ProgControlB8";
            this._ProgControlB8.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB8.TabIndex = 7;
            this._ProgControlB8.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB7
            // 
            this._ProgControlB7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB7.Location = new System.Drawing.Point(10, 140);
            this._ProgControlB7.Margin = new System.Windows.Forms.Padding(10, 10, 5, 0);
            this._ProgControlB7.Name = "_ProgControlB7";
            this._ProgControlB7.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB7.TabIndex = 6;
            this._ProgControlB7.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB6
            // 
            this._ProgControlB6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB6.Location = new System.Drawing.Point(50, 100);
            this._ProgControlB6.Margin = new System.Windows.Forms.Padding(5, 20, 10, 0);
            this._ProgControlB6.Name = "_ProgControlB6";
            this._ProgControlB6.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB6.TabIndex = 5;
            this._ProgControlB6.UseVisualStyleBackColor = true;
            // 
            // _ProgControlB5
            // 
            this._ProgControlB5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ProgControlB5.Location = new System.Drawing.Point(10, 100);
            this._ProgControlB5.Margin = new System.Windows.Forms.Padding(10, 20, 5, 0);
            this._ProgControlB5.Name = "_ProgControlB5";
            this._ProgControlB5.Size = new System.Drawing.Size(30, 30);
            this._ProgControlB5.TabIndex = 4;
            this._ProgControlB5.UseVisualStyleBackColor = true;
            this._ProgControlB5.Click += new System.EventHandler(this.CreateCol);
            // 
            // _ProgControlPanel
            // 
            this._ProgControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this._ProgControlPanel.Controls.Add(this._ProgControlB1);
            this._ProgControlPanel.Controls.Add(this._ProgControlB2);
            this._ProgControlPanel.Controls.Add(this._ProgControlB3);
            this._ProgControlPanel.Controls.Add(this._ProgControlB4);
            this._ProgControlPanel.Controls.Add(this._ProgControlB5);
            this._ProgControlPanel.Controls.Add(this._ProgControlB6);
            this._ProgControlPanel.Controls.Add(this._ProgControlB7);
            this._ProgControlPanel.Controls.Add(this._ProgControlB8);
            this._ProgControlPanel.Location = new System.Drawing.Point(10, 320);
            this._ProgControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this._ProgControlPanel.Name = "_ProgControlPanel";
            this._ProgControlPanel.Size = new System.Drawing.Size(90, 180);
            this._ProgControlPanel.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _ToolsStatus
            // 
            this._ToolsStatus.Name = "_ToolsStatus";
            this._ToolsStatus.Size = new System.Drawing.Size(118, 17);
            this._ToolsStatus.Text = "toolStripStatusLabel1";
            // 
            // _ProgTimer
            // 
            this._ProgTimer.Tick += new System.EventHandler(this._ProgTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 613);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._ProgControlPanel);
            this.Controls.Add(this._TapePageRight);
            this.Controls.Add(this._TapeCellRight);
            this.Controls.Add(this._TapeCellLeft);
            this.Controls.Add(this._TapePageLeft);
            this.Controls.Add(this._ProgLabel);
            this.Controls.Add(this._ProgPanel);
            this.Controls.Add(this._TapeLabel);
            this.Controls.Add(this._TapePanel);
            this.Controls.Add(this._DescriptionLabel);
            this.Controls.Add(this._DescriptionPanel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._ProgPanel.ResumeLayout(false);
            this._ProgPanel.PerformLayout();
            this._ProgColumnStates.ResumeLayout(false);
            this._ProgColumnSpace.ResumeLayout(false);
            this._ProgColumnComment.ResumeLayout(false);
            this._ProgControlPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _MenuFile;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulation;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox _DescriptionPanel;
        private System.Windows.Forms.Label _DescriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel _TapePanel;
        private System.Windows.Forms.Label _TapeLabel;
        private System.Windows.Forms.FlowLayoutPanel _ProgPanel;
        private System.Windows.Forms.Label _ProgLabel;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileCreate;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationStart;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationStop;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationStep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelay;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelay0;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelay100;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelay250;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelay500;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelay1000;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _MenuSimulationDelayCustom;
        private System.Windows.Forms.ToolStripTextBox _MenuSimulationDelayValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileImport;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileExit;
        private System.Windows.Forms.Button _TapePageLeft;
        private System.Windows.Forms.Button _TapeCellLeft;
        private System.Windows.Forms.Button _TapePageRight;
        private System.Windows.Forms.Button _TapeCellRight;
        private System.Windows.Forms.FlowLayoutPanel _ProgColumnStates;
        private System.Windows.Forms.Label _ProgLabelHead;
        private System.Windows.Forms.FlowLayoutPanel _ProgColumnSpace;
        private System.Windows.Forms.FlowLayoutPanel _ProgColumnComment;
        private System.Windows.Forms.Label _ProgLabelComment;
        private System.Windows.Forms.Button _ProgControlB8;
        private System.Windows.Forms.Button _ProgControlB7;
        private System.Windows.Forms.Button _ProgControlB6;
        private System.Windows.Forms.Button _ProgControlB5;
        private System.Windows.Forms.Button _ProgControlB4;
        private System.Windows.Forms.Button _ProgControlB3;
        private System.Windows.Forms.Button _ProgControlB1;
        private System.Windows.Forms.Button _ProgControlB2;
        private System.Windows.Forms.FlowLayoutPanel _ProgControlPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _ToolsStatus;
        private System.Windows.Forms.Button _ProgLabelSpace;
        private System.Windows.Forms.Timer _ProgTimer;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileExportExcel;
        private System.Windows.Forms.ToolStripMenuItem _MenuFileImportExcel;
    }
}

