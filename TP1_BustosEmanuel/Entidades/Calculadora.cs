using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char op = operador[0];
            switch (ValidarOperador(op))
            {
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        return double.MinValue;
                    }
                    else
                    {
                        return num1 / num2;
                    }     
                default:
                    return num1 + num2;
            }
        }

        private static string ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '-':
                    return "-";
                case '*':
                    return "*";
                case '/':
                    return "/";
                default:
                    return "+";
            }
        }
    }
}
