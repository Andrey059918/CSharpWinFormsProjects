using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageARGBChanger
{
    public partial class TypeFormula : Form
    {
        static List<int> AllowedSymbols = new List<int> { 'A','R','G','B','+', '-', '*', '/',8};
        Form1 parent;

        public TypeFormula(Form1 p)
        {
            InitializeComponent();
            parent = p;
        }

        private void FormulaBox_Click(object sender, EventArgs e)
        {
            TextBox Txt=sender as TextBox;
            if (Txt.Text ==Txt.Tag.ToString()) {
                Txt.SelectionStart = 0;
            }
        }
        private void FormulaReset_Click(object sender, EventArgs e)
        {
            Button Btn = sender as Button;
            ElementsTable.GetControlFromPosition(0, ElementsTable.GetPositionFromControl(Btn).Row).Text = ElementsTable.GetControlFromPosition(0, ElementsTable.GetPositionFromControl(Btn).Row).Tag.ToString();
        }
        private void FormulaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == 8 && (sender as TextBox).Text.Length==1)
            {
                (sender as TextBox).Text = (sender as TextBox).Tag.ToString();
            }
            else if ((e.KeyChar < 48 || e.KeyChar > 57) && !AllowedSymbols.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            else if ((sender as TextBox).Text == (sender as TextBox).Tag.ToString())
            {
                (sender as TextBox).Text = "";
            }
        }
        private void OK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) {
                if (ElementsTable.GetControlFromPosition(0, i).Text == "" || ElementsTable.GetControlFromPosition(0, i).Text == ElementsTable.GetControlFromPosition(0, i).Tag.ToString()) {
                    ElementsTable.GetControlFromPosition(0, i).Text = ElementsTable.GetControlFromPosition(0, i).Name.Last().ToString();
                }
            }
            //parent.GetStringProgram(ElementsTable.Controls[0].Text, ElementsTable.Controls[2].Text, ElementsTable.Controls[4].Text, ElementsTable.Controls[6].Text);
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            //parent.GetStringProgram("A","R","G","B");
            Close();
        }
    }
}
