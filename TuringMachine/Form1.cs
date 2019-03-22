using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using OfficeOpenXml;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        private List<ToolStripMenuItem> GroupedDelayItems;

        private Button SelectedState;
        private Button SelectedTapeCell;
        private Int32 SelectedTapeValue;
        private List<Char> UsedChars = new List<char>();
        private Dictionary<int, char> TapeValues = new Dictionary<int, char>();
        private Point TapeIndexes = new Point(0, -1);
        private Int32 TapeDisplay = 0;


        public Form1()
        {
            InitializeComponent();
            GroupControls();
            SetEvents();
            //CreateRow(null, EventArgs.Empty);
            UsedChars.Add(' ');
            Size = Screen.PrimaryScreen.WorkingArea.Size.Div(2);
        }
        private void SetEvents()
        {
            SizeChanged += (sender, args) => CorrectLayout();
            _TapeCellLeft.Click += (sender, args) => RedrawTape(-1);
            _TapeCellRight.Click += (sender, args) => RedrawTape(1);
            _TapePageLeft.Click += (sender, args) => RedrawTape(-10);
            _TapePageRight.Click += (sender, args) => RedrawTape(10);
        }
        private void GroupControls()
        {
            GroupedDelayItems = new List<ToolStripMenuItem>() {
                _MenuSimulationDelay0, _MenuSimulationDelay100,
                _MenuSimulationDelay250, _MenuSimulationDelay500,
                _MenuSimulationDelay1000,_MenuSimulationDelayCustom
            };
        }


        private void CreateTape()
        {
            while (_TapePanel.PreferredSize.Width <= _TapePanel.Width)
            {
                _TapePanel.Controls.Add(new Button()
                {
                    Size = new Size(30, 40),
                    Margin = Padding.Empty,
                    Text = "",
                    FlatStyle = 0,
                    Font = new Font("Segoe UI", 12,FontStyle.Bold)
                });
                _TapePanel.Controls[_TapePanel.Controls.Count - 1].MouseDown += (e1, e2) =>
                {
                    if (e2.Button == MouseButtons.Right)
                    {
                        ChangeTapeCell(e1 as Button);
                    }
                };
                _TapePanel.Controls[_TapePanel.Controls.Count - 1].KeyPress += (e1, e2) =>
                {
                    if (UsedChars.Contains(e2.KeyChar))
                    {
                        (e1 as Button).Text = e2.KeyChar.ToString();
                        TapeValues[TapeDisplay + _TapePanel.Controls.GetChildIndex(e1 as Button)] = e2.KeyChar;
                    }
                    _TapePanel.Focus();
                };
            }
            if (_TapePanel.PreferredSize.Width > _TapePanel.Width + 30)
            {
                _TapePanel.Controls.RemoveAt(_TapePanel.Controls.Count - 1);
            }
        }
        private void RedrawTape(Int32 shift = 0)
        {
            TapeDisplay += shift;
            while (TapeDisplay < TapeIndexes.X)
            {
                TapeValues.Add(--TapeIndexes.X, ' ');
            }
            while (TapeDisplay + _TapePanel.Controls.Count > TapeIndexes.Y)
            {
                TapeValues.Add(++TapeIndexes.Y, ' ');
            }
            for (int i = 0; i < _TapePanel.Controls.Count; i++)
            {
                _TapePanel.Controls[i].Text = TapeValues[i + TapeDisplay].ToString();
            }
            if (SelectedTapeValue < TapeDisplay + _TapePanel.Controls.Count && SelectedTapeValue > TapeDisplay)
            {
                ChangeTapeCell(_TapePanel.Controls[SelectedTapeValue - TapeDisplay] as Button);
            }
        }
        private void CorrectLayout()
        {
            _ProgPanel.Width = Width - 126;
            _TapePanel.Width = Width - 176;
            _DescriptionPanel.Width = Width - 36;
            _ToolsStatus.Width = Width - 36;
            if (Height > 800)
            {
                _DescriptionPanel.Height = 150;
                _TapeLabel.Location = new Point(10, 220);
                _TapePageLeft.Location = new Point(10, 240);
                _TapeCellLeft.Location = new Point(50, 240);
                _TapePanel.Location = new Point(80, 240);
                _TapeCellRight.Location = new Point(Size.Width - 96, 240);
                _TapePageRight.Location = new Point(Size.Width - 66, 240);
                _ProgLabel.Location = new Point(10, 300);
                _ProgPanel.Location = new Point(100, 320);
                _ProgControlPanel.Location = new Point(10, 320);
            }
            else
            {
                _DescriptionPanel.Height = 75;
                _TapeLabel.Location = new Point(10, 145);
                _TapePageLeft.Location = new Point(10, 165);
                _TapeCellLeft.Location = new Point(50, 165);
                _TapePanel.Location = new Point(80, 165);
                _TapeCellRight.Location = new Point(Size.Width - 96, 165);
                _TapePageRight.Location = new Point(Size.Width - 66, 165);
                _ProgLabel.Location = new Point(10, 225);
                _ProgPanel.Location = new Point(100, 245);
                _ProgControlPanel.Location = new Point(10, 245);
            }
            foreach (Control c in _ProgColumnComment.Controls)
            {
                Int32 width = 0;
                for (int i = 0; i < _ProgPanel.Controls.Count - 1; i++)
                {
                    width += _ProgPanel.Controls[i].Width;
                }
                c.Width = ((_ProgPanel.Width - width) > 300) ? (_ProgPanel.Width - width - 4) : 500;
            }
            _ProgPanel.Height = Height - _ProgPanel.Location.Y - 70;
            _ProgControlPanel.Height = _ProgPanel.Height;
            CreateTape();
            RedrawTape();
        }




        private void CreateRow(object sender, EventArgs e)
        {
            Button button = new Button()
            {
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = $"Q{_ProgPanel.Controls[0].Controls.Count}",
                Margin = Padding.Empty,
                Size = new Size(80, 32)
            };
            _ProgPanel.Controls[0].Controls.Add(button);
            button.MouseDown += (e1, e2) =>
            {
                if (e2.Button == MouseButtons.Right)
                {
                    ChangeState(e1 as Button);
                }
            };
            for (int i = 0; i < _ProgPanel.Controls.Count - 2; i++)
            {
                _ProgPanel.Controls[i + 1].Controls.Add(CreateCellButton($"{_ProgPanel.Controls[0].Controls.Count-1},{i+1}"));
            }
            _ProgPanel.Controls[_ProgPanel.Controls.Count - 1].Controls.Add(new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Microsoft Sans Serif", 12),
                TextAlign = HorizontalAlignment.Left,
                Margin = Padding.Empty,
                Width = _ProgColumnComment.Width,
                Multiline = true,
                Height = 32
            });
        }
        private Button CreateCellButton(String tag)
        {
            Button btn = new Button()
            {
                FlatStyle = FlatStyle.Flat,
                Size = new Size(60, 32),
                Margin = Padding.Empty,
                Font = new Font("Microsoft Sans Serif", 12),
                TextAlign = ContentAlignment.MiddleLeft
            };
            btn.KeyPress += (e1, e2) =>
            {
                if (btn.Text.Length == 0 && UsedChars.Contains(e2.KeyChar))
                {
                    btn.Text += e2.KeyChar;
                }
                else if (e2.KeyChar == 8 && btn.Text.Length > 0)
                {
                    btn.Text = btn.Text.Substring(0, btn.Text.Length - 1);
                }
                else
                {
                    char[] charr = new char[] { '>', '<', '|' };
                    if (charr.Contains(e2.KeyChar) && charr.All(a => !btn.Text.Contains(a)))
                    {
                        btn.Text += e2.KeyChar;
                    }
                    else if (Char.IsDigit(e2.KeyChar) && charr.Any(a => btn.Text.Contains(a)) &&
                    (btn.Text.Split(charr.First(a => btn.Text.Contains(a)))[1] + e2.KeyChar).Int() < _ProgPanel.Controls[1].Controls.Count)
                    {
                        btn.Text += e2.KeyChar;
                    }
                }
            };
            btn.PreviewKeyDown += (e1, e2) => PreviewKD(tag, e2);
            
            return btn;
        }
        private void PreviewKD(string tag, PreviewKeyDownEventArgs args)
        {
            if (args.KeyValue > 36 && args.KeyValue < 41)
            {
                args.IsInputKey = true;
                if (args.KeyCode == Keys.Left && tag.Split(',')[1].Int() > 1)
                {
                    _ProgPanel.Controls[tag.Split(',')[1].Int() - 1].Controls[tag.Split(',')[0].Int()].Focus();
                }
                else if (args.KeyCode == Keys.Right && tag.Split(',')[1].Int() < _ProgPanel.Controls.Count - 1)
                {
                    _ProgPanel.Controls[tag.Split(',')[1].Int() + 1].Controls[tag.Split(',')[0].Int()].Focus();
                }
                else if (args.KeyCode == Keys.Up && tag.Split(',')[0].Int() > 0)
                {
                    _ProgPanel.Controls[tag.Split(',')[1].Int()].Controls[tag.Split(',')[0].Int() - 1].Focus();
                }
                else if (args.KeyCode == Keys.Down && tag.Split(',')[0].Int() < _ProgPanel.Controls[0].Controls.Count - 1)
                {
                    _ProgPanel.Controls[tag.Split(',')[1].Int()].Controls[tag.Split(',')[0].Int() + 1].Focus();
                }
            }
        }
        private void CreateCol(object sender, EventArgs e)
        {
            FlowLayoutPanel flpanel = new FlowLayoutPanel()
            {
                BorderStyle = BorderStyle.None,
                Margin = Padding.Empty,
                AutoSize = true,
                WrapContents = false,
                FlowDirection = FlowDirection.TopDown
            };
            _ProgPanel.Controls.Add(flpanel);
            _ProgPanel.Controls.SetChildIndex(_ProgColumnComment, _ProgPanel.Controls.Count - 1);
            Button button = new Button()
            {
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "",
                Margin = Padding.Empty,
                Size = new Size(60, 42)
            };
            flpanel.Controls.Add(button);
            button.KeyPress += (e1, e2) =>
            {
                if (Char.IsLetterOrDigit(e2.KeyChar) || "-".Contains(e2.KeyChar))
                {
                    if (button.Text.Length != 0) { UsedChars.Remove(button.Text[0]); }
                    button.Text = e2.KeyChar.ToString();
                    UsedChars.Add(button.Text[0]);
                }
                _ProgPanel.Focus();
            };
            button.PreviewKeyDown += (e1, e2) => PreviewKD($"0,{_ProgPanel.Controls.Count - 2}", e2);
            for (int i = 0; i < _ProgPanel.Controls[0].Controls.Count - 1; i++)
            {
                _ProgPanel.Controls[_ProgPanel.Controls.Count - 2].Controls.Add(CreateCellButton($"{i + 1},{_ProgPanel.Controls.Count - 2}"));
            }
            CorrectLayout();
        }
        private void ChangeState(Button sender)
        {
            if (SelectedState != null)
            {
                SelectedState.BackColor = SystemColors.ButtonHighlight;
            }
            SelectedState = sender;
            SelectedState.BackColor = Color.FromArgb(220, 255, 220);
        }
        private void ChangeTapeCell(Button sender)
        {
            if (SelectedTapeCell != null)
            {
                SelectedTapeCell.BackColor = SystemColors.ButtonHighlight;
            }
            SelectedTapeCell = sender;
            SelectedTapeValue = _TapePanel.Controls.GetChildIndex(SelectedTapeCell) + TapeDisplay;
            SelectedTapeCell.BackColor = Color.FromArgb(220, 255, 220);
        }

        private void _MenuSimulationDelayChange(object sender, EventArgs e)
        {
            _MenuSimulationDelay0.Checked = false;
            _MenuSimulationDelay100.Checked = false;
            _MenuSimulationDelay250.Checked = false;
            _MenuSimulationDelay500.Checked = false;
            _MenuSimulationDelay1000.Checked = false;
            _MenuSimulationDelayCustom.Checked = false;
            (sender as ToolStripMenuItem).Checked = true;
        }
        private void _MenuSimulationDelayType(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && (_MenuSimulationDelayValue.Text + e.KeyChar).Int() < 10000 && (_MenuSimulationDelayValue.Text + e.KeyChar).Int() != 0)
            {
                _MenuSimulationDelayChange(_MenuSimulationDelayCustom, EventArgs.Empty);
            }
            else if (e.KeyChar == 8)
            {
                if (_MenuSimulationDelayValue.Text.Length == 1)
                {
                    _MenuSimulationDelayChange(_MenuSimulationDelay0, EventArgs.Empty);
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void _MenuSimulationStart_Click(object sender, EventArgs e)
        {
            if (_MenuSimulationDelay0.Checked)
            {
                while (DoMachineTick()) { }
                MessageBox.Show("Выполнение программы завершено!", "Конец", MessageBoxButtons.OK);
            }
            else
            {
                if (_MenuSimulationDelay100.Checked) { _ProgTimer.Interval = 100; }
                else if (_MenuSimulationDelay250.Checked) { _ProgTimer.Interval = 250; }
                else if (_MenuSimulationDelay500.Checked) { _ProgTimer.Interval = 500; }
                else if (_MenuSimulationDelay1000.Checked) { _ProgTimer.Interval = 1000; }
                else if (_MenuSimulationDelayCustom.Checked) { _ProgTimer.Interval = _MenuSimulationDelayValue.Text.Int(); }
                _ProgTimer.Start();

            }
        }
        private Boolean DoMachineTick()
        {
            if (SelectedTapeCell != null && SelectedState != null)
            {
                char[] charr = new char[] { '>', '<', '|' };
                Int32 CharValue = 0;
                for (int i = 1; i < _ProgPanel.Controls.Count; i++)
                {
                    if (SelectedTapeCell.Text == _ProgPanel.Controls[i].Controls[0].Text)
                    {
                        CharValue = i;
                    }
                }
                Int32 StateValue = _ProgPanel.Controls[0].Controls.GetChildIndex(SelectedState);
                String CellValue = _ProgPanel.Controls[CharValue].Controls[StateValue].Text;
                if (charr.Any(a => CellValue.Contains(a)))
                {
                    List<String> Input = CellValue.Split(charr.First(a => CellValue.Contains(a))).ToList();
                    Input.Add(charr.First(a => CellValue.Contains(a)).ToString());
                    Console.WriteLine(Input[0]);
                    if (Input[0] == "") { Input[0] = " "; }
                    if (Input[1] == "0") { return false; }
                    if (Input[1] == "") { Input[1] = StateValue.ToString(); }

                    TapeValues[TapeDisplay + _TapePanel.Controls.IndexOf(SelectedTapeCell)] = Input[0][0];
                    ChangeState(_ProgPanel.Controls[0].Controls[Input[1].Int()] as Button);
                    switch (Input[2][0])
                    {
                        case '<':
                            SelectedTapeValue--;
                            TapeDisplay--;
                            RedrawTape();
                            break;
                        case '>':
                            SelectedTapeValue++;
                            TapeDisplay++;
                            RedrawTape();
                            break;
                    }
                    return true;
                }
                else return false;
            }
            else return false;
        }

        private void _MenuSimulationStep_Click(object sender, EventArgs e)
        {
            if (!DoMachineTick()) { MessageBox.Show("Выполнение программы завершено!", "Конец", MessageBoxButtons.OK); }
        }
        private void _ProgTimer_Tick(object sender, EventArgs e)
        {
            if (!DoMachineTick()) {
                _ProgTimer.Stop();
                MessageBox.Show("Выполнение программы завершено!", "Конец", MessageBoxButtons.OK);
            }
        }
        private void _MenuSimulationStop_Click(object sender, EventArgs e)
        {
            _ProgTimer.Stop();
        }

        private void _MenuFileExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage Package = new ExcelPackage();
                ExcelWorksheet Sheet = Package.Workbook.Worksheets.Add("SavedData");
                Int32 TableWidth = _ProgPanel.Controls.Count - 2;

                //Запись параметров
                Sheet.Cells[1, 1].Value = "Parameters";
                for (int i = 0; i < 6; i++)
                {
                    Sheet.Cells[2, 1 + i].Value = GroupedDelayItems[i].Checked.Int();
                }
                Sheet.Cells[2, 7].Value = _MenuSimulationDelayValue.Text;
                Sheet.Cells[2, 8].Value = TableWidth;
                //Запись описания
                Sheet.Cells[4, 1].Value = "Description";
                Sheet.Cells[5, 1, 5, Math.Max(TableWidth + 1, 8)].Merge = true;
                Sheet.Cells[5, 1].Style.WrapText = true;
                Sheet.Cells[5, 1].RichText.Add(_DescriptionPanel.Text);
                //Запись ленты значений
                TapeValues.OrderBy(a => a.Key);
                var ValuesToSave = TapeValues.SkipWhileEnd(a => a.Value == ' ').SkipWhile(a => a.Value == ' ');
                Sheet.Cells[7, 1].Value = "Tape";
                Sheet.Cells[7, 2].Value = ValuesToSave.ElementAt(0).Key;
                Sheet.Cells[7, 3].Value = SelectedTapeValue;
                for (int i = 0; i < ValuesToSave.Count(); i++)
                {
                    Sheet.Cells[8 + i / TableWidth, 1 + i % TableWidth].Value = ValuesToSave.ElementAt(i).Value.ToString();
                }
                Int32 StartRow = ValuesToSave.Count() / TableWidth + 10;
                //Запись программы
                Sheet.Cells[StartRow, 1].Value = "Program";
                Sheet.Cells[StartRow, 2].Value = _ProgPanel.Controls[0].Controls.GetChildIndex(SelectedState);
                for (int i = 1; i < _ProgPanel.Controls.Count; i++)
                {
                    for (int j = 1; j < _ProgPanel.Controls[0].Controls.Count + 1; j++)
                    {
                        if (i == _ProgPanel.Controls[0].Controls.Count - 1)
                        {
                            Sheet.Cells[StartRow + j, i].Style.WrapText = true;
                            Sheet.Cells[StartRow + j, i].Style.Numberformat.Format = "@";
                            Sheet.Cells[StartRow + j, i].RichText.Add(_ProgPanel.Controls[i].Controls[j - 1].Text);
                        }
                        else
                        {
                            Sheet.Cells[StartRow + j, i].Style.Numberformat.Format = "@";
                            Sheet.Cells[StartRow + j, i].Value = _ProgPanel.Controls[i].Controls[j - 1].Text;
                        }
                    }
                }
                //Запрос сохранения файла
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    FileName = "FileToSave.xlsx",
                    Filter = "Excel tables (*.xlsx)|*.xlsx"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Package.SaveAs(new System.IO.FileInfo(dialog.FileName));
                }
                Package.Dispose();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }

        private void _MenuFileImportExcel_Click(object sender, EventArgs e)
        {
            //Запрос открытия файла
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Excel tables (*.xlsx)|*.xlsx"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TimetableRebuilder.LoaderDialog loader = new TimetableRebuilder.LoaderDialog();
                if (loader.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage Package = new ExcelPackage(new System.IO.FileInfo(dialog.FileName));
                    ExcelWorksheet Sheet = Package.Workbook.Worksheets[1];
                    Int32 TableWidth = Sheet.Cells[2, 8].Value.Int() - 1;

                    for (int i = 0; i < 6; i++)
                    {
                        GroupedDelayItems[i].Checked = Convert.ToBoolean(Sheet.Cells[2, 1 + i].Value);
                    }
                    _MenuSimulationDelayValue.Text = Sheet.Cells[2, 7].Text;

                    if (loader.Boxes[0].Checked)
                    {
                        _DescriptionPanel.Text = Sheet.Cells[5, 1].Text;
                    }

                    if (loader.Boxes[1].Checked)
                    {
                        TapeValues = new Dictionary<int, char>();
                        TapeIndexes.X = Sheet.Cells[7, 2].Value.Int();
                        TapeIndexes.Y = TapeIndexes.X - 1;
                        Int32 Row = 8;
                        while (Sheet.Cells[Row, 1].Text != "")
                        {
                            for (int i = 0; i < TableWidth+1; i++)
                            {
                                if (Sheet.Cells[Row, i + 1].Text.Length > 0)
                                { TapeValues.Add(++TapeIndexes.Y, Sheet.Cells[Row, i + 1].Text[0]); }
                            }
                            Row++;
                        }
                        SelectedTapeValue = Sheet.Cells[7, 3].Value.Int();
                        TapeDisplay = TapeIndexes.X;
                        RedrawTape();
                    }

                    if (loader.Boxes[2].Checked)
                    {
                        while (_ProgPanel.Controls.Count > 3)
                        {
                            _ProgPanel.Controls.RemoveAt(2);
                        }
                        while (_ProgPanel.Controls[0].Controls.Count > 1)
                        {
                            _ProgPanel.Controls[0].Controls.RemoveAt(1);
                            _ProgPanel.Controls[1].Controls.RemoveAt(1);
                            _ProgPanel.Controls[2].Controls.RemoveAt(1);
                        }
                        Int32 Row = 8;
                        while (Sheet.Cells[Row, 1].Text != "Program")
                        {
                            Row++;
                        }
                        Row += 1;
                        for (int i = 0; i < TableWidth; i++)
                        {
                            CreateCol(null, EventArgs.Empty);
                        }
                        do
                        {
                            CreateRow(null, EventArgs.Empty);
                            Row++;
                        } while (Sheet.Cells[Row, 1].Text != "");

                        for (int i = 1; i < _ProgPanel.Controls.Count; i++)
                        {
                            for (int j = 0; j < _ProgPanel.Controls[0].Controls.Count; j++)
                            {
                                if (i == _ProgPanel.Controls.Count - 1)
                                {
                                    _ProgPanel.Controls[i].Controls[j].Text = Sheet.Cells[Row - _ProgPanel.Controls[0].Controls.Count + j+1, i].RichText.Text;
                                }
                                else
                                {
                                    _ProgPanel.Controls[i].Controls[j].Text = Sheet.Cells[Row - _ProgPanel.Controls[0].Controls.Count + j+1, i].Text;
                                }
                            }
                        }
                        ChangeState(_ProgPanel.Controls[0].Controls[Sheet.Cells[Row - _ProgPanel.Controls[0].Controls.Count, 2].Text.Int()] as Button);
                        UsedChars = new List<char>();
                        for (int i = 1; i < _ProgPanel.Controls.Count - 1; i++) {
                            UsedChars.Add(_ProgPanel.Controls[i].Controls[0].Text[0]);
                        }
                    }
                    Package.Dispose();
                }
            }
        }

        private void _ProgLabelSpace_Click(object sender, EventArgs e)
        {
            (sender as Button).PreviewKeyDown += (e1, e2) => PreviewKD($"0,1", e2);
        }
    }
    public static class Extensions
    {
        public static Size Div(this Size a, Int32 b)
        {
            return new Size(a.Width / 2, a.Height / 2);
        }
        public static Int32 Int(this String a)
        {
            return Convert.ToInt32(a);
        }
        public static Int32 Int(this object a)
        {
            return Convert.ToInt32(a);
        }
        public static IEnumerable<KeyValuePair<int,char>> SkipWhileEnd(this IEnumerable<KeyValuePair<int,char>> a,Func<KeyValuePair<int, char>,bool> b) {
            Int32 Index=0;
            for (int i = a.Count(); i > 0; i--) {
                if (!b(a.ElementAt(i-1)))
                {
                    Index = i;break;
                }
            }
            for (int i = 0; i < Index; i++) {
                yield return a.ElementAt(i);
            }
        }

    }
}