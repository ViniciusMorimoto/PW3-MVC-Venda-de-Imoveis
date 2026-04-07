using System.ComponentModel;

namespace Aula004.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public static List<Pessoa> Lista
        {
            get
            {
                //var lista = new List<Pessoa>();
                //lista.Add(new Pessoa { Nome = "Haroldo", Idade = 31 });
                //lista.Add(new Pessoa { Nome = "Armando", Idade = 7 });
                //lista.Add(new Pessoa { Nome = "Abraham", Idade = 152 });
                var lista = new List<Pessoa>
                {
                new () { Nome = "Haroldo", Idade = 31},
                new () { Nome = "Armando", Idade = 7 },
                new () { Nome = "Abraham", Idade = 152}

                };
                return lista;
            }
        }
    }
}
