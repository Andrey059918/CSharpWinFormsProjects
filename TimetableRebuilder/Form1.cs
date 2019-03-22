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
using OfficeOpenXml;
using TimetableRebuilder.DataClasses;
using TimetableRebuilder.Utils;

namespace TimetableRebuilder
{
    public partial class Form1 : Form
    {
        DataStorage Groups;
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
            CPF_Group.Tag = new Font("Segoe UI", 28, FontStyle.Bold);
            CPF_SubHead1.Tag = new Font("Segoe UI", 18, FontStyle.Bold);
            CPF_SubHead2.Tag = new Font("Segoe UI", 14, FontStyle.Bold);
            CPF_Table.Tag = new Font("Segoe UI", 12, FontStyle.Regular);
            CPF_TypeNumber.Tag = new Font("Segoe UI", 12, FontStyle.Bold);
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
            TeachBook.Dispose();
            List<String> files = new List<string>();
            foreach (Control gl in CPG_Selected.Controls)
            {
                if (!files.Contains(gl.Tag.ToString()))
                {
                    files.Add(gl.Tag.ToString());
                }
            }
            Groups = new DataStorage();
            foreach (String str in files)
            {
                LogText($"Получение расписаний из {str}");
                SrcBook = new ExcelPackage(new FileInfo(str));
                SrcSheet = SrcBook.Workbook.Worksheets[1];
                foreach (Control grlabel in CPG_Selected.Controls)
                {
                    LogText($"Получение расписания для {grlabel.Text}");
                    var cells = SrcSheet.Cells[2, 1, 2, SrcSheet.Dimension.Columns].Where(a => a.Text == grlabel.Text).ToList();
                    if (cells.Count == 1)
                    {
                        Int32 cellcol = cells[0].Start.Column;
                        Groups.AddGroup(grlabel.Text);
                        Groups.AddWeek(grlabel.Text);
                        Groups.AddWeek(grlabel.Text);
                        for (int i = 0; i < 6; i++)
                        {
                            Groups.AddDay(grlabel.Text, 0);
                            Groups.AddDay(grlabel.Text, 1);
                            for (int j = 0; j < 12; j++)
                            {
                                Groups.AddLesson(grlabel.Text, j % 2, i,
                                    SrcSheet.Cells[12 * i + 4 + j, 0 + cellcol].Text,
                                    String.Concat(SrcSheet.Cells[12 * i + 4 + j, 1 + cellcol].Text.Split('\n')),
                                    ReplaceTeacher(SrcSheet.Cells[12 * i + 4 + j, 2 + cellcol].Text),
                                    SrcSheet.Cells[12 * i + 4 + j, 3 + cellcol].Text
                                );

                                /*Groups[Groups.GroupCount-1][j%2,i].AddLesson(
                                    SrcSheet.Cells[12 * i + 4 + j, 0 + cellcol].Text,
                                    String.Concat(SrcSheet.Cells[12 * i + 4 + j, 1 + cellcol].Text.Split('\n')),
                                    ReplaceTeacher(SrcSheet.Cells[12 * i + 4 + j, 2 + cellcol].Text),
                                    SrcSheet.Cells[12 * i + 4 + j, 3 + cellcol].Text
                                );*/
                            }
                        }
                    }
                }
                SrcBook.Dispose();
                Groups.RemoveBlankLessons();
                Groups.RemoveBlankDays();
            }
            WriteTimetable();
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
                    SrcBook = new ExcelPackage(new FileInfo(path));
                    SrcSheet = SrcBook.Workbook.Worksheets[1];
                    var cells = SrcSheet.Cells[2, 1, 2, SrcSheet.Dimension.Columns].Where(a => a.Text.Length > 9 && a.Text[a.Text.Length - 3] == '-').ToList();
                    if (cells.Count > 0)
                    {
                        foreach (ExcelRangeBase cell in cells)
                        {
                            LogText(cell.Value.ToString());
                            CPG_Finded.Controls.Add(new Label()
                            {
                                Text = cell.Value.ToString(),
                                Width = CPG_Finded.ClientSize.Width-25,
                                Tag = path
                            });
                            CPG_Finded.Controls[CPG_Finded.Controls.Count - 1].Click += (e1, e2) =>
                            {
                                if (CPG_Selected.Contains(e1 as Label)) { CPG_Finded.Controls.Add(e1 as Label); }
                                else { CPG_Selected.Controls.Add(e1 as Label); }
                            };
                        }
                    }
                    else
                    {
                        LogText("Файл не содержит расписание РТУ");
                    }
                    SrcBook.Dispose();
                }
                LogText("Сканирование файлов завершено");
                Control[] sortlist =new Control[CPG_Finded.Controls.Count];
                CPG_Finded.Controls.CopyTo(sortlist,0);
                sortlist.ToList().OrderBy(a => a.Tag.ToString() + a.Text.ToString()).ToList().ForEach(a => CPG_Finded.Controls.Add(a));
            }
            openfile.Dispose();
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

        private void button8_Click(object sender, EventArgs e)
        {
            CPG_Finded.Controls.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CPG_Finded.Controls.Count; i++) { CPG_Selected.Controls.Add(CPG_Finded.Controls[i]); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CPG_Selected.Controls.Count; i++) { CPG_Finded.Controls.Add(CPG_Selected.Controls[i]); }
        }




        public void WriteTimetable()
        {
            ExcelPackage ResBook = new ExcelPackage();
            ExcelWorksheet ResSheet = ResBook.Workbook.Worksheets.Add("Timetable");
            //Заполнение основных подзаголовков
            for (int i = 0; i < 4; i++)
            {
                ResSheet.Cells[1, i + 1].Style.Font.SetFromFont(CPF_SubHead2.Tag as Font);
                ResSheet.Cells[1, i + 1].Style.Fill.PatternType=OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ResSheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(CPC_1.BackColor);
                ResSheet.Cells[1, i + 1, 3, i + 1].Merge = true;
                ResSheet.Cells[1, i + 1].Value = textBox1.Text.Split(',')[i];
                ResSheet.Cells[1, i + 1].Style.TextRotation = 90;
            }
            //Регулировка размеров подзаголовков
            for (int i = 0; i < 3; i++)
            {
                ResSheet.Row(i + 1).Height = TextRenderer.MeasureText(ResSheet.Cells[i+1,1].Text, CPFC_SubHead2.Tag as Font).Width*2.5;
            }
            
            Int32 startrow, startcol;
            for (int group = 0; group < Groups.GroupList.Count; group++)
            {
                for (int week = 0; week < 2; week++)
                {
                    startrow = 4;
                    startcol = 5 + group * 8 + week * 4;
                    for (int day = 0; day < Groups.GroupList.ElementAt(group).Value[week].Count; day++)
                    {
                        for (int lesson = 0; lesson < Groups.GroupList.ElementAt(group).Value[week][day].Count; lesson++)
                        {
                            var cell = ResSheet.Cells[startrow + lesson, startcol + 2];
                            cell.IsRichText = true;
                            cell.Style.WrapText = true;
                            ResSheet.Cells[startrow + lesson, startcol].Value = Groups.GroupList.ElementAt(group).Value[week][day][lesson]._Name;
                            ResSheet.Cells[startrow + lesson, startcol + 1].Value = Groups.GroupList.ElementAt(group).Value[week][day][lesson]._Type;
                            cell.RichText.Add(Groups.GroupList.ElementAt(group).Value[week][day][lesson]._Teacher);
                            ResSheet.Cells[startrow + lesson, startcol + 3].Value = Groups.GroupList.ElementAt(group).Value[week][day][lesson]._Classroom;
                        }
                        startrow += Groups.GroupList.First().Value[0][day].Count;
                        ResSheet.Cells[startrow, 1, startrow, 20].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                    }
                }
            }
            //Заполнение дней недели
            Int32 stind = 4;
            for (int i = 0; i < Groups.GroupList.ElementAt(0).Value[0].Count; i++)
            {
                ResSheet.Cells[stind, 1].Style.Font.SetFromFont(CPF_SubHead1.Tag as Font);
                ResSheet.Cells[stind, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ResSheet.Cells[stind, 1].Style.Fill.BackgroundColor.SetColor(ColorButtons[i + 4].BackColor);
                ResSheet.Cells[stind, 1, stind + Groups.GroupList.ElementAt(0).Value[0][i].Count - 1, 1].Merge = true;
                ResSheet.Cells[stind, 1].Value = textBox3.Text.Split(',')[i];
                ResSheet.Cells[stind, 1].Style.TextRotation = 90;
                Double WeekDaySize = TextRenderer.MeasureText(textBox3.Text.Split(',')[i], CPF_SubHead1.Tag as Font).Width / Groups.GroupList.ElementAt(0).Value[0][i].Count;
                for (int j = 0; j < Groups.GroupList.ElementAt(0).Value[0][i].Count; j++)
                {
                    ResSheet.Row(stind).Height = Math.Max(WeekDaySize, ResSheet.Cells[stind,2,stind,ResSheet.Dimension.Columns].Select(a=>TextRenderer.MeasureText(a.Text, CPF_SubHead2.Tag as Font).Height).Max());
                    ResSheet.Cells[stind, 2].Value = j + 1;
                    ResSheet.Cells[stind, 3].Value = textBox4.Text.Split(',')[j];
                    ResSheet.Cells[stind, 4].Value = textBox5.Text.Split(',')[j];
                    stind++;
                }
                ResSheet.Cells[4, 2, ResSheet.Dimension.Rows - 3, 4].Style.Font.SetFromFont(CPF_SubHead2.Tag as Font);
                ResSheet.Cells[4, 2, ResSheet.Dimension.Rows - 3, 4].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ResSheet.Cells[4, 2, ResSheet.Dimension.Rows - 3, 4].Style.Fill.BackgroundColor.SetColor(ColorButtons[10].BackColor);
            }
            for (int i = 2; i < ResSheet.Dimension.Columns; i++) {
                ResSheet.Column(i).Width=ResSheet.Cells[(i<5)?4:3,i,ResSheet.Dimension.Rows,i].Select(a => TextRenderer.MeasureText(a.Text, new Font(a.Style.Font.Name,a.Style.Font.Size)).Width).Max()/7;
            }

            ResBook.SaveAs(new FileInfo("NewTimeTable.xlsx"));
            System.Diagnostics.Process.Start("NewTimeTable.xlsx");
        }


    }
}
