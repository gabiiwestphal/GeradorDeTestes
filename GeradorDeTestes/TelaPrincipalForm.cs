﻿using GeradorDeTestes.Compartilhado;
using GeradorDeTestes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        //private DateContext contextoDados;
        public TelaPrincipalForm()
        {
            InitializeComponent();
            Instancia = this;

            txtRodape.Text = string.Empty;

            InicializarControladores();

        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            txtRodape.Text = mensagem;
        }

        private void menuMateria_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void menuQuestao_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void menuTestes_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();

        }
        public void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObterConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolStrip.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            btnVisualizar.Enabled = configuracao.VisualizarHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnVisualizar.ToolTipText = configuracao.TooltipVisualizar;
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObterListagem();

            panelConteudo.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelConteudo.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            //Repositorios aqui

            controladores = new Dictionary<string, ControladorBase>();
            controladores.Add("Materias", new ControladorMateria());
            //controladores.Add("Questões", new ControladorQuestao());
           // controladores.Add("Exames", new ControladorTestes());
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            controlador.Visualizar();
        }
    }
}

