using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            string binario = "1011101";
            bool aux = true;
            int pos = binario.Length;
            int acum = 0;

            Console.WriteLine(binario);

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario.Substring(i, 1) != "1" && binario.Substring(i, 1) != "0")
                {
                    aux =  false;
                    break;
                }
            }

            if (aux)
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    pos--;
                    if (int.TryParse(binario.Substring(i, 1), out int num))
                    {
                        num *= (int)(Math.Pow(2, pos));
                        acum += num;
                    }

                }

                binario = acum.ToString();

            }
            else
            {
                binario = "Valor Invalido";
            }

            //Console.WriteLine(acum);
            Console.WriteLine(binario);
            Console.ReadLine();
        }
    }
}
