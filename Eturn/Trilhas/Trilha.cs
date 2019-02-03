using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Trilhas
{
    class Trilha
    {
        public List<Sessao> Sessoes { get; set; }
        public string Nome { get; set; }

        public Trilha(string aNome)
        {
            Nome = aNome;
        }

        public override string ToString()
        {
            var tostring = new StringBuilder(Nome).AppendLine();
            foreach (var sessao in Sessoes)
            {
                tostring.AppendLine(sessao.ToString());

            }
            return tostring.ToString();
        }
        public static List<Trilha> ObterTrilhas()
        {
            var t1 = new Trilha("Trilha 1")
            {
                Sessoes = new List<Sessao>()
                {
                    new Sessao()
                    {
                        Inicio = new DateTime(1,1,1,9,0,0),
                        Fim = new DateTime(1,1,1,12,0,0)
                    },
                    new Sessao()
                    {
                        Inicio = new DateTime(1,1,1,13,0,0),
                        Fim = new DateTime(1,1,1,17,0,0)
                    }
                }
            };
            var t2 = new Trilha("Trilha 2")
            {
                Sessoes = new List<Sessao>()
                {
                    new Sessao()
                    {
                        Inicio = new DateTime(1,1,1,9,0,0),
                        Fim = new DateTime(1,1,1,12,0,0)
                    },
                    new Sessao()
                    {
                        Inicio = new DateTime(1,1,1,13,0,0),
                        Fim = new DateTime(1,1,1,17,0,0)
                    }
                }
            };
            var trilhas = new List<Trilha>()
            {
                t1,t2
            };
            return trilhas;
        }
    }
}
