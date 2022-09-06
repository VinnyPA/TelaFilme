using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katiaaula4
{
    public partial class TelaFilme : Form
    {
        public TelaFilme()
        {
            InitializeComponent();
        }
        Filme f = new Filme();
        Filme[] vet = new Filme[5];
        int i = 0;
        private void bntGravar_Click(object sender, EventArgs e)
        {
            if (i == 5)
            {
                MessageBox.Show("Não foi possível gravar!");
            }
            else
            {
                f.Titulo = txtTitulo.Text;
                f.Classificacao = txtClassificacao.Text;
                f.Genero = txtGenero.Text;
                f.Sinopse = txtSinopse.Text;
                vet[i] = f;
                i++;
            }
        }
    }
}
