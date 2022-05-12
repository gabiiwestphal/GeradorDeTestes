using GeradorDeTestes.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Nome { get; set; }
        public bool PodeExcluirDisciplina => QuantidadeMateriasRelacionadas == 0 ? true : false;
        public int QuantidadeMateriasRelacionadas = 0;
        public Disciplina()
        {

        }
        public Disciplina(string nome)
        {
            Nome = nome;
        }        

        public override void Atualizar(Disciplina registro)
        {
            this.Nome = registro.Nome;
        }

        public override string ToString()
        {
            return $"Número: {Numero} - Nome: {Nome}";
        }
    }
}
