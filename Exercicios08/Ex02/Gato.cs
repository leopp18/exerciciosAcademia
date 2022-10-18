using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex02
{
    internal class Gato : Animal
    {
        public Gato(string nome, string tipo) : base(nome, tipo)
        {

        }
        private int gato = 0;
        public void aumentaGato()
        {
            gato++;
        }
    }
}
