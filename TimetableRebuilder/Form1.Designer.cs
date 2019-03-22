namespace TimetableRebuilder
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
            this.GetTimetable = new System.Windows.Forms.Button();
            this.CPG_FileScan = new System.Windows.Forms.Button();
            this.CPG_Finded = new System.Windows.Forms.FlowLayoutPanel();
            this.TeacherCheckbox = new System.Windows.Forms.CheckBox();
            this.CPC_2 = new System.Windows.Forms.Button();
            this.CPC_1 = new System.Windows.Forms.Button();
            this.CPC_3 = new System.Windows.Forms.Button();
            this.CPC_4 = new System.Windows.Forms.Button();
            this.CPC_5 = new System.Windows.Forms.Button();
            this.CPC_6 = new System.Windows.Forms.Button();
            this.CPC_7 = new System.Windows.Forms.Button();
            this.CPC_8 = new System.Windows.Forms.Button();
            this.CPC_9 = new System.Windows.Forms.Button();
            this.CPC_10 = new System.Windows.Forms.Button();
            this.CPC_11 = new System.Windows.Forms.Button();
            this.CPC_12 = new System.Windows.Forms.Button();
            this.CPC_13 = new System.Windows.Forms.Button();
            this.CPC_14 = new System.Windows.Forms.Button();
            this.CPC_15 = new System.Windows.Forms.Button();
            this.CPC_19 = new System.Windows.Forms.Button();
            this.CPC_18 = new System.Windows.Forms.Button();
            this.CPC_17 = new System.Windows.Forms.Button();
            this.CPC_16 = new System.Windows.Forms.Button();
            this.CPF_Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF_SubHead1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CPF_Group = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CPF_SubHead2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CPF_TypeNumber = new System.Windows.Forms.Button();
            this.CP_Base = new System.Windows.Forms.Panel();
            this.CP_Groups = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.CPG_Selected = new System.Windows.Forms.FlowLayoutPanel();
            this.CPG_Filter = new System.Windows.Forms.TextBox();
            this.CP_Fonts = new System.Windows.Forms.Panel();
            this.CPFC_TypeNumber = new System.Windows.Forms.Button();
            this.CPFC_Table = new System.Windows.Forms.Button();
            this.CPFC_SubHead2 = new System.Windows.Forms.Button();
            this.CPFC_SubHead1 = new System.Windows.Forms.Button();
            this.CPFC_Group = new System.Windows.Forms.Button();
            this.CP_Ending = new System.Windows.Forms.Panel();
            this.CP_Names = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CP_Colors = new System.Windows.Forms.Panel();
            this.CB_Groups = new System.Windows.Forms.Button();
            this.CB_Colors = new System.Windows.Forms.Button();
            this.CB_Fonts = new System.Windows.Forms.Button();
            this.CB_Ending = new System.Windows.Forms.Button();
            this.CB_Names = new System.Windows.Forms.Button();
            this.CP_Base.SuspendLayout();
            this.CP_Groups.SuspendLayout();
            this.CP_Fonts.SuspendLayout();
            this.CP_Ending.SuspendLayout();
            this.CP_Names.SuspendLayout();
            this.CP_Colors.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetTimetable
            // 
            this.GetTimetable.Location = new System.Drawing.Point(15, 86);
            this.GetTimetable.Margin = new System.Windows.Forms.Padding(5);
            this.GetTimetable.Name = "GetTimetable";
            this.GetTimetable.Size = new System.Drawing.Size(410, 23);
            this.GetTimetable.TabIndex = 0;
            this.GetTimetable.Text = "Получить расписание";
            this.GetTimetable.UseVisualStyleBackColor = true;
            this.GetTimetable.Click += new System.EventHandler(this.GetTimetable_Click);
            // 
            // CPG_FileScan
            // 
            this.CPG_FileScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPG_FileScan.Location = new System.Drawing.Point(15, 15);
            this.CPG_FileScan.Margin = new System.Windows.Forms.Padding(5);
            this.CPG_FileScan.Name = "CPG_FileScan";
            this.CPG_FileScan.Size = new System.Drawing.Size(420, 25);
            this.CPG_FileScan.TabIndex = 4;
            this.CPG_FileScan.Text = "Сканировать файл расписания...";
            this.CPG_FileScan.UseVisualStyleBackColor = true;
            this.CPG_FileScan.Click += new System.EventHandler(this.CPG_FileScan_Click);
            // 
            // CPG_Finded
            // 
            this.CPG_Finded.AutoScroll = true;
            this.CPG_Finded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPG_Finded.Location = new System.Drawing.Point(15, 85);
            this.CPG_Finded.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.CPG_Finded.Name = "CPG_Finded";
            this.CPG_Finded.Size = new System.Drawing.Size(180, 250);
            this.CPG_Finded.TabIndex = 4;
            // 
            // TeacherCheckbox
            // 
            this.TeacherCheckbox.AutoSize = true;
            this.TeacherCheckbox.Location = new System.Drawing.Point(61, 46);
            this.TeacherCheckbox.Name = "TeacherCheckbox";
            this.TeacherCheckbox.Size = new System.Drawing.Size(345, 17);
            this.TeacherCheckbox.TabIndex = 6;
            this.TeacherCheckbox.Text = "Заменить инициалы преподавателей (Требуется файл-список)";
            this.TeacherCheckbox.UseVisualStyleBackColor = true;
            this.TeacherCheckbox.Click += new System.EventHandler(this.TeacherCheckbox_Click);
            // 
            // CPC_2
            // 
            this.CPC_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.CPC_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_2.Location = new System.Drawing.Point(115, 15);
            this.CPC_2.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.CPC_2.Name = "CPC_2";
            this.CPC_2.Size = new System.Drawing.Size(320, 30);
            this.CPC_2.TabIndex = 7;
            this.CPC_2.Text = "Группа";
            this.CPC_2.UseVisualStyleBackColor = false;
            this.CPC_2.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_1
            // 
            this.CPC_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.CPC_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_1.Location = new System.Drawing.Point(15, 15);
            this.CPC_1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.CPC_1.Name = "CPC_1";
            this.CPC_1.Size = new System.Drawing.Size(100, 80);
            this.CPC_1.TabIndex = 8;
            this.CPC_1.Text = "Подзаголовки";
            this.CPC_1.UseVisualStyleBackColor = false;
            this.CPC_1.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_3
            // 
            this.CPC_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.CPC_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_3.Location = new System.Drawing.Point(115, 45);
            this.CPC_3.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_3.Name = "CPC_3";
            this.CPC_3.Size = new System.Drawing.Size(160, 50);
            this.CPC_3.TabIndex = 9;
            this.CPC_3.Text = "Нечетные";
            this.CPC_3.UseVisualStyleBackColor = false;
            this.CPC_3.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_4
            // 
            this.CPC_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CPC_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_4.Location = new System.Drawing.Point(275, 45);
            this.CPC_4.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_4.Name = "CPC_4";
            this.CPC_4.Size = new System.Drawing.Size(160, 50);
            this.CPC_4.TabIndex = 10;
            this.CPC_4.Text = "Четные";
            this.CPC_4.UseVisualStyleBackColor = false;
            this.CPC_4.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_5
            // 
            this.CPC_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CPC_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_5.Location = new System.Drawing.Point(85, 95);
            this.CPC_5.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CPC_5.Name = "CPC_5";
            this.CPC_5.Size = new System.Drawing.Size(30, 40);
            this.CPC_5.TabIndex = 11;
            this.CPC_5.Text = "П\r\nн";
            this.CPC_5.UseVisualStyleBackColor = false;
            this.CPC_5.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_6
            // 
            this.CPC_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.CPC_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_6.Location = new System.Drawing.Point(85, 135);
            this.CPC_6.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CPC_6.Name = "CPC_6";
            this.CPC_6.Size = new System.Drawing.Size(30, 40);
            this.CPC_6.TabIndex = 12;
            this.CPC_6.Text = "В\r\nт";
            this.CPC_6.UseVisualStyleBackColor = false;
            this.CPC_6.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_7
            // 
            this.CPC_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.CPC_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_7.Location = new System.Drawing.Point(85, 175);
            this.CPC_7.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.CPC_7.Name = "CPC_7";
            this.CPC_7.Size = new System.Drawing.Size(30, 40);
            this.CPC_7.TabIndex = 13;
            this.CPC_7.Text = "С\r\nр";
            this.CPC_7.UseVisualStyleBackColor = false;
            this.CPC_7.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_8
            // 
            this.CPC_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.CPC_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_8.Location = new System.Drawing.Point(85, 215);
            this.CPC_8.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.CPC_8.Name = "CPC_8";
            this.CPC_8.Size = new System.Drawing.Size(30, 40);
            this.CPC_8.TabIndex = 14;
            this.CPC_8.Text = "Ч\r\nт";
            this.CPC_8.UseVisualStyleBackColor = false;
            this.CPC_8.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_9
            // 
            this.CPC_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.CPC_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_9.Location = new System.Drawing.Point(85, 255);
            this.CPC_9.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.CPC_9.Name = "CPC_9";
            this.CPC_9.Size = new System.Drawing.Size(30, 40);
            this.CPC_9.TabIndex = 15;
            this.CPC_9.Text = "П\r\nт";
            this.CPC_9.UseVisualStyleBackColor = false;
            this.CPC_9.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_10
            // 
            this.CPC_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CPC_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_10.Location = new System.Drawing.Point(85, 295);
            this.CPC_10.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.CPC_10.Name = "CPC_10";
            this.CPC_10.Size = new System.Drawing.Size(30, 40);
            this.CPC_10.TabIndex = 16;
            this.CPC_10.Text = "С\r\nб";
            this.CPC_10.UseVisualStyleBackColor = false;
            this.CPC_10.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_11
            // 
            this.CPC_11.BackColor = System.Drawing.Color.NavajoWhite;
            this.CPC_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_11.Location = new System.Drawing.Point(15, 95);
            this.CPC_11.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_11.Name = "CPC_11";
            this.CPC_11.Size = new System.Drawing.Size(70, 240);
            this.CPC_11.TabIndex = 17;
            this.CPC_11.Text = "Номер,\r\n\r\nначало,\r\n\r\nи конец\r\n\r\nпар";
            this.CPC_11.UseVisualStyleBackColor = false;
            this.CPC_11.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_12
            // 
            this.CPC_12.BackColor = System.Drawing.Color.White;
            this.CPC_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_12.Location = new System.Drawing.Point(115, 95);
            this.CPC_12.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_12.Name = "CPC_12";
            this.CPC_12.Size = new System.Drawing.Size(50, 240);
            this.CPC_12.TabIndex = 18;
            this.CPC_12.Text = "П\r\nР\r\nЕ\r\nД\r\nМ\r\nЕ\r\nТ";
            this.CPC_12.UseVisualStyleBackColor = false;
            this.CPC_12.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_13
            // 
            this.CPC_13.BackColor = System.Drawing.Color.White;
            this.CPC_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_13.Location = new System.Drawing.Point(165, 95);
            this.CPC_13.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_13.Name = "CPC_13";
            this.CPC_13.Size = new System.Drawing.Size(30, 240);
            this.CPC_13.TabIndex = 19;
            this.CPC_13.Text = "Т\r\nИ\r\nП\r\n\r\nП\r\nА\r\nР\r\nЫ";
            this.CPC_13.UseVisualStyleBackColor = false;
            this.CPC_13.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_14
            // 
            this.CPC_14.BackColor = System.Drawing.Color.White;
            this.CPC_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_14.Location = new System.Drawing.Point(195, 95);
            this.CPC_14.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_14.Name = "CPC_14";
            this.CPC_14.Size = new System.Drawing.Size(50, 240);
            this.CPC_14.TabIndex = 20;
            this.CPC_14.Text = "П\r\nР\r\nЕ\r\nП\r\nО\r\nД";
            this.CPC_14.UseVisualStyleBackColor = false;
            this.CPC_14.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_15
            // 
            this.CPC_15.BackColor = System.Drawing.Color.NavajoWhite;
            this.CPC_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_15.Location = new System.Drawing.Point(245, 95);
            this.CPC_15.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_15.Name = "CPC_15";
            this.CPC_15.Size = new System.Drawing.Size(30, 240);
            this.CPC_15.TabIndex = 21;
            this.CPC_15.Text = "А\r\nУ\r\nД\r\nИ\r\nТ\r\nО\r\nР\r\nИ\r\nЯ";
            this.CPC_15.UseVisualStyleBackColor = false;
            this.CPC_15.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_19
            // 
            this.CPC_19.BackColor = System.Drawing.Color.NavajoWhite;
            this.CPC_19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_19.Location = new System.Drawing.Point(405, 95);
            this.CPC_19.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_19.Name = "CPC_19";
            this.CPC_19.Size = new System.Drawing.Size(30, 240);
            this.CPC_19.TabIndex = 25;
            this.CPC_19.Text = "А\r\nУ\r\nД\r\nИ\r\nТ\r\nО\r\nР\r\nИ\r\nЯ";
            this.CPC_19.UseVisualStyleBackColor = false;
            this.CPC_19.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_18
            // 
            this.CPC_18.BackColor = System.Drawing.Color.White;
            this.CPC_18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_18.Location = new System.Drawing.Point(355, 95);
            this.CPC_18.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_18.Name = "CPC_18";
            this.CPC_18.Size = new System.Drawing.Size(50, 240);
            this.CPC_18.TabIndex = 24;
            this.CPC_18.Text = "П\r\nР\r\nЕ\r\nП\r\nО\r\nД";
            this.CPC_18.UseVisualStyleBackColor = false;
            this.CPC_18.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_17
            // 
            this.CPC_17.BackColor = System.Drawing.Color.White;
            this.CPC_17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_17.Location = new System.Drawing.Point(325, 95);
            this.CPC_17.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_17.Name = "CPC_17";
            this.CPC_17.Size = new System.Drawing.Size(30, 240);
            this.CPC_17.TabIndex = 23;
            this.CPC_17.Text = "Т\r\nИ\r\nП\r\n\r\nП\r\nА\r\nР\r\nЫ";
            this.CPC_17.UseVisualStyleBackColor = false;
            this.CPC_17.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPC_16
            // 
            this.CPC_16.BackColor = System.Drawing.Color.White;
            this.CPC_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPC_16.Location = new System.Drawing.Point(275, 95);
            this.CPC_16.Margin = new System.Windows.Forms.Padding(0);
            this.CPC_16.Name = "CPC_16";
            this.CPC_16.Size = new System.Drawing.Size(50, 240);
            this.CPC_16.TabIndex = 22;
            this.CPC_16.Text = "П\r\nР\r\nЕ\r\nД\r\nМ\r\nЕ\r\nТ";
            this.CPC_16.UseVisualStyleBackColor = false;
            this.CPC_16.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPF_Table
            // 
            this.CPF_Table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPF_Table.Location = new System.Drawing.Point(51, 235);
            this.CPF_Table.Margin = new System.Windows.Forms.Padding(5);
            this.CPF_Table.Name = "CPF_Table";
            this.CPF_Table.Size = new System.Drawing.Size(384, 26);
            this.CPF_Table.TabIndex = 26;
            this.CPF_Table.Text = "Arial, 16";
            this.CPF_Table.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPF_Table.UseVisualStyleBackColor = true;
            this.CPF_Table.Click += new System.EventHandler(this.SelectFont);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Шрифт расписания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Подзаголовки 1";
            // 
            // CPF_SubHead1
            // 
            this.CPF_SubHead1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPF_SubHead1.Location = new System.Drawing.Point(51, 105);
            this.CPF_SubHead1.Margin = new System.Windows.Forms.Padding(5);
            this.CPF_SubHead1.Name = "CPF_SubHead1";
            this.CPF_SubHead1.Size = new System.Drawing.Size(384, 26);
            this.CPF_SubHead1.TabIndex = 28;
            this.CPF_SubHead1.Text = "Arial, 24, Bold";
            this.CPF_SubHead1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPF_SubHead1.UseVisualStyleBackColor = true;
            this.CPF_SubHead1.Click += new System.EventHandler(this.SelectFont);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Название группы";
            // 
            // CPF_Group
            // 
            this.CPF_Group.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPF_Group.Location = new System.Drawing.Point(51, 40);
            this.CPF_Group.Margin = new System.Windows.Forms.Padding(5);
            this.CPF_Group.Name = "CPF_Group";
            this.CPF_Group.Size = new System.Drawing.Size(384, 26);
            this.CPF_Group.TabIndex = 30;
            this.CPF_Group.Tag = "";
            this.CPF_Group.Text = "Arial, 32, Bold";
            this.CPF_Group.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPF_Group.UseVisualStyleBackColor = true;
            this.CPF_Group.Click += new System.EventHandler(this.SelectFont);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Подзаголовки 2";
            // 
            // CPF_SubHead2
            // 
            this.CPF_SubHead2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPF_SubHead2.Location = new System.Drawing.Point(51, 170);
            this.CPF_SubHead2.Margin = new System.Windows.Forms.Padding(5);
            this.CPF_SubHead2.Name = "CPF_SubHead2";
            this.CPF_SubHead2.Size = new System.Drawing.Size(384, 26);
            this.CPF_SubHead2.TabIndex = 32;
            this.CPF_SubHead2.Text = "Arial, 20, Bold";
            this.CPF_SubHead2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPF_SubHead2.UseVisualStyleBackColor = true;
            this.CPF_SubHead2.Click += new System.EventHandler(this.SelectFont);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Тип пары и номер аудитории";
            // 
            // CPF_TypeNumber
            // 
            this.CPF_TypeNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPF_TypeNumber.Location = new System.Drawing.Point(51, 300);
            this.CPF_TypeNumber.Margin = new System.Windows.Forms.Padding(5);
            this.CPF_TypeNumber.Name = "CPF_TypeNumber";
            this.CPF_TypeNumber.Size = new System.Drawing.Size(384, 26);
            this.CPF_TypeNumber.TabIndex = 34;
            this.CPF_TypeNumber.Text = "Arial, 16, Bold";
            this.CPF_TypeNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPF_TypeNumber.UseVisualStyleBackColor = true;
            this.CPF_TypeNumber.Click += new System.EventHandler(this.SelectFont);
            // 
            // CP_Base
            // 
            this.CP_Base.AutoScroll = true;
            this.CP_Base.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_Base.Controls.Add(this.CP_Groups);
            this.CP_Base.Controls.Add(this.CP_Fonts);
            this.CP_Base.Controls.Add(this.CP_Ending);
            this.CP_Base.Controls.Add(this.CP_Names);
            this.CP_Base.Controls.Add(this.CP_Colors);
            this.CP_Base.Location = new System.Drawing.Point(209, 9);
            this.CP_Base.Margin = new System.Windows.Forms.Padding(0);
            this.CP_Base.Name = "CP_Base";
            this.CP_Base.Size = new System.Drawing.Size(902, 411);
            this.CP_Base.TabIndex = 36;
            // 
            // CP_Groups
            // 
            this.CP_Groups.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_Groups.Controls.Add(this.button8);
            this.CP_Groups.Controls.Add(this.button7);
            this.CP_Groups.Controls.Add(this.button6);
            this.CP_Groups.Controls.Add(this.CPG_Selected);
            this.CP_Groups.Controls.Add(this.CPG_Filter);
            this.CP_Groups.Controls.Add(this.CPG_Finded);
            this.CP_Groups.Controls.Add(this.CPG_FileScan);
            this.CP_Groups.Location = new System.Drawing.Point(0, 0);
            this.CP_Groups.Margin = new System.Windows.Forms.Padding(0);
            this.CP_Groups.Name = "CP_Groups";
            this.CP_Groups.Padding = new System.Windows.Forms.Padding(10);
            this.CP_Groups.Size = new System.Drawing.Size(450, 350);
            this.CP_Groups.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.BackgroundImage = global::TimetableRebuilder.Properties.Resources.Cross;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(205, 185);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 50);
            this.button8.TabIndex = 45;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.BackgroundImage = global::TimetableRebuilder.Properties.Resources.ArrowDoubleLeft;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(205, 245);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 50);
            this.button7.TabIndex = 44;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.BackgroundImage = global::TimetableRebuilder.Properties.Resources.ArrowDoubleRight;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(205, 125);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 50);
            this.button6.TabIndex = 43;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CPG_Selected
            // 
            this.CPG_Selected.AutoScroll = true;
            this.CPG_Selected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPG_Selected.Location = new System.Drawing.Point(255, 85);
            this.CPG_Selected.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.CPG_Selected.Name = "CPG_Selected";
            this.CPG_Selected.Size = new System.Drawing.Size(180, 250);
            this.CPG_Selected.TabIndex = 5;
            // 
            // CPG_Filter
            // 
            this.CPG_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPG_Filter.Location = new System.Drawing.Point(15, 50);
            this.CPG_Filter.Margin = new System.Windows.Forms.Padding(5);
            this.CPG_Filter.Name = "CPG_Filter";
            this.CPG_Filter.Size = new System.Drawing.Size(420, 24);
            this.CPG_Filter.TabIndex = 42;
            // 
            // CP_Fonts
            // 
            this.CP_Fonts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_Fonts.Controls.Add(this.CPFC_TypeNumber);
            this.CP_Fonts.Controls.Add(this.CPFC_Table);
            this.CP_Fonts.Controls.Add(this.CPFC_SubHead2);
            this.CP_Fonts.Controls.Add(this.CPFC_SubHead1);
            this.CP_Fonts.Controls.Add(this.CPFC_Group);
            this.CP_Fonts.Controls.Add(this.label3);
            this.CP_Fonts.Controls.Add(this.CPF_Table);
            this.CP_Fonts.Controls.Add(this.label1);
            this.CP_Fonts.Controls.Add(this.CPF_SubHead1);
            this.CP_Fonts.Controls.Add(this.label5);
            this.CP_Fonts.Controls.Add(this.label2);
            this.CP_Fonts.Controls.Add(this.CPF_TypeNumber);
            this.CP_Fonts.Controls.Add(this.CPF_Group);
            this.CP_Fonts.Controls.Add(this.label4);
            this.CP_Fonts.Controls.Add(this.CPF_SubHead2);
            this.CP_Fonts.Location = new System.Drawing.Point(900, 0);
            this.CP_Fonts.Margin = new System.Windows.Forms.Padding(0);
            this.CP_Fonts.Name = "CP_Fonts";
            this.CP_Fonts.Padding = new System.Windows.Forms.Padding(10);
            this.CP_Fonts.Size = new System.Drawing.Size(450, 350);
            this.CP_Fonts.TabIndex = 42;
            // 
            // CPFC_TypeNumber
            // 
            this.CPFC_TypeNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPFC_TypeNumber.Location = new System.Drawing.Point(15, 300);
            this.CPFC_TypeNumber.Margin = new System.Windows.Forms.Padding(5);
            this.CPFC_TypeNumber.Name = "CPFC_TypeNumber";
            this.CPFC_TypeNumber.Size = new System.Drawing.Size(26, 26);
            this.CPFC_TypeNumber.TabIndex = 40;
            this.CPFC_TypeNumber.UseVisualStyleBackColor = false;
            this.CPFC_TypeNumber.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPFC_Table
            // 
            this.CPFC_Table.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPFC_Table.Location = new System.Drawing.Point(15, 235);
            this.CPFC_Table.Margin = new System.Windows.Forms.Padding(5);
            this.CPFC_Table.Name = "CPFC_Table";
            this.CPFC_Table.Size = new System.Drawing.Size(26, 26);
            this.CPFC_Table.TabIndex = 39;
            this.CPFC_Table.UseVisualStyleBackColor = false;
            this.CPFC_Table.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPFC_SubHead2
            // 
            this.CPFC_SubHead2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPFC_SubHead2.Location = new System.Drawing.Point(15, 170);
            this.CPFC_SubHead2.Margin = new System.Windows.Forms.Padding(5);
            this.CPFC_SubHead2.Name = "CPFC_SubHead2";
            this.CPFC_SubHead2.Size = new System.Drawing.Size(26, 26);
            this.CPFC_SubHead2.TabIndex = 38;
            this.CPFC_SubHead2.UseVisualStyleBackColor = false;
            this.CPFC_SubHead2.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPFC_SubHead1
            // 
            this.CPFC_SubHead1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPFC_SubHead1.Location = new System.Drawing.Point(15, 105);
            this.CPFC_SubHead1.Margin = new System.Windows.Forms.Padding(5);
            this.CPFC_SubHead1.Name = "CPFC_SubHead1";
            this.CPFC_SubHead1.Size = new System.Drawing.Size(26, 26);
            this.CPFC_SubHead1.TabIndex = 37;
            this.CPFC_SubHead1.UseVisualStyleBackColor = false;
            this.CPFC_SubHead1.Click += new System.EventHandler(this.SelectColor);
            // 
            // CPFC_Group
            // 
            this.CPFC_Group.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPFC_Group.Location = new System.Drawing.Point(15, 40);
            this.CPFC_Group.Margin = new System.Windows.Forms.Padding(5);
            this.CPFC_Group.Name = "CPFC_Group";
            this.CPFC_Group.Size = new System.Drawing.Size(26, 26);
            this.CPFC_Group.TabIndex = 36;
            this.CPFC_Group.UseVisualStyleBackColor = false;
            this.CPFC_Group.Click += new System.EventHandler(this.SelectColor);
            // 
            // CP_Ending
            // 
            this.CP_Ending.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_Ending.Controls.Add(this.TeacherCheckbox);
            this.CP_Ending.Controls.Add(this.GetTimetable);
            this.CP_Ending.Location = new System.Drawing.Point(1800, 0);
            this.CP_Ending.Margin = new System.Windows.Forms.Padding(0);
            this.CP_Ending.Name = "CP_Ending";
            this.CP_Ending.Padding = new System.Windows.Forms.Padding(10);
            this.CP_Ending.Size = new System.Drawing.Size(450, 350);
            this.CP_Ending.TabIndex = 43;
            // 
            // CP_Names
            // 
            this.CP_Names.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_Names.Controls.Add(this.button1);
            this.CP_Names.Controls.Add(this.label6);
            this.CP_Names.Controls.Add(this.button2);
            this.CP_Names.Controls.Add(this.label7);
            this.CP_Names.Controls.Add(this.button3);
            this.CP_Names.Controls.Add(this.label8);
            this.CP_Names.Controls.Add(this.button4);
            this.CP_Names.Controls.Add(this.label9);
            this.CP_Names.Controls.Add(this.button5);
            this.CP_Names.Controls.Add(this.label10);
            this.CP_Names.Controls.Add(this.textBox5);
            this.CP_Names.Controls.Add(this.textBox4);
            this.CP_Names.Controls.Add(this.textBox3);
            this.CP_Names.Controls.Add(this.textBox2);
            this.CP_Names.Controls.Add(this.textBox1);
            this.CP_Names.Location = new System.Drawing.Point(1350, 0);
            this.CP_Names.Margin = new System.Windows.Forms.Padding(0);
            this.CP_Names.Name = "CP_Names";
            this.CP_Names.Padding = new System.Windows.Forms.Padding(10);
            this.CP_Names.Size = new System.Drawing.Size(450, 350);
            this.CP_Names.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Название группы";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(15, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Шрифт расписания";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(15, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Тип пары и номер аудитории";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(15, 105);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 26);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Подзаголовки 1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(15, 40);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 26);
            this.button5.TabIndex = 41;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Подзаголовки 2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(51, 303);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(384, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "10-30, 12-10, 14-30, 16-10, 17-50, 19-30";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 238);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(384, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "9-00, 10-40, 13-00, 14-40, 16-20, 18-00";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 173);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Понедельник, Вторник, Среда, Четверг, Пятница, Суббота";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Предмет, Тип, Преподаватель, Аудит.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "День недели, № пары, Начало, Конец";
            // 
            // CP_Colors
            // 
            this.CP_Colors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_Colors.Controls.Add(this.CPC_11);
            this.CP_Colors.Controls.Add(this.CPC_1);
            this.CP_Colors.Controls.Add(this.CPC_2);
            this.CP_Colors.Controls.Add(this.CPC_3);
            this.CP_Colors.Controls.Add(this.CPC_4);
            this.CP_Colors.Controls.Add(this.CPC_5);
            this.CP_Colors.Controls.Add(this.CPC_6);
            this.CP_Colors.Controls.Add(this.CPC_7);
            this.CP_Colors.Controls.Add(this.CPC_8);
            this.CP_Colors.Controls.Add(this.CPC_9);
            this.CP_Colors.Controls.Add(this.CPC_10);
            this.CP_Colors.Controls.Add(this.CPC_12);
            this.CP_Colors.Controls.Add(this.CPC_13);
            this.CP_Colors.Controls.Add(this.CPC_19);
            this.CP_Colors.Controls.Add(this.CPC_14);
            this.CP_Colors.Controls.Add(this.CPC_18);
            this.CP_Colors.Controls.Add(this.CPC_15);
            this.CP_Colors.Controls.Add(this.CPC_17);
            this.CP_Colors.Controls.Add(this.CPC_16);
            this.CP_Colors.Location = new System.Drawing.Point(450, 0);
            this.CP_Colors.Margin = new System.Windows.Forms.Padding(0);
            this.CP_Colors.Name = "CP_Colors";
            this.CP_Colors.Padding = new System.Windows.Forms.Padding(10);
            this.CP_Colors.Size = new System.Drawing.Size(450, 350);
            this.CP_Colors.TabIndex = 41;
            // 
            // CB_Groups
            // 
            this.CB_Groups.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CB_Groups.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Groups.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Groups.Location = new System.Drawing.Point(14, 14);
            this.CB_Groups.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Groups.Name = "CB_Groups";
            this.CB_Groups.Size = new System.Drawing.Size(200, 40);
            this.CB_Groups.TabIndex = 37;
            this.CB_Groups.Text = "Добавление файлов и групп";
            this.CB_Groups.UseVisualStyleBackColor = false;
            this.CB_Groups.Click += new System.EventHandler(this.SelectPanel);
            // 
            // CB_Colors
            // 
            this.CB_Colors.BackColor = System.Drawing.SystemColors.Control;
            this.CB_Colors.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Colors.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Colors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Colors.Location = new System.Drawing.Point(14, 64);
            this.CB_Colors.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Colors.Name = "CB_Colors";
            this.CB_Colors.Size = new System.Drawing.Size(200, 40);
            this.CB_Colors.TabIndex = 38;
            this.CB_Colors.Text = "Настройка цветовой схемы";
            this.CB_Colors.UseVisualStyleBackColor = false;
            this.CB_Colors.Click += new System.EventHandler(this.SelectPanel);
            // 
            // CB_Fonts
            // 
            this.CB_Fonts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CB_Fonts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Fonts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Fonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Fonts.Location = new System.Drawing.Point(14, 114);
            this.CB_Fonts.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Fonts.Name = "CB_Fonts";
            this.CB_Fonts.Size = new System.Drawing.Size(200, 40);
            this.CB_Fonts.TabIndex = 39;
            this.CB_Fonts.Text = "Настройка шрифтов таблицы";
            this.CB_Fonts.UseVisualStyleBackColor = false;
            this.CB_Fonts.Click += new System.EventHandler(this.SelectPanel);
            // 
            // CB_Ending
            // 
            this.CB_Ending.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CB_Ending.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Ending.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Ending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Ending.Location = new System.Drawing.Point(14, 214);
            this.CB_Ending.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Ending.Name = "CB_Ending";
            this.CB_Ending.Size = new System.Drawing.Size(200, 40);
            this.CB_Ending.TabIndex = 40;
            this.CB_Ending.Text = "Завершение и сохранение";
            this.CB_Ending.UseVisualStyleBackColor = false;
            this.CB_Ending.Click += new System.EventHandler(this.SelectPanel);
            // 
            // CB_Names
            // 
            this.CB_Names.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CB_Names.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Names.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CB_Names.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Names.Location = new System.Drawing.Point(14, 164);
            this.CB_Names.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Names.Name = "CB_Names";
            this.CB_Names.Size = new System.Drawing.Size(200, 40);
            this.CB_Names.TabIndex = 44;
            this.CB_Names.Text = "Настройка имен";
            this.CB_Names.UseVisualStyleBackColor = false;
            this.CB_Names.Click += new System.EventHandler(this.SelectPanel);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1123, 430);
            this.Controls.Add(this.CP_Base);
            this.Controls.Add(this.CB_Names);
            this.Controls.Add(this.CB_Fonts);
            this.Controls.Add(this.CB_Ending);
            this.Controls.Add(this.CB_Colors);
            this.Controls.Add(this.CB_Groups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.CP_Base.ResumeLayout(false);
            this.CP_Groups.ResumeLayout(false);
            this.CP_Groups.PerformLayout();
            this.CP_Fonts.ResumeLayout(false);
            this.CP_Fonts.PerformLayout();
            this.CP_Ending.ResumeLayout(false);
            this.CP_Ending.PerformLayout();
            this.CP_Names.ResumeLayout(false);
            this.CP_Names.PerformLayout();
            this.CP_Colors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetTimetable;
        private System.Windows.Forms.Button CPG_FileScan;
        private System.Windows.Forms.FlowLayoutPanel CPG_Finded;
        private System.Windows.Forms.CheckBox TeacherCheckbox;
        private System.Windows.Forms.Button CPC_2;
        private System.Windows.Forms.Button CPC_1;
        private System.Windows.Forms.Button CPC_3;
        private System.Windows.Forms.Button CPC_4;
        private System.Windows.Forms.Button CPC_5;
        private System.Windows.Forms.Button CPC_6;
        private System.Windows.Forms.Button CPC_7;
        private System.Windows.Forms.Button CPC_8;
        private System.Windows.Forms.Button CPC_9;
        private System.Windows.Forms.Button CPC_10;
        private System.Windows.Forms.Button CPC_11;
        private System.Windows.Forms.Button CPC_12;
        private System.Windows.Forms.Button CPC_13;
        private System.Windows.Forms.Button CPC_14;
        private System.Windows.Forms.Button CPC_15;
        private System.Windows.Forms.Button CPC_19;
        private System.Windows.Forms.Button CPC_18;
        private System.Windows.Forms.Button CPC_17;
        private System.Windows.Forms.Button CPC_16;
        private System.Windows.Forms.Button CPF_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CPF_SubHead1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CPF_Group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CPF_SubHead2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CPF_TypeNumber;
        private System.Windows.Forms.Panel CP_Base;
        private System.Windows.Forms.Button CB_Groups;
        private System.Windows.Forms.Button CB_Colors;
        private System.Windows.Forms.Button CB_Fonts;
        private System.Windows.Forms.Button CB_Ending;
        private System.Windows.Forms.Panel CP_Groups;
        private System.Windows.Forms.Panel CP_Colors;
        private System.Windows.Forms.Panel CP_Fonts;
        private System.Windows.Forms.Panel CP_Ending;
        private System.Windows.Forms.Button CPFC_Group;
        private System.Windows.Forms.Button CPFC_TypeNumber;
        private System.Windows.Forms.Button CPFC_Table;
        private System.Windows.Forms.Button CPFC_SubHead2;
        private System.Windows.Forms.Button CPFC_SubHead1;
        private System.Windows.Forms.Button CB_Names;
        private System.Windows.Forms.Panel CP_Names;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel CPG_Selected;
        private System.Windows.Forms.TextBox CPG_Filter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

