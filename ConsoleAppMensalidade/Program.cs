using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMensalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.WriteLine("Qual o valor da anuidade: ");
            double anui = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da matrícula: ");
            double matri = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do material: ");
            double mater = double.Parse(Console.ReadLine());

            while(cont <= 12)
            {
                double total = anui / 12 + matri + mater;
                matri = 0;
                mater = 0;
                Console.WriteLine("Mensalidade: " +cont+ " valor: "+total.ToString("C"));
                cont++;
            }
            Console.ReadKey();
        } 
    }
}
