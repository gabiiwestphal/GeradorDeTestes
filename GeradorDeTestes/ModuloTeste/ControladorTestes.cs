using GeradorDeTestes.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloTeste
{
    internal class ControladorTestes : ControladorBase
    {
        public override void Editar()
        {
            TelaCadastroTestesForm telaEdicao = new TelaCadastroTestesForm("Editar teste");
            telaEdicao.ShowDialog();
        }

        public override void Excluir()
        {
            MessageBox.Show("Deseja realmente excluir esse teste?", "Excluir teste", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public override void Visualizar()
        {
            TelaVisualizarTestesForm telaVisualizar = new TelaVisualizarTesteForm("Editar teste");
            telaFiltro.ShowDialog();
        }

        public override void Inserir()
        {
            TelaCadastroTestesForm telaCadastro = new TelaCadastroTestesForm("Cadastro testes");
            telaCadastro.ShowDialog();
        }

        public override ConfiguracaoToolboxBase ObterConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTestes();
        }

        public override UserControl ObterListagem()
        {
            var listagemTestes = new ListagemTestesControl();

            //CarregarMaterias();

            return listagemTestes;
        }
    }
}

