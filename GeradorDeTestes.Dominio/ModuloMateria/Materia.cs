using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public Disciplina Disciplina { get; set; }
        public string Titulo { get; set; }
        public string Serie { get; set; }

        public Materia(Disciplina diciplina, string serie, string titulo)
        {
            this.Disciplina = Disciplina;
            this.Serie = serie;
            this.Titulo = titulo;
        }
        public override void Atualizar(Materia registro)
        {
            this.Disciplina = registro.Disciplina;
            this.Serie = registro.Serie;
            this.Titulo = registro.Titulo;
        }
        public override string ToString()
        {
            return $"Número: {Numero} - Título: {Titulo} - Disciplina: {Disciplina.Nome} - Série: {Serie}";
        }
    }
}
