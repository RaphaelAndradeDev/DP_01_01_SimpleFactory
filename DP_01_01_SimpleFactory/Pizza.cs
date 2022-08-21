using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_01_01_SimpleFactory
{
    internal abstract class Pizza
    {
        public string Nome { get; set; }
        public abstract void Preparar();
        public abstract void Assar(int tempo);
        public abstract void Embalar();
    }
}
