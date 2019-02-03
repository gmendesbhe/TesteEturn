using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Trilhas
{
    class Distribuidor
    {
        public List<Palestra> DistribuirPalestras(List<Palestra> listaPalestras, List<Trilha> trilhas)
        {
            var sessoes = trilhas.SelectMany(t => t.Sessoes).OrderByDescending(s => s.Duracao).ToArray();

            listaPalestras = listaPalestras.OrderBy(p => p.Duracao).ToList();

            var listaPalestrasExcedentes = new List<Palestra>();
            int i = 0;
            var stackPalestras = new Stack<Palestra>(listaPalestras);
            if (stackPalestras.Count > 0)
            {
                var tentativas = 0;
                while (stackPalestras.Count > 0)
                {
                    var p = stackPalestras.Peek();
                    try
                    {
                        Sessao sessao = sessoes[i % sessoes.Length];
                        sessao.AdicionarPalestra(p);
                        tentativas = 0;
                        stackPalestras.Pop();
                    }
                    catch (SemTempoDisponivelException)
                    {
                        i++;
                        if (++tentativas == sessoes.Length)
                        {
                            //throw new Exception("Palestras nao cabem nas sessoes");
                            listaPalestrasExcedentes.AddRange(stackPalestras);
                            break;
                        }
                        continue;
                    }
                }
            }

            return listaPalestrasExcedentes;
        }
    }
}
