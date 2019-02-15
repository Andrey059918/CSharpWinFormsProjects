using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace ImageARGBChanger
{
    public partial class Form1 : Form
    {
        Bitmap SrcImg;
        Bitmap ResImg;
        static string ProgString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolBarButton_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageOpener = new OpenFileDialog() { Filter = "Supported Image Formats|*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.tif;*.tiff", Title = "Выберите изображение..." };
            if (ImageOpener.ShowDialog() == DialogResult.OK && System.IO.File.Exists(ImageOpener.FileName))
            {
                SrcImg = new Bitmap(ImageOpener.FileName);
            }
        }
        private void ToolBarButton_Colors_Click(object sender, EventArgs e)
        {
            TypeFormula ftyper = new TypeFormula(this);
            ftyper.Show();
            ftyper.FormClosed += (a1, a2) =>
            {
                Enabled = true;
            };
            Enabled = false;
        }
        public void GetStringProgram(params string[] formulas)
        {
            ProgString = @"using System;
                using System.Collections.Generic;
                using System.Text;
                using System.Threading.Tasks;

                namespace Recolorator
                {
                    class Program
                    {
                        static Int32 Acolor, Rcolor, Gcolor, Bcolor;

                        public static List<Int32> Recolor(Int32 A,Int32 R,Int32 G, Int32 B)
                        {
                            Acolor = Math.Max(0,Math.Min(255," + formulas[0] + @"));
                            Rcolor = (Int32)Math.Max(0,Math.Min(255," + formulas[1] + @"));
                            Gcolor = (Int32)Math.Max(0,Math.Min(255," + formulas[2] + @"));
                            Bcolor = (Int32)Math.Max(0,Math.Min(255," + formulas[3] + @"));
                            return new List<Int32>(){Acolor,Rcolor,Gcolor,Bcolor} ;
                        }
                    }
                }";
        }
        private void ToolBarButton_Save_Click(object sender, EventArgs e)
        {
            if (ProgString != "")
            {
                ProcessImage();
                SaveFileDialog ImageSaver = new SaveFileDialog() { Filter = "Supported Image Formats|*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.tif;*.tiff", Title = "Выберите место сохранения..." };
                if (ImageSaver.ShowDialog() == DialogResult.OK)
                {
                    ResImg.Save(ImageSaver.FileName,ImageFormat.Png);
                }
            }
        }
        public void ProcessImage()
        {
            /*ResImg = new Bitmap(SrcImg.Width, SrcImg.Height, PixelFormat.Format32bppArgb);
            for (int r = 0; r < 6; r++)
            {
                for (int g = 0; g < 6; g++)
                {
                    for (int b = 0; b < 6; b++)
                    {
                        GetStringProgram("A",r+"*(float)(B)/3.2",g+ "*(float)(B)/3.2", b+ "*(float)(B)/3.2");
                        CompilerResults results = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(new CompilerParameters() { GenerateInMemory = true }, ProgString);
                        if (results.Errors.Capacity > 0)
                        {
                            foreach (var err in results.Errors)
                            {
                                Console.WriteLine(err.ToString());
                            }
                        }
                        for (int i = 0; i < SrcImg.Width; i++)
                        {
                            for (int j = 0; j < SrcImg.Height; j++)
                            {
                                Color Pixel = SrcImg.GetPixel(i, j);
                                List<Int32> returns = results.CompiledAssembly.GetType("Recolorator.Program").GetMethod("Recolor").Invoke(null, new object[] { Pixel.A, Pixel.R, Pixel.G, Pixel.B }) as List<Int32>;
                                ResImg.SetPixel(i, j, Color.FromArgb(returns[0], returns[1], returns[2], returns[3]));
                            }
                        }
                        ResImg.Save(PathSave+@"\Logo" + String.Concat(r, g, b)+".png",ImageFormat.Png);
                    }
                }
            }*/
                                                               
            ResImg = new Bitmap(SrcImg.Width, SrcImg.Height, PixelFormat.Format32bppArgb);
            CompilerResults results = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(new CompilerParameters() { GenerateInMemory = true }, ProgString);
            if (results.Errors.Capacity > 0)
            {
                foreach (var r in results.Errors)
                {
                    Console.WriteLine(r.ToString());
                }
            }
            for (int i = 0; i < SrcImg.Width; i++)
            {
                for (int j = 0; j < SrcImg.Height; j++)
                {
                    Color Pixel = SrcImg.GetPixel(i, j);
                    List<Int32> returns = results.CompiledAssembly.GetType("Recolorator.Program").GetMethod("Recolor").Invoke(null, new object[] { Pixel.A, Pixel.R, Pixel.G, Pixel.B }) as List<Int32>;
                    ResImg.SetPixel(i, j, Color.FromArgb(returns[0], returns[1], returns[2], returns[3]));
                }
            }
        }
    }
}
