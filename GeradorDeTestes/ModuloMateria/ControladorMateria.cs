using GeradorDeTestes.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloMateria
{
    internal class ControladorMateria : ControladorBase
    {
        private ListagemMateriaControl listagemMateria;
        public override void Editar()
        {
            TelaCadastroMateriaForm telaCadastro = new TelaCadastroMateriaForm("Editar Matéria");
            telaCadastro.ShowDialog();
        }

        public override void Excluir()
        {
            MessageBox.Show("Deseja realmente excluir essa matéria?", "Excluir matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public override void Inserir()
        {
            TelaCadastroMateriaForm telaCadastro = new TelaCadastroMateriaForm("Cadastrar Matéria");
            telaCadastro.ShowDialog();
        }

        public override ConfiguracaoToolboxBase ObterConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        public override UserControl ObterListagem()
        {
            if (listagemMateria == null)
                listagemMateria = new ListagemMateriaControl();

            CarregarMaterias();

            return listagemMateria;
        }
    }
}

