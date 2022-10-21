using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Ex03
{
    internal class Arquivo
    {
        private string arqFaltantes = @"C:\Users\leopp\OneDrive\Área de Trabalho\Atos\Lista09-Ex03\Lista09-Ex03\faltantes.csv";
        private string arqRepetidas = @"C:\Users\leopp\OneDrive\Área de Trabalho\Atos\Lista09-Ex03\Lista09-Ex03\repetidas.csv";

        public void leArquivo(List<string> repetidas, List<string> faltantes)
        {
            try
            {
                string linha = "";
                StreamReader sr = new StreamReader(arqRepetidas);
                while ((linha = sr.ReadLine()) != null)
                {
                    repetidas.Add(linha);
                }
                sr.Close();
                string linha2 = "";
                sr = new StreamReader(arqFaltantes);
                while ((linha2 = sr.ReadLine()) != null)
                {
                    faltantes.Add(linha2);
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado!");
            }
        }

        public void escreveRepetidas(string texto)
        {
            StreamWriter sw = new StreamWriter(arqRepetidas, append: true);
            sw.WriteLine(texto);
            sw.Flush();
            sw.Close();
        }
        public void escreveFaltantes(string texto)
        {
            StreamWriter sw = new StreamWriter(arqFaltantes, append: true);
            sw.WriteLine(texto);
            sw.Flush();
            sw.Close();
        }
    }
}
