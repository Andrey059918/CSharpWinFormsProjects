using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using VBasic=Microsoft.VisualBasic.Interaction;

namespace TimetableRebuilder
{
    public partial class Form1 : Form
    {
        List<Group> Groups;
        IXLWorkbook SrcBook;
        IXLWorksheet SrcSheet;

        String TeachPath;
        List<String> Teachers;
        List<Button> ColorButtons;
        List<Button> CB_Buttons;
        ColorDialog selcolor;


        public Form1()
        {
            InitializeComponent();
            PreparePanelSwitch();
            DefaultFonts();
            selcolor = new ColorDialog();
            ColorButtons = CP_Colors.Controls.Cast<Button>().OrderBy(a => Convert.ToInt32(a.Name.Substring(4))).ToList();
            Size = new Size(686, 409);
            CP_Base.Size = new Size(452, 352);
            CP_Base.AutoScroll = false;
        }
        private void PreparePanelSwitch() {
            CB_Buttons = new List<Button>();
            CB_Buttons.Add(CB_Groups);
            CB_Buttons.Add(CB_Colors);
            CB_Buttons.Add(CB_Fonts);
            CB_Buttons.Add(CB_Names);
            CB_Buttons.Add(CB_Ending);
            CB_Groups.Tag = CP_Groups;
            CB_Colors.Tag = CP_Colors;
            CB_Fonts.Tag = CP_Fonts;
            CB_Names.Tag = CP_Names;
            CB_Ending.Tag = CP_Ending;
            CB_Buttons.ForEach(a =>
            {
                Controls.Add(a.Tag as Panel);
                (a.Tag as Panel).Location = new Point(210, 10);
            });
            SelectPanel(CB_Groups, EventArgs.Empty);
        }
        private void DefaultFonts() {
            CPF_Group.Tag = new Font("Segoe UI", 32, FontStyle.Bold);
            CPF_SubHead1.Tag = new Font("Segoe UI", 24, FontStyle.Bold);
            CPF_SubHead2.Tag = new Font("Segoe UI", 20, FontStyle.Bold);
            CPF_Table.Tag = new Font("Segoe UI", 16, FontStyle.Regular);
            CPF_TypeNumber.Tag = new Font("Segoe UI", 16, FontStyle.Bold);
        }


        private void SelectPanel(object sndr, EventArgs args) {
            CP_Base.SendToBack();
            CB_Buttons.ForEach(a =>
            {
                if (sndr as Button == a) {
                    a.BackColor = ColorTranslator.FromHtml("ControlLightLight");
                    (a.Tag as Panel).Visible = true;
                }
                else {
                    a.BackColor = ColorTranslator.FromHtml("ControlLight");
                    a.SendToBack();
                    (a.Tag as Panel).Visible = false;
                }
            });
        }
        private void SelectColor(object sndr, EventArgs args)
        {
            selcolor.Color = (sndr as Button).BackColor;
            if (selcolor.ShowDialog() == DialogResult.OK)
            {

                (sndr as Button).BackColor = selcolor.Color;
            }
        }
        private void SelectFont(object sndr, EventArgs args) {
            FontDialog SelFont = new FontDialog() {ShowColor=false,ShowEffects=true,Font=(sndr as Button).Tag as Font };
            if (SelFont.ShowDialog() == DialogResult.OK) {
                (sndr as Button).Tag = SelFont.Font;
                (sndr as Button).Text = String.Concat(SelFont.Font.Name,"; ", Math.Round(SelFont.Font.SizeInPoints),
                    SelFont.Font.Bold?"; Bold":"", SelFont.Font.Italic ? "; Italic" : "", SelFont.Font.Underline ? "; Underline" : "", SelFont.Font.Strikeout ? "; Strikeout" : "");
            }
        }
        

        private void TimetableAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Title = "Выберите таблицу Excel с расписанием...",
                Filter = "Файлы Excel: *.xls; *.xlsx; *.xlsm|*.xls;*.xlsx;*.xlsm",
                Multiselect = true
            };
            if (openfile.ShowDialog() == DialogResult.OK) {
                foreach (var path in openfile.FileNames) {
                    CPG_TPanel.Controls.Add(new Label() { Text = Path.GetFileName(path),Tag=path});
                    CPG_TPanel.Controls[CPG_TPanel.Controls.Count - 1].Click += (e1, e2) => CPG_TPanel.Controls.Remove(e1 as Control);
                }
            }
        }
        private void GroupAdd_Click(object sender, EventArgs e)
        {
            String groupInput = VBasic.InputBox("Название группы должно полностью соответствовать названию в расписании", "Добавление группы...","",MousePosition.X-320, MousePosition.Y-50);
            if (groupInput != "")
            {
                CPG_GPanel.Controls.Add(new Label() { Text = groupInput });
                CPG_GPanel.Controls[CPG_GPanel.Controls.Count - 1].Click += (e1, e2) => CPG_GPanel.Controls.Remove(e1 as Control);
            }
        }
        private void GetTimetable_Click(object sender, EventArgs e)
        {
            Groups = new List<Group>();
            foreach (Control fl in CPG_TPanel.Controls)
            {
                LogText("Анализ файла "+fl.Text);
                SrcBook = new XLWorkbook(fl.Tag.ToString());
                SrcSheet = SrcBook.Worksheet(1);
                foreach (Control gl in CPG_GPanel.Controls)
                {
                    String GName = gl.Text;
                    IXLCells cells = SrcSheet.Row(2).CellsUsed(a => a.Value.ToString().StartsWith(GName));
                    if (cells.Count() > 0)
                    {
                        LogText("Поиск завершен:");
                        foreach (IXLCell cell in cells)
                        {
                            LogText(cell.Value.ToString());
                            ReadTimeTable(cell.Address.ColumnNumber);
                        }
                    }
                    else
                    {
                        LogText("Поиск не дал результатов");
                    }
                }
                SrcBook.Dispose();
            }
        }
        private void TeacherCheckbox_Click(object sender, EventArgs e)
        {
            if (TeacherCheckbox.Checked)
            {
                OpenFileDialog openfile = new OpenFileDialog()
                {
                    Title = "Выберите таблицу Excel со списком...",
                    Filter = "Файлы Excel: *.xls; *.xlsx; *.xlsm|*.xls;*.xlsx;*.xlsm"
                };
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    TeachPath = openfile.FileName;
                }
                else
                {
                    TeacherCheckbox.Checked = false;
                }
            }
        }


        private String ReplaceTeacher(String Tshort)
        {
            if (Tshort == "")
            {
                return Tshort;
            }
            else
            {
                var TTeachers = Teachers.Where(a => a.Split(' ')[0] == Tshort.Split(' ')[0]).ToList();
                if (TTeachers.Count == 0)
                {
                    return Tshort;
                }
                else if (TTeachers.Count == 1)
                {
                    String[] temp = TTeachers[0].Split(' ');
                    return temp[0] + "\n" + temp[1] + " " + temp[2];
                }
                else
                {
                    if (TTeachers.Where(a => a.Split(' ')[1].StartsWith(Tshort.Split(' ')[1].Split('.')[0])&& a.Split(' ')[2].StartsWith(Tshort.Split(' ')[1].Split('.')[1])).Count() == 1)
                    {
                        String[] temp = TTeachers[0].Split(' ');
                        return temp[0] + "\n" + temp[1] + " " + temp[2];
                    }
                    else
                    {
                        return Tshort;
                    }
                }
            }
        }
        private void ReadTimeTable(Int32 column) {
            Groups.Add(new Group(SrcSheet.Cell(2, column).Value.ToString()));
            for (int i = 0; i < 6; i++) {
                Groups.Last().WDays.Add(new WeekDay());
                for (int j = 0; j < 12; j++)
                {
                    Groups.Last().WDays[i].Lessons[j % 2].Add(new Lesson(
                        SrcSheet.Cell(j + 4, column).Value.ToString(),
                        SrcSheet.Cell(j + 4, column+1).Value.ToString(),
                        SrcSheet.Cell(j + 4, column+2).Value.ToString(),
                        SrcSheet.Cell(j + 4, column+3).Value.ToString()
                    ));
                }
            }
        }
        private void LogText(String text) {
            Console.WriteLine(text);
        }
    }

    public class Group {
        public String Name { get; private set; }
        public List<WeekDay> WDays;
        public Group(String name) {
            Name = name;
            WDays = new List<WeekDay>();
        }

    }
    public class WeekDay
    {
        public List<List<Lesson>> Lessons;
        public WeekDay() {
            Lessons = new List<List<Lesson>>();
            Lessons.Add(new List<Lesson>());
            Lessons.Add(new List<Lesson>());
        }
    }
    public class Lesson
    {
        public String LName { get; private set; }
        public String LType { get; private set; }
        public String LTeach { get; private set; }
        public String LRoom { get; private set; }
        public Lesson(String lname, String ltype, String lteach, String lroom) {
            LName = lname;
            LType = ltype;
            LTeach = lteach;
            LRoom = lroom;
        }
    }
}
