using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChristichDllHacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int LoadString(IntPtr hInstance, int ID, StringBuilder lpBuffer, int nBufferMax);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(IntPtr hModule);

        private static string ExtractStringFromDLL(string file, int number)
        {
            IntPtr lib = LoadLibrary(file);
            StringBuilder result = new StringBuilder(2048);
            LoadString(lib, number, result, result.Capacity);
            FreeLibrary(lib);
            return result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputString.Text = ExtractStringFromDLL(InputFile.Text, Convert.ToInt32(InputNumber.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputString.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Dll files|*.dll|Exe files|*.exe|All files|*.dll;*.exe",
                Title="Выберите файл"
            };
            if (dialog.ShowDialog() == DialogResult.OK) {
                InputFile.Text = dialog.FileName;
            }
        }
    }
}
