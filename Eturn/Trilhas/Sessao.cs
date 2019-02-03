using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Trilhas
{
    class Sessao
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public TimeSpan Duracao { get { return Fim - Inicio; } }
        public List<Palestra> Palestras { get; set; }
        public TimeSpan TempoDisponivel
        {
            get
            {
                return Palestras.Aggregate(Duracao, (a, p) => a -= p.Duracao);
            }
        }
        public void AdicionarPalestra(Palestra aPalestra)
        {
            if (aPalestra.Duracao > TempoDisponivel)
                throw new SemTempoDisponivelException();
            Palestras.Add(aPalestra);
        }
        public Sessao()
        {
            Palestras = new List<Palestra>();
        }
        public override string ToString()
        {
            var inicio = Inicio.TimeOfDay;
            var tostring = new StringBuilder();
            foreach (var palestra in Palestras)
            {
                tostring.Append(inicio.ToString()).Append(" - ").AppendLine(palestra.Titulo);
                inicio += palestra.Duracao;
            }
            return tostring.ToString();
        }
    }
}
