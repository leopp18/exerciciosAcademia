using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex05
{
    internal class Pagamento
    {
        private string metodo;
        private double total;

        public void setMetodo(string metodo)
        {
            this.metodo = metodo;
        }

        public string getMetodo()
        {
            return metodo;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }

        public double getTotal()
        {
            return total;
        }
    }
}
