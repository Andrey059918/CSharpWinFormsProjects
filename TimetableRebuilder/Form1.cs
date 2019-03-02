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
using ExcelNumberFormat;
using VBasic = Microsoft.VisualBasic.Interaction;
using OfficeOpenXml;

namespace TimetableRebuilder
{
    public partial class Form1 : Form
    {
        Dictionary<String, List<WeekDay>> Groups;
        ExcelPackage SrcBook;
        ExcelWorksheet SrcSheet;

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
        private void PreparePanelSwitch()
        {
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
            CB_Groups.SendToBack();
            SelectPanel(CB_Groups, EventArgs.Empty);
        }
        private void DefaultFonts()
        {
            CPF_Group.Tag = new Font("Segoe UI", 32, FontStyle.Bold);
            CPF_SubHead1.Tag = new Font("Segoe UI", 24, FontStyle.Bold);
            CPF_SubHead2.Tag = new Font("Segoe UI", 20, FontStyle.Bold);
            CPF_Table.Tag = new Font("Segoe UI", 16, FontStyle.Regular);
            CPF_TypeNumber.Tag = new Font("Segoe UI", 16, FontStyle.Bold);
        }


        private void SelectPanel(object sndr, EventArgs args)
        {
            CP_Base.SendToBack();
            CB_Buttons.ForEach(a =>
            {
                if (sndr as Button == a)
                {
                    a.BackColor = ColorTranslator.FromHtml("ControlLightLight");
                    (a.Tag as Panel).Visible = true;
                }
                else
                {
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
        private void SelectFont(object sndr, EventArgs args)
        {
            FontDialog SelFont = new FontDialog() { ShowColor = false, ShowEffects = true, Font = (sndr as Button).Tag as Font };
            if (SelFont.ShowDialog() == DialogResult.OK)
            {
                (sndr as Button).Tag = SelFont.Font;
                (sndr as Button).Text = String.Concat(SelFont.Font.Name, "; ", Math.Round(SelFont.Font.SizeInPoints),
                    SelFont.Font.Bold ? "; Bold" : "", SelFont.Font.Italic ? "; Italic" : "", SelFont.Font.Underline ? "; Underline" : "", SelFont.Font.Strikeout ? "; Strikeout" : "");
            }
        }


        private void GetTimetable_Click(object sender, EventArgs e)
        {
            Teachers = new List<string>();
            ExcelPackage TeachBook = new ExcelPackage(new FileInfo(TeachPath));
            ExcelWorksheet TeachSheet = TeachBook.Workbook.Worksheets[1];
            for (int i = 1; i < TeachSheet.Dimension.Rows; i++)
            {
                if (!Teachers.Contains(TeachSheet.Cells[i + 1, 1].Text))
                {
                    Teachers.Add(TeachSheet.Cells[i + 1, 1].Text);
                }
            }
            List<String> files = new List<string>();
            foreach (Control gl in CPG_Selected.Controls)
            {
                if (!files.Contains(gl.Tag.ToString()))
                {
                    files.Add(gl.Tag.ToString());
                }
            }
            foreach (String str in files)
            {
                Groups = new Dictionary<string, List<WeekDay>>();
                LogText($"Получение расписаний из {str}");
                SrcBook = new ExcelPackage(new FileInfo(str));
                SrcSheet = SrcBook.Workbook.Worksheets[1];
                foreach (Control grlabel in CPG_Selected.Controls)
                {
                    LogText($"Получение расписания для {grlabel.Text}");
                    var cells = SrcSheet.Cells[2, 1, 2, SrcSheet.Dimension.Columns].Where(a => a.Text==CPG_Selected.Controls[0].Text).ToList();
                    if (cells.Count == 1)
                    {
                        Int32 cellcol = cells[0].Start.Column;
                        Groups.Add(grlabel.Text, new List<WeekDay>());
                        for (int i = 0; i < 6; i++)
                        {
                            Groups.Last().Value.Add(new WeekDay());
                            for (int j = 0; j < 12; j++)
                            {
                                Groups.Last().Value.Last().Lessons[j % 2].Add(new Lesson(
                                    SrcSheet.Cells[12 * i + 4 + j, 0 + cellcol].Text,
                                    String.Concat(SrcSheet.Cells[12 * i + 4 + j, 1 + cellcol].Text.Split('\n')),
                                    ReplaceTeacher(SrcSheet.Cells[12 * i + 4 + j, 2 + cellcol].Text),
                                    SrcSheet.Cells[12 * i + 4 + j, 3 + cellcol].Text
                                    ));
                            }
                        }
                    }
                }
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
                    if (TTeachers.Where(a => a.Split(' ')[1].StartsWith(Tshort.Split(' ')[1].Split('.')[0]) && a.Split(' ')[2].StartsWith(Tshort.Split(' ')[1].Split('.')[1])).Count() == 1)
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
        
        private void LogText(String text)
        {
            Console.WriteLine(text);
        }

        private void CPG_FileScan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Title = "Выберите таблицу Excel с расписанием...",
                Filter = "Файлы Excel: *.xls; *.xlsx; *.xlsm|*.xls;*.xlsx;*.xlsm",
                Multiselect = true
            };
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                LogText($"Выбрано файлов:{openfile.FileNames.Count()}");
                foreach (var path in openfile.FileNames)
                {
                    LogText($"Анализ файла {Path.GetFileName(path)} из {Path.GetDirectoryName(path)}");
                    using (SrcBook = new ExcelPackage(new FileInfo(path)))
                    {
                        SrcSheet = SrcBook.Workbook.Worksheets[1];
                        var cells = SrcSheet.Cells[2,1,2,SrcSheet.Dimension.Columns].Where(a => a.Text.Length > 9 && a.Text[a.Text.Length - 3] == '-').ToList();
                        if (cells.Count > 0)
                        {
                            foreach (ExcelRangeBase cell in cells)
                            {
                                LogText(cell.Value.ToString());
                                CPG_Finded.Controls.Add(new Label()
                                {
                                    Text = cell.Value.ToString(),
                                    Width = CPG_Finded.ClientSize.Width,
                                    Tag = path
                                });
                                CPG_Finded.Controls[CPG_Finded.Controls.Count - 1].Click += (e1, e2) => {
                                    if (CPG_Selected.Contains(e1 as Label)) { CPG_Finded.Controls.Add(e1 as Label); }
                                    else { CPG_Selected.Controls.Add(e1 as Label); }
                                };
                            }
                        }
                        else
                        {
                            LogText("Файл не содержит расписание РТУ");
                        }
                    }
                }
                LogText("Сканирование файлов завершено");
            }
        }

    }

    public class WeekDay
    {
        public List<List<Lesson>> Lessons;
        public WeekDay()
        {
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
        public Lesson(String lname, String ltype, String lteach, String lroom)
        {
            LName = lname;
            LType = ltype;
            LTeach = lteach;
            LRoom = lroom;
        }
    }
}
