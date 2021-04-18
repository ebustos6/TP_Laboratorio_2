using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num = new Numero("243");

            Console.WriteLine(num.DecimalBinario("123"));
            Console.WriteLine(num.DecimalBinario(123));
            Console.ReadLine();
            
        }
    }
}
