using GeradorDeTestes.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloQuestao
{
    internal class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Questões";

        public override string TooltipInserir => "Cadastrar questão";

        public override string TooltipEditar => "Editar questão";

        public override string TooltipExcluir => "Excluir questão";

        public override string TooltipVisualizar => "Visualizar questão";

        public override bool VisualizarHabilitado { get { return true; } }
    }
}
