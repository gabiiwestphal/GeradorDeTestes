﻿using System;
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
    public partial class TelaCadastroQuestaoForm : Form
    {
        public TelaCadastroQuestaoForm(string nomeTela)
        {
            InitializeComponent();
            Text = nomeTela;
        }
    }
}
