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

        /// <summary>
        /// constructor sin parametros.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// constructor que recibe un double.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// constructor que recibe un string y lo envia a su atributo.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// atributo que recibe un string y lo carga como double.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// valida que un string se pueda convertir a doble.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>aux if true, 0 if false</returns>
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

        /// <summary>
        /// valida que un numero sea binario.
        /// </summary>
        /// <param name="Binario"></param>
        /// <returns></returns>
        private bool EsBinario(string Binario)
        {
            for (int i = 0; i < Binario.Length; i++)
            {
                if (Binario.Substring(i,1) != "1" && Binario.Substring(i, 1) != "0")
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// convierte un numero binario a decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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
                        num *= (int)Math.Pow(2, pos - 1);
                        acum += num;
                    }

                }

                binario = acum.ToString();

            }
            else
            {
                binario = "Valor inválido.";
            }

            return binario;
        }

        /// <summary>
        /// recibe un double y devuelve un string con ese numero convertido a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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

            }

            return bin;
        }

        /// <summary>
        /// recibe un string y si se puede pasar a double se lo envia a Decimal Binario(double) para ser convertido.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero,out double result))
            {
                return DecimalBinario(result);
            }
            else
            {
                return "Valor inválido.";
            }
        }

        /// <summary>
        /// sobrecarga el operador "+" entre 2 objetos de tipo "Numero".
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// sobrecarga el operador "-" entre 2 objetos de tipo "Numero".
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// sobrecarga el operador "*" entre 2 objetos de tipo "Numero".
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// sobrecarga el operador "/" entre 2 objetos de tipo "Numero".
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }
        }
    }
}
