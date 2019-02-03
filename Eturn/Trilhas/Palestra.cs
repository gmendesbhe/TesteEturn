using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Trilhas
{
    class Palestra
    {
        public TimeSpan Duracao { get; private set; }
        public string Titulo { get; private set; }

        public Palestra(string aTitulo, TimeSpan aDuracao)
        {
            Duracao = aDuracao;
            Titulo = aTitulo;
        }

        public Palestra(string aTitulo, int aDuracaoMinutos)
        {
            Duracao = TimeSpan.FromMinutes(aDuracaoMinutos);
            Titulo = aTitulo;
        }

        public override string ToString()
        {
            return new StringBuilder(Titulo).Append('-').Append(Duracao).ToString();
        }
    }
}
