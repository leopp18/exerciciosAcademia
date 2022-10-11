using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex07
{
    internal class Elevador
    {

        private int andar = 0;
        private int capacidade = 8;
        private int quantidade = 0;
        public void desceAndar()
        {
            andar--;
        }
        public void sobeAndar()
        {
            andar++;
        }
        public void saiPessoa()
        {
            quantidade--;
        }
        public void entraPessoa()
        {
            quantidade++;
        }

        public void setAndar(int andar)
        {
            this.andar = andar;
        }

        public int getAndar()
        {
            return andar;
        }
        
        public int getQuantidade()
        {
            return quantidade;
        }
    }
}
