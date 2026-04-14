using System.ComponentModel;

namespace Aula004.Models
{
    public class Imoveis
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Proprietario { get; set; }
        public string Telefone { get; set; }
        public int Valor{ get; set; }
        public int Area { get; set; }
        public int Quartos { get; set; }
        public int Banheiros { get; set; }

        public static List<Imoveis> Lista
        {
            get
            {
                var lista = new List<Imoveis>
                {
                new () { Logradouro = "Alameda Londres, 430" , Bairro = "Jardim Europa", Cidade = "Sorocaba", Estado = "SP", Proprietario = "Alex Machado Ferreira Sampaio", Telefone = "(15)99988-9999", Valor = 500000, Area = 200, Quartos = 4, Banheiros = 3 },   
                new () { Logradouro = "Rua Montblanc, 0" , Bairro = "Fazenda Boa Vista", Cidade = "Porto Feliz", Estado = "SP", Proprietario = "Jones Artur Gonçalves", Telefone = "(15)99999-9999", Valor = 30000000, Area = 2000, Quartos = 9, Banheiros = 10 },

                };
                return lista;
            }
        }
    }
}
