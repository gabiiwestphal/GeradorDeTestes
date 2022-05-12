﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.Compartilhado
{
    internal abstract class ControladorBase
    {
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract void Visualizar();
        public abstract UserControl ObterListagem();

        public abstract ConfiguracaoToolboxBase ObterConfiguracaoToolbox();
    }
}

