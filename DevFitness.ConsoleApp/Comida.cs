using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness.ConsoleApp
{
    public class Comida : Refeicao
    {
        public Comida(string descricao, int calorias, decimal preco) : base(descricao, calorias)
        {
            Preco = preco;
        }

        public decimal Preco { get; private set; }

        public override void ImprimirMensagem()
        {
            Console.WriteLine($"{Descricao}, com {Calorias} calorias, com preço {Preco}");
        }
    }
}
