using Eturn.Trilhas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Escritor    
{
    class EscritorConsole : IEscritor
    {
        public void EscreverTrilhas(List<Trilha> aTrilhas, List<Palestra> listaPalestrasExcedentes)
        {
            foreach (var trilha in aTrilhas)
            {
                Console.WriteLine(trilha);
            }

            if (listaPalestrasExcedentes != null && listaPalestrasExcedentes.Count > 0)
            {
                Console.WriteLine("Palestras Excedentes");
                foreach (var palestra in listaPalestrasExcedentes)
                {
                    Console.WriteLine(palestra.Titulo);
                }
            }
        }
    }
}
