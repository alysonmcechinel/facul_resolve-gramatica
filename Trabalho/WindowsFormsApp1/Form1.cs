using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class List<Constants>
        {
            public const string S = "aBa|Baa";
            public const string T = "A";
            public const string P = "bb";
        }        

        private void gerarGramatica(object sender, EventArgs e)
        {
            string S = textBox1.Text;

            string[] producoesS = S.Split(new char[] { '|' });

            foreach(string a in producoesS)
            {
                Console.WriteLine(a);

                char itensProducao[] = a.ToCharArray();
            }
        }


        private void LimparTextBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
            }
        }

    }
}
