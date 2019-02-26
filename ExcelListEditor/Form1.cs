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
using Excel = Microsoft.Office.Interop.Excel;
using VBasic=Microsoft.VisualBasic.Interaction;

namespace ExcelListEditor
{
    public partial class Form1 : Form
    {
        Excel.Application ExApp;
        Excel.Workbook ResultBook;
        Excel.Worksheet ResultSheet;
        String TeachPath;
        List<String> Teachers;
        List<Button> ColorButtons;
        List<Button> CB_Buttons;
        ColorDialog selcolor;


        public Form1()
        {
            InitializeComponent();
            PreparePanelSwitch();
            SelectPanel(CB_Groups, EventArgs.Empty);
            DefaultFonts();
            selcolor = new ColorDialog();
            ColorButtons = CP_Colors.Controls.Cast<Button>().OrderBy(a => Convert.ToInt32(a.Name.Substring(4))).ToList();
            Size = new Size(686, 409);
        }
        private void PreparePanelSwitch() {
            CB_Buttons = new List<Button>();
            CB_Buttons.Add(CB_Groups);
            CB_Buttons.Add(CB_Colors);
            CB_Buttons.Add(CB_Fonts);
            CB_Buttons.Add(CB_Ending);
            CB_Groups.Tag = CP_Groups;
            CB_Colors.Tag = CP_Colors;
            CB_Fonts.Tag = CP_Fonts;
            CB_Ending.Tag = CP_Ending;
            CB_Buttons.ForEach(a => (a.Tag as Panel).Location = new Point(210, 10));
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
        private void SelectTableColor(object sndr, EventArgs args)
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
        private void SelectFontColor(object sndr, EventArgs args)
        {
            selcolor.Color = (sndr as Button).BackColor;
            if (selcolor.ShowDialog() == DialogResult.OK)
            {
                (sndr as Button).BackColor = selcolor.Color;
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
            String[] Days = new String[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            String[] Cols1 = new String[] { "Д. недели", "№ пары", "Начало", "Конец" };
            String[] Cols2 = new String[] { "Предмет", "Тип", "Преподаватель", "Ауд." };
            String[] ClassTime = new String[] { "9-00", "10-30", "10-40", "12-10", "13-00", "14-30", "14-40", "16-10", "16-20", "17-50", "18-00", "19-30" };
            {
                ExApp = new Excel.Application()
                {
                    Visible = false
                };
                //Создание книги и листа
                ResultBook = ExApp.Workbooks.Add();
                ResultSheet = ResultBook.Worksheets.Add();
                ResultSheet.Name = "TimeTable";
                ResultSheet.Range[ResultSheet.Cells[1, 1], ResultSheet.Cells[39, 4 + CPG_GPanel.Controls.Count * 8]].Borders.Item[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                ResultSheet.Range[ResultSheet.Cells[1, 1], ResultSheet.Cells[39, 4 + CPG_GPanel.Controls.Count * 8]].Borders.Item[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                ResultSheet.Range[ResultSheet.Cells[1, 1], ResultSheet.Cells[39, 4 + CPG_GPanel.Controls.Count * 8]].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                ResultSheet.Range[ResultSheet.Cells[1, 1], ResultSheet.Cells[39, 4 + CPG_GPanel.Controls.Count * 8]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //Подзаголовки
                ResultSheet.Range["A1", "D1"].Interior.Color = ColorButtons[0].BackColor;
                ResultSheet.Range["A1", "D1"].Orientation = 90;
                FontSet(ResultSheet.Range["A1", "D1"], CPF_SubHead2.Tag as Font, CPFC_SubHead2.BackColor);
                for (int i = 0; i < 4; i++)
                {
                    ResultSheet.Range[ResultSheet.Cells[1, i + 1], ResultSheet.Cells[3, i + 1]].Merge();
                    ResultSheet.Cells[1, i + 1] = Cols1[i];
                }
                //Дни недели
                FontSet(ResultSheet.Range["A4", "A39"], CPF_SubHead1.Tag as Font, CPFC_SubHead1.BackColor);
                for (int i = 0; i < 6; i++)
                {
                    ResultSheet.Range["A" + (6 * i + 4).ToString(), "A" + (6 * i + 9).ToString()].Merge();
                    ResultSheet.Cells[i * 6 + 4, 1].Interior.Color = ColorButtons[i + 4].BackColor;
                    ResultSheet.Cells[i * 6 + 4, 1] = Days[i];
                    ResultSheet.Cells[i * 6 + 4, 1].Orientation = 90;
                }
                //Номера и время пар
                ResultSheet.Range[ResultSheet.Cells[4, 2], ResultSheet.Cells[39, 4]].Interior.Color = ColorButtons[10].BackColor;
                FontSet(ResultSheet.Range["B4", "D39"], CPF_SubHead2.Tag as Font, CPFC_SubHead2.BackColor);
                ResultSheet.Range[ResultSheet.Cells[4, 2], ResultSheet.Cells[39, 4]].NumberFormat = "@";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        ResultSheet.Cells[i * 6 + 4 + j, 2] = j + 1;
                        ResultSheet.Cells[i * 6 + 4 + j, 3] = ClassTime[2 * j].ToString();
                        ResultSheet.Cells[i * 6 + 4 + j, 4] = ClassTime[2 * j + 1].ToString();
                    }
                }
                //Границы
                BorderSet(ResultSheet.Range["A1", "D3"]);
                BorderSet(ResultSheet.Range["A4", "D9"]);
                BorderSet(ResultSheet.Range["A10", "D15"]);
                BorderSet(ResultSheet.Range["A16", "D21"]);
                BorderSet(ResultSheet.Range["A22", "D27"]);
                BorderSet(ResultSheet.Range["A28", "D33"]);
                BorderSet(ResultSheet.Range["A34", "D39"]);
            }//Заготовка под расписание
            if (TeacherCheckbox.Checked) {
                Teachers = new List<string>();
                Excel.Workbook TeachBook = ExApp.Workbooks.Open(TeachPath);
                Excel.Worksheet TeachSheet = TeachBook.Worksheets[1];
                for (int i = 0; i < TeachSheet.UsedRange.Rows.Count; i++) {
                    if (!Teachers.Contains(TeachSheet.Cells[i + 1, 1].Text))
                    {
                        Teachers.Add(TeachSheet.Cells[i + 1, 1].Text);
                    }
                }
            }
            foreach (Control TLabel in CPG_TPanel.Controls)
            {
                Excel.Workbook SourceBook = ExApp.Workbooks.Open(TLabel.Tag.ToString());
                Excel.Worksheet SourceSheet = SourceBook.Worksheets[1];
                foreach (Control GLabel in CPG_GPanel.Controls)
                {
                    try
                    {//FontSet(ResultSheet.Range[ResultSheet.Cells[], ResultSheet.Cells[]], CPF_Group.Tag as Font, CPFC_Group.BackColor);
                        Int32 GIndex = CPG_GPanel.Controls.GetChildIndex(GLabel);
                        Int32 GCol = SourceSheet.Cells.Find(GLabel.Text).Column;
                        //Название группы
                        BorderSet(ResultSheet.Range[ResultSheet.Cells[1, 5 + GIndex * 8], ResultSheet.Cells[1, 12 + GIndex * 8]]);
                        ResultSheet.Range[ResultSheet.Cells[1, 5 + GIndex * 8], ResultSheet.Cells[1, 12 + GIndex * 8]].Merge();
                        ResultSheet.Cells[1, 5 + GIndex * 8] = GLabel.Text;
                        ResultSheet.Cells[1, 5 + GIndex * 8].Interior.Color = ColorButtons[1].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[1, 5 + GIndex * 8], ResultSheet.Cells[1, 12 + GIndex * 8]], CPF_Group.Tag as Font, CPFC_Group.BackColor);
                        //Нечетные
                        BorderSet(ResultSheet.Range[ResultSheet.Cells[2, 5 + GIndex * 8], ResultSheet.Cells[3, 8 + GIndex * 8]]);
                        ResultSheet.Range[ResultSheet.Cells[2, 5 + GIndex * 8], ResultSheet.Cells[2, 8 + GIndex * 8]].Merge();
                        ResultSheet.Cells[2, 5 + GIndex * 8] = "Нечетные";
                        FontSet(ResultSheet.Range[ResultSheet.Cells[2, 5 + GIndex * 8], ResultSheet.Cells[2, 8 + GIndex * 8]], CPF_SubHead1.Tag as Font, CPFC_SubHead1.BackColor);
                        ResultSheet.Cells[2, 5 + GIndex * 8].Interior.Color = ColorButtons[2].BackColor;
                        //Четные
                        BorderSet(ResultSheet.Range[ResultSheet.Cells[2, 9 + GIndex * 8], ResultSheet.Cells[3, 12 + GIndex * 8]]);
                        ResultSheet.Range[ResultSheet.Cells[2, 9 + GIndex * 8], ResultSheet.Cells[2, 12 + GIndex * 8]].Merge();
                        ResultSheet.Cells[2, 9 + GIndex * 8] = "Четные";
                        FontSet(ResultSheet.Range[ResultSheet.Cells[2, 9 + GIndex * 8], ResultSheet.Cells[2, 12 + GIndex * 8]], CPF_SubHead1.Tag as Font, CPFC_SubHead1.BackColor);
                        ResultSheet.Cells[2, 9 + GIndex * 8].Interior.Color = ColorButtons[3].BackColor;
                        //Подзаголовки пар
                        ResultSheet.Range[ResultSheet.Cells[3, 5 + GIndex * 8], ResultSheet.Cells[3, 8 + GIndex * 8]].Interior.Color = ColorButtons[2].BackColor;
                        ResultSheet.Range[ResultSheet.Cells[3, 9 + GIndex * 8], ResultSheet.Cells[3, 12 + GIndex * 8]].Interior.Color = ColorButtons[3].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[3, 5 + GIndex * 8], ResultSheet.Cells[3, 12 + GIndex * 8]], CPF_SubHead2.Tag as Font, CPFC_SubHead2.BackColor);
                        for (int i = 0; i < 4; i++)
                        {
                            ResultSheet.Cells[3, 5 + GIndex * 8 + i] = Cols2[i];
                            ResultSheet.Cells[3, 9 + GIndex * 8 + i] = Cols2[i];
                        }
                        //Расписание пар
                        ResultSheet.Range[ResultSheet.Cells[4, 5 + GIndex * 8], ResultSheet.Cells[39, 5 + GIndex * 8]].Interior.Color = ColorButtons[11].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 5 + GIndex * 8], ResultSheet.Cells[39, 5 + GIndex * 8]], CPF_Table.Tag as Font, CPFC_Table.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 6 + GIndex * 8], ResultSheet.Cells[39, 6 + GIndex * 8]].Interior.Color = ColorButtons[12].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 6 + GIndex * 8], ResultSheet.Cells[39, 6 + GIndex * 8]], CPF_TypeNumber.Tag as Font, CPFC_TypeNumber.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 7 + GIndex * 8], ResultSheet.Cells[39, 7 + GIndex * 8]].Interior.Color = ColorButtons[13].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 7 + GIndex * 8], ResultSheet.Cells[39, 7 + GIndex * 8]], CPF_Table.Tag as Font, CPFC_Table.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 8 + GIndex * 8], ResultSheet.Cells[39, 8 + GIndex * 8]].Interior.Color = ColorButtons[14].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 8 + GIndex * 8], ResultSheet.Cells[39, 8 + GIndex * 8]], CPF_TypeNumber.Tag as Font, CPFC_TypeNumber.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 9 + GIndex * 8], ResultSheet.Cells[39, 9 + GIndex * 8]].Interior.Color = ColorButtons[15].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 9 + GIndex * 8], ResultSheet.Cells[39, 9 + GIndex * 8]], CPF_Table.Tag as Font, CPFC_Table.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 10 + GIndex * 8], ResultSheet.Cells[39, 10 + GIndex * 8]].Interior.Color = ColorButtons[16].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 10 + GIndex * 8], ResultSheet.Cells[39, 10 + GIndex * 8]], CPF_TypeNumber.Tag as Font, CPFC_TypeNumber.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 11 + GIndex * 8], ResultSheet.Cells[39, 11 + GIndex * 8]].Interior.Color = ColorButtons[17].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 11 + GIndex * 8], ResultSheet.Cells[39, 11 + GIndex * 8]], CPF_Table.Tag as Font, CPFC_Table.BackColor);
                        ResultSheet.Range[ResultSheet.Cells[4, 12 + GIndex * 8], ResultSheet.Cells[39, 12 + GIndex * 8]].Interior.Color = ColorButtons[18].BackColor;
                        FontSet(ResultSheet.Range[ResultSheet.Cells[4, 12 + GIndex * 8], ResultSheet.Cells[39, 12 + GIndex * 8]], CPF_TypeNumber.Tag as Font, CPFC_TypeNumber.BackColor);
                        for (int i = 0; i < 6; i++)
                        {
                            BorderSet(ResultSheet.Range[ResultSheet.Cells[4 + 6 * i, 5 + GIndex * 8], ResultSheet.Cells[9 + 6 * i, 8 + GIndex * 8]]);
                            BorderSet(ResultSheet.Range[ResultSheet.Cells[4 + 6 * i, 9 + GIndex * 8], ResultSheet.Cells[9 + 6 * i, 12 + GIndex * 8]]);
                            for (int j = 0; j < 12; j++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    if (k == 1)
                                    {
                                        ResultSheet.Cells[6 * i + 4 + j / 2, j % 2 * 4 + k + 5 + GIndex * 8] = String.Concat(SourceSheet.Cells[12 * i + 4 + j, k + GCol].Text.Split('\n'));
                                    }
                                    else if (k == 2 && TeacherCheckbox.Checked) {
                                        ResultSheet.Cells[6 * i + 4 + j / 2, j % 2 * 4 + k + 5 + GIndex * 8] = ReplaceTeacher(SourceSheet.Cells[12 * i + 4 + j, k + GCol].Text);
                                    }
                                    else
                                    {
                                        ResultSheet.Cells[6 * i + 4 + j / 2, j % 2 * 4 + k + 5 + GIndex * 8] = SourceSheet.Cells[12 * i + 4 + j, k + GCol];
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
            

            //Общие параметры листа
            ResultSheet.UsedRange.Columns.AutoFit();
            ResultSheet.UsedRange.Rows.AutoFit();
            ResultBook.SaveAs(Path.GetFullPath("ResultBook.xlsx"));
            ExApp.Quit();
            if (MessageBox.Show("Создание файла завершено.\nВыйти?", "Готово!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            /*
        {
            List<String> fullprepods = new List<string>();
            List<String> shortprepods = new List<string>();
            Excel.Application PrepApp = new Excel.Application()
            {
                Visible = false
            };
            Excel.Workbook PrepBook = PrepApp.Workbooks.Open(Path.GetFullPath("prep.xlsx"));
            Excel.Worksheet PrepS1 = PrepBook.Sheets[1];
            for (int i = 0; i < PrepS1.UsedRange.Rows.Count; i++)
            {
                fullprepods.Add(PrepS1.Cells[i + 1, 1].Text);
            }
            PrepApp.Quit();
        }//Редактируем преподавателей
        //ExApp.Visible = true;*/
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

        private void BorderSet(Excel.Range range)
        {
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
            range.Borders.Item[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
        }
        private void FontSet(Excel.Range range, Font font,Color color) {
            range.Font.Name = font.Name;
            range.Font.Size = font.SizeInPoints;
            range.Font.Bold = font.Bold;
            range.Font.Italic = font.Italic;
            range.Font.Underline = font.Underline;
            range.Font.Strikethrough = font.Strikeout;
            range.Font.Color = color;
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
    }
}
