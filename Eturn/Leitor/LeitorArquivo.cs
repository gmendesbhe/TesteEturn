using Eturn.Trilhas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Leitor
{
    class LeitorArquivo : ILeitor
    {
        public List<Palestra> ObterListaPalestras()
        {
            var listaPalestras = new List<Palestra>();
            using (var sr = new StreamReader(ParametrosEntrada.Instance.CaminhoArquivoPalestras))
            {
                try
                {
                    int numeroLinha = 1;
                    var linha = sr.ReadLine();
                    while (linha != null)
                    {
                        var split = linha.Split(ParametrosEntrada.Instance.SeparadorCsv.ToCharArray());
                        if (!int.TryParse(split[1], out int duracao))
                            throw new Exception("Duracao mal formatada. Linha " + numeroLinha.ToString());
                        numeroLinha++;
                        listaPalestras.Add(new Palestra(split[0], duracao));
                        linha = sr.ReadLine();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return listaPalestras;
        }
    }
}
