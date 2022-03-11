using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Services
{
    public class CalcService
    {
        public int Num1 { get; private set; }
        public int Num2 { get; private set; }
        public int Sum => Num1 + Num2;
        public int Sub => Num1 - Num2;
        public int Mul => Num1 * Num2;
        public int Div => Num2 == 0 ? -1 : Num1 / Num2;

        public CalcService()
        {
            var rand = new Random();
            Num1 = rand.Next() % 11;
            Num2 = rand.Next() % 11;
        }
    }
}
