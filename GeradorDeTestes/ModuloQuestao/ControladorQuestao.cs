﻿using GeradorDeTestes.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloQuestao
{
    internal class ControladorQuestao : ControladorBase
    {
        private ListagemQuestaoControl ListagemQuestao;
        public override void Editar()
        {
            TelaCadastroQuestaoForm telaEdicao = new TelaCadastroQuestaoForm("Editar Questão");
            telaEdicao.ShowDialog();
        }

        public override void Excluir()
        {
            MessageBox.Show("Deseja realmente excluir essa questão?", "Excluir questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public override void Visualizar()
        {
            TelaListagemQuestaoForm telaFiltro = new TelaListagemQuestaoForm("Editar Questão");
            telaFiltro.ShowDialog();
        }

        public override void Inserir()
        {
            TelaCadastroQuestaoForm telaCadastro = new TelaCadastroQuestaoForm("Editar Questão");
            telaCadastro.ShowDialog();
        }

        public override ConfiguracaoToolboxBase ObterConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObterListagem()
        {
            var ListagemQuestao = new ListagemQuestaoControl();

            //CarregarQuestoes();

            return ListagemQuestao;
        }
    }
}
