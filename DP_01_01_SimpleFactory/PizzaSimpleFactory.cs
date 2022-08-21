using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_01_01_SimpleFactory
{
    internal sealed class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string tipo)
        {
            Pizza pizza;
            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabreza();
                    break;
                case "M": 
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A pizza do tipo {tipo} não foi criada");                  
            }

            return pizza;
        }
    }
}
