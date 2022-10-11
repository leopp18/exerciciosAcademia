using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex08
{
    internal class ControleRemoto
    {
        Televisao tv = new Televisao();
        public void diminuiVolume()
        {
            tv.volume--;
        }
        public void aumentaVolume()
        {
            tv.volume++;
        }
        public void diminuiCanal()
        {
            tv.canal--;
        }
        public void aumentaCanal()
        {
            tv.canal++;
        }

        public void setCanal(int canal)
        {
            tv.canal = canal;
        }

        public void consultar()
        {
            Console.WriteLine("Canal atual: " + tv.canal);
            Console.WriteLine("Volume atual: " + tv.volume);
        }
    }
}
