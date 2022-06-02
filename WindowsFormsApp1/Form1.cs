using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class fResolveGramatica : Form
    {
        public fResolveGramatica()
        {
            InitializeComponent();
        }


        private void gerarGramatica(object sender, EventArgs e)
        {
            string G = tbG.Text;
            string[] producoesG = G.Split(new char[] { '|' });
            var resultado = ' ';

            foreach (string a in producoesG)
            {
                char[] teste = a.ToCharArray();
                for(int i = 0; i < a.Length; i++)
                {
                    if (teste[i].Equals(char.ToUpper(teste[i])))
                    {
                        var novo = SentencaN(teste[i]);
                        teste[i] = novo;
                    }
                    result.Text = resultado.ToString().Insert(0, teste[i].ToString());
                }
                
            }
        }

        private char SentencaN( char valor)
        {
            const string C = "aa";
            string N = tbN.Text;
            string[] sentencaN = N.Split(new char[] { '=' });
            char[] ret;
            if (sentencaN[0] != valor.ToString())
                return valor;

            ret = sentencaN[1].ToCharArray();

            for (int i = 0; i < ret.Length; i++)
                return ret[i];

            throw new ApplicationException("Sentenca não encontrada");
        }

        private void Limpar()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }

                if (item.GetType() == typeof(Label))
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

    }
}
