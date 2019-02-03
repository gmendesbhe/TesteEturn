using Eturn.Trilhas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Escritor
{
    class EscritorArquivo : IEscritor
    {
        private readonly string CaminhoArquivo;

        public EscritorArquivo(string aCaminhoArquivo)
        {
            CaminhoArquivo = aCaminhoArquivo;
        }
        public void EscreverTrilhas(List<Trilha> trilhas, List<Palestra> listaPalestrasExcedentes)
        {
            throw new NotImplementedException();
        }
    }
}
