using GeradorDeTestes.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloTeste
{
    internal class ConfiguracaoToolboxTestes : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Visualizar Testes";

        public override string TooltipInserir => "Cadastrar Testes";

        public override string TooltipEditar => "Editar Testes";

        public override string TooltipExcluir => "Excluir Teste";

        public override string TooltipVisualizar => "Filtrar exame";

    }
}
