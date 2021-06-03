using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness.ConsoleApp
{
    public class Refeicao
    {
        protected int valor = 10;
        public Refeicao(string descricao, int calorias)
        {
            Descricao = descricao;
            Calorias = calorias;
        }

        // public: o acesso é público

        // protected: o acesso está limitado para própria classe ou para classes derivadas

        // internal: o acesso está limitado ao assembly atual

        // private: o acesso está limitado a própria classe

        public string Descricao { get; private set; }
        public int Calorias { get; private set; }
        

        public virtual void ImprimirMensagem()
        {
            Console.WriteLine($"{Descricao}, com {Calorias} calorias.");
        }
    }
}
