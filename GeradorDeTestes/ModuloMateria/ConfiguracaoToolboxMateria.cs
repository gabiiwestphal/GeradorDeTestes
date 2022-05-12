using GeradorDeTestes.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloMateria
{
    internal class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Matérias";

        public override string TooltipInserir => "Inserir matéria";

        public override string TooltipEditar => "Editar matéria";

        public override string TooltipExcluir => "Excluir matéria";

        public override string TooltipVisualizar => "Visualizar matérias";

        public override bool VisualizarHabilitado { get { return true; } }
    }
}
