using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloQuestao
{
    public partial class TelaListagemQuestaoForm : Form
    {
        public TelaListagemQuestaoForm(string nomeTela)
        {
            InitializeComponent();
            Text = nomeTela;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
