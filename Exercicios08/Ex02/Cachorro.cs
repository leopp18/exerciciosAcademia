using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex02
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, string tipo) : base(nome, tipo)
        {

        }
        private int cao = 0;
        public void aumentaCao()
        {
            cao++;
        }
    }
}
