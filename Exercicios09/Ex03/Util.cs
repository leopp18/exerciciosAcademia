using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Ex03
{
    internal class Util
    {
        Arquivo arq = new Arquivo();
        Figurinha f = new Figurinha();
        List<string> faltantes = new List<string>();
        List<string> repetidas = new List<string>();

        public void popularListas()
        {
            arq.leArquivo(repetidas, faltantes);
        }
        public void cadastrarRepetida()
        {
            Console.WriteLine("Insira o código da figurinha repetida:");
            f.setCodigo(Console.ReadLine().ToUpper());
            Console.WriteLine("Insira a seleção da figurinha repetida:");
            f.setSelecao(Console.ReadLine());
            Console.WriteLine("Insira o nome da figurinha repetida:");
            f.setNome(Console.ReadLine());
            string texto = f.getCodigo() + "; " + f.getSelecao() + "; " + f.getNome() + "; ";
            arq.escreveRepetidas(texto);
            repetidas.Add(texto);
        }

        public void cadastrarFaltante()
        {
            Console.WriteLine();
            Console.WriteLine("Insira o código da figurinha faltante:");
            f.setCodigo(Console.ReadLine().ToUpper());
            Console.WriteLine("Insira a seleção da figurinha faltante:");
            f.setSelecao(Console.ReadLine());
            Console.WriteLine("Insira o nome da figurinha faltante:");
            f.setNome(Console.ReadLine());
            string texto = f.getCodigo() + "; " + f.getSelecao() + "; " + f.getNome() + "; ";
            arq.escreveFaltantes(texto);
            faltantes.Add(texto);
            Console.WriteLine();
        }

        public void listarRepetidas()
        {
            Console.WriteLine();
            repetidas.Sort();
            foreach (var item in repetidas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void listarFaltantes()
        {
            Console.WriteLine();
            faltantes.Sort();
            foreach (var item in faltantes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
