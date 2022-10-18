using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex02
{
    internal class Peixe : Animal
    {
        public Peixe(string nome, string tipo) : base(nome, tipo)
        {

        }


        private int peixe = 0;
        public void aumentaPeixe()
        {
            peixe++;
        }
    }
}
