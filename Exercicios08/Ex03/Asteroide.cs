using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex03
{
    internal class Asteroide
    {
        private int x, y, tamanho, energia, velocidade;

        public Asteroide()
        {
        }

        public Asteroide(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Asteroide(int x, int y, int tamanho, int energia, int velocidade)
        {
            this.x = x;
            this.y = y;
            this.tamanho = tamanho;
            this.energia = energia;
            this.velocidade = velocidade;
        }
        public void setX(int x)
        {
            this.x = x;
        }

        public int getX()
        {
            return x;
        }
        public void setY(int y)
        {
            this.y = y;
        }

        public int getY()
        {
            return y;
        }
        public void setTamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }

        public int getTamanho()
        {
            return tamanho;
        }
        public void setEnergia(int energia)
        {
            this.energia = energia;
        }

        public int getEnergia()
        {
            return energia;
        }
        public void setVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public int getVelocidade()
        {
            return velocidade;
        }

    }
}
