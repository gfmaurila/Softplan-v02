using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api2.Service.Services
{
    public class Calculadora
    {
        public decimal Somar(decimal Num1, decimal Num2) => Num1 + Num2;
        public decimal Subtrair(decimal Num1, decimal Num2) => Num1 - Num2;
        public decimal Multiplicar(decimal Num1, decimal Num2) => Num1 * Num2;
        public decimal Dividir(decimal Num1, decimal Num2) => Num1 / Num2;
    }
}
