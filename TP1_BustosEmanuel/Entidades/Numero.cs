using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }


        private double ValidarNumero(string strNumero)
        {
            if(double.TryParse(strNumero, out double aux))
            {
                return aux;
            }
            else
            {
                return 0;
            }   
        }

        private bool EsBinario(string Binario)
        {
            for (int i = 0; i < Binario.Length - 1; i++)
            {
                if (Binario.Substring(i,1) != "1" && Binario.Substring(i, 1) != "0")
                {
                    return false;
                }
            }

            return true;
        }

        public string BinarioDecimal(string binario)
        {
            int pos = binario.Length;
            int acum = 0;

            if (EsBinario(binario))
            {
                for (int i = 0; i < binario.Length - 1; i++)
                {
                    pos--;
                    if (int.TryParse(binario.Substring(i, 1), out int num))
                    {
                        num *= (int)Math.Pow(2, pos);
                        acum += num;
                    }

                }

                binario = acum.ToString();
                acum = 0;

            }
            else
            {
                binario = "Valor inválido.";
            }

            return binario;
        }

        public string DecimalBinario(double numero)
        {
            string bin = " ";

            if ((int)numero > 0)
            {
                while ((int)numero > 0)
                {
                    if ((int)numero % 2 == 0)
                    {
                        bin = "0" + bin;
                    }
                    else
                    {
                        bin = "1" + bin;
                    }
                    numero /= 2;
                }

            }
            else
            {
                if (numero == 0)
                {
                    bin = "0";
                }
                else
                {
                    bin = "Valor inválido.";
                }

            }

            return bin;
        }

        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero,out double result))
            {
                return DecimalBinario(result);
            }
            else
            {
                return "Valor inválido";
            }
        }


        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            return num1.numero / num2.numero;
        }


       public static bool operator ==(Numero num1, double num2)
        {
            return num1.numero == num2;
        }

        public static bool operator !=(Numero num1, double num2)
        {
            return !(num1.numero == num2);
        }
    }
}
