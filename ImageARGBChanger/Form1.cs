using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageARGBChanger
{
    public partial class Form1 : Form
    {
        private List<_BitmapInfo> _ListImageSource;
        private List<_BitmapInfo> _ListImageResult;
        private String ProgString = "";
        static private string[] Exts = new string[] { ".png", ".bmp", ".jpg", ".jpeg;", ".gif", ".tif", ".tiff" };
    

        public Form1()
        {
            InitializeComponent();
            _ListImageSource = new List<_BitmapInfo>();
            _ListImageResult = new List<_BitmapInfo>();
        }


        private void _PTB_OpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog _ImageOpener = new OpenFileDialog()
            {

                Filter = "Все разрешенные форматы|*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.tif;*.tiff",
                Title = "Выберите изображение...",
                Multiselect = true
            };
            if (_ImageOpener.ShowDialog() == DialogResult.OK) {
                foreach (String str in _ImageOpener.FileNames)
                {
                    try
                    {
                        _ImageAdder(str);
                        //_AddInfoText("Информация:  " + str + " был успешно загружен.", Color.DarkGreen);
                    }
                    catch (Exception)
                    {
                        //_AddInfoText("Внимание:        " + str + " не является графическим файлом или имеет неподдерживаемый формат.", Color.Red);
                    }
                }
            }
        }
        private void _PTB_OpenFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _FolderOpener = new FolderBrowserDialog()
            {
                Description = "Выберите папку с изображениями...\nВнимание: это может занять много времени!"
            };
            if (_FolderOpener.ShowDialog() == DialogResult.OK) {
                foreach (String str in Directory.EnumerateFiles(_FolderOpener.SelectedPath,"*", SearchOption.AllDirectories).Where(a=>Exts.Contains(a.Substring(a.Length-4))))
                {
                    try
                    {
                        _ImageAdder(str);
                        //_AddInfoText("Информация:  " + str + " был успешно загружен.", Color.DarkGreen);
                    }
                    catch (Exception)
                    {
                        //_AddInfoText("Внимание:        " + str + " не является графическим файлом или имеет неподдерживаемый формат.", Color.Red);
                    }
                }
            }
        }
        private void _PTB_ProcessImages_Click(object sender, EventArgs e)
        {
            GetStringProgram();
            String temppath = "";
            _BitmapInfo nbmi;
            Int32 ImgWidth, ImgHeight;
            CompilerResults results=null;
            try
            {
                results = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(new CompilerParameters() { GenerateInMemory = true }, ProgString);
                if (results.Errors.Capacity > 0)
                {
                    _AddInfoText("Ошибка:\tПроверьте правильность ввода формул или воспользуйтесь помощью.", Color.Red);
                }
            }
            catch { }

            foreach (_BitmapInfo bmi in _ListImageSource) {
                for (int a1 = 0; a1 < _PSC_CycleAlpha.Value; a1++) {

                    for (int a2 = 0; a2 < _PSC_CycleRed.Value; a2++)
                    {
                        for (int a3 = 0; a3 < _PSC_CycleGreen.Value; a3++)
                        {
                            for (int a4 = 0; a4 < _PSC_CycleBlue.Value; a4++)
                            {
                                nbmi = new _BitmapInfo(new Bitmap(bmi._OriginalImage.Width, bmi._OriginalImage.Height, PixelFormat.Format32bppArgb), null, bmi._FilePath);
                                for (int i = 0; i < bmi._OriginalImage.Width; i++)
                                {
                                    for (int j = 0; j < bmi._OriginalImage.Height; j++)
                                    {
                                        Color Pixel = bmi._OriginalImage.GetPixel(i, j);
                                        List<Int32> returns = results.CompiledAssembly.GetType("Recolorator.Program").GetMethod("Recolor").Invoke(null, new object[] { Pixel.A, Pixel.R, Pixel.G, Pixel.B,a1,a2,a3,a4 }) as List<Int32>;
                                        nbmi._OriginalImage.SetPixel(i, j, Color.FromArgb(returns[0], returns[1], returns[2], returns[3]));
                                    }
                                }
                                ImgWidth = Math.Min(175, nbmi._OriginalImage.Width);
                                ImgHeight = Math.Min((int)Math.Round((float)nbmi._OriginalImage.Height / nbmi._OriginalImage.Width * 175), nbmi._OriginalImage.Height);
                                nbmi._ResizedImage = new Bitmap(nbmi._OriginalImage, ImgWidth, ImgHeight);
                                _ListImageResult.Add(nbmi);
                                FlowLayoutPanel BitmapPanel = new FlowLayoutPanel()
                                {
                                    Margin = new Padding(0, 0, 0, 0),
                                    Padding = new Padding(0, 0, 0, 0),
                                    AutoSize = true
                                };
                                _PanelImageResult.Controls.Add(BitmapPanel);
                                PictureBox BitmapBox = new PictureBox()
                                {
                                    Margin = new Padding(0, 0, 0, 0),
                                    SizeMode = PictureBoxSizeMode.CenterImage,
                                    Image = _ListImageResult[_PanelImageResult.Controls.GetChildIndex(BitmapPanel)]._ResizedImage,
                                    Size = new Size(175, _ListImageResult[_PanelImageResult.Controls.GetChildIndex(BitmapPanel)]._ResizedImage.Height)
                                };
                                BitmapBox.MouseClick += (e1, e2) =>
                                {
                                    if (e2.Button == MouseButtons.Left)
                                    {
                                        temppath = Path.GetTempPath();
                                        _ListImageResult[_PanelImageResult.Controls.GetChildIndex(BitmapPanel)]._OriginalImage.Save(temppath+"\\temppng.png",ImageFormat.Png);
                                        System.Diagnostics.Process.Start(temppath + "\\temppng.png");
                                    }
                                    else if (e2.Button == MouseButtons.Right)
                                    {
                                        _ListImageResult.RemoveAt(_PanelImageResult.Controls.GetChildIndex(BitmapPanel));
                                        _PanelImageResult.Controls.Remove(BitmapPanel);
                                    }
                                };
                                BitmapPanel.Controls.Add(BitmapBox);
                                TextBox BitmapName = new TextBox()
                                {
                                    Margin = new Padding(0, 0, 0, 5),
                                    Width = BitmapBox.Width,
                                    Text = ByMaskRenamer(Path.GetFileNameWithoutExtension(_ListImageResult[_PanelImageResult.Controls.GetChildIndex(BitmapPanel)]._FilePath),a1,a2,a3,a4)
                                };
                                BitmapPanel.Controls.Add(BitmapName);
                            }
                        }
                    }
                }
            }
        }
        private void _PSO_OutFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _FolderSelector = new FolderBrowserDialog()
            {
                Description = "Выберите папку для сохранения..."
            };
            if (_FolderSelector.ShowDialog() == DialogResult.OK)
            {
                _PSO_OutFolder.Text = _FolderSelector.SelectedPath;
            }
        }
        private void _PTB_SaveFiles_Click(object sender, EventArgs e)
        {
            if (_PSO_OutToggle.Checked)
            {
                foreach (_BitmapInfo bmi in _ListImageResult)
                {
                    bmi._OriginalImage.Save(Path.GetDirectoryName(bmi._FilePath) + "\\" + _PanelImageResult.Controls[_ListImageResult.IndexOf(bmi)].Controls[1].Text + ".png", ImageFormat.Png);
                }
            }
            else
            {
                foreach (_BitmapInfo bmi in _ListImageResult)
                {
                    bmi._OriginalImage.Save(_PSO_OutFolder.Text + "\\" + _PanelImageResult.Controls[_ListImageResult.IndexOf(bmi)].Controls[1].Text + ".png", ImageFormat.Png);
                }
            }
        }


        private void _ImageAdder(String str) {
            Image ImgFile = Image.FromFile(str);
            Int32 ImgWidth = Math.Min(175, ImgFile.Width);
            Int32 ImgHeight = Math.Min((int)Math.Round((float)ImgFile.Height/ImgFile.Width*175), ImgFile.Height);

            _ListImageSource.Add(new _BitmapInfo(new Bitmap(ImgFile), new Bitmap(ImgFile, new Size(ImgWidth,ImgHeight)),str));
            FlowLayoutPanel BitmapPanel = new FlowLayoutPanel()
            {
                Margin = new Padding(0, 0, 0, 0),
                Padding = new Padding(0, 0, 0, 0),
                AutoSize = true
            };
            _PanelImageSource.Controls.Add(BitmapPanel);
            PictureBox BitmapBox = new PictureBox()
            {
                Margin = new Padding(0, 0, 0, 0),
                SizeMode =PictureBoxSizeMode.CenterImage,
                Image= _ListImageSource[_PanelImageSource.Controls.GetChildIndex(BitmapPanel)]._ResizedImage,
                Size = new Size(175,_ListImageSource[_PanelImageSource.Controls.GetChildIndex(BitmapPanel)]._ResizedImage.Height)
            };
            BitmapBox.MouseClick += (a1, a2) =>
            {
                if (a2.Button == MouseButtons.Left)
                {
                    System.Diagnostics.Process.Start(_ListImageSource[_PanelImageSource.Controls.GetChildIndex(BitmapPanel)]._FilePath);
                }
                else if (a2.Button == MouseButtons.Right) {
                    _ListImageSource.RemoveAt(_PanelImageSource.Controls.GetChildIndex(BitmapPanel));
                    _PanelImageSource.Controls.Remove(BitmapPanel);
                }
            };
            BitmapPanel.Controls.Add(BitmapBox);
            TextBox BitmapName = new TextBox()
            {
                Margin = new Padding(0, 0, 0, 5),
                Width = BitmapBox.Width,
                Text = Path.GetFileName(_ListImageSource[_PanelImageSource.Controls.GetChildIndex(BitmapPanel)]._FilePath)
            };
            BitmapPanel.Controls.Add(BitmapName);
        }
        private void _AddInfoText(String text, Color color)
        {
            _PanelInfo.Select(0, 0);
            _PanelInfo.SelectedText = text + "\n";
            _PanelInfo.Select(0, text.Length);
            _PanelInfo.SelectionColor = color;
        }
        private void GetStringProgram()
        {
            ProgString = @"
                using System;
                using System.Collections.Generic;
                using System.Text;
                using System.Threading.Tasks;

                namespace Recolorator
                {
                    class Program
                    {
                        static Int32 Acolor, Rcolor, Gcolor, Bcolor;

                        public static List<Int32> Recolor(Int32 A,Int32 R,Int32 G, Int32 B,Int32 a,Int32 r,Int32 g,Int32 b )
                        {
                            Acolor = (Int32)Math.Max(0,Math.Min(255," + _PSC_ColorAlpha.Text + @"));
                            Rcolor = (Int32)Math.Max(0,Math.Min(255," + _PSC_ColorRed.Text + @"));
                            Gcolor = (Int32)Math.Max(0,Math.Min(255," + _PSC_ColorGreen.Text + @"));
                            Bcolor = (Int32)Math.Max(0,Math.Min(255," + _PSC_ColorBlue.Text + @"));
                            return new List<Int32>(){Acolor,Rcolor,Gcolor,Bcolor} ;
                        }
                    }
                }";
        }
        private String ByMaskRenamer(String inname,Int32 a1, Int32 a2, Int32 a3, Int32 a4) {
            String txt = _PSO_OutMask.Text,outname="";
            for (int i = 0; i < txt.Length; i++) {
                if (txt[i] == '%'&&i<txt.Length-1)
                {
                    switch (txt[i + 1]) {
                        case 'N':outname += inname;break;
                        case '1': outname += a1; break;
                        case '2': outname += a2; break;
                        case '3': outname += a3; break;
                        case '4': outname += a4; break;
                        case 'Y': outname += DateTime.Now.Year.ToString().PadLeft(4,'0'); break;
                        case 'M': outname += DateTime.Now.Month.ToString().PadLeft(2, '0'); break;
                        case 'D': outname += DateTime.Now.Day.ToString().PadLeft(2, '0'); break;
                        case 'h': outname += DateTime.Now.Hour.ToString().PadLeft(2, '0'); break;
                        case 'm': outname += DateTime.Now.Minute.ToString().PadLeft(2, '0'); break;
                        case 's': outname += DateTime.Now.Second.ToString().PadLeft(2, '0'); break;
                        default: outname += txt[i] + txt[i + 1];break;
                    }
                    i++;
                }
                else
                {
                    outname += txt[i];
                }
            }
            return outname;
        }
    }
    public class _BitmapInfo
    {
        public Bitmap _OriginalImage { get; set; }
        public Bitmap _ResizedImage { get; set; }
        public String _FilePath { get; set; }
        public _BitmapInfo(Bitmap orig, Bitmap sized, String path)
        {
            _OriginalImage = orig;
            _ResizedImage = sized;
            _FilePath = path;
        }
    }
}
