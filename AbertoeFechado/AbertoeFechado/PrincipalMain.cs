using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbertoeFechado
{
    class PrincipalMain
    {
        public static void Main(string[] args)
        {
            Calculadora som = new Soma(1,2);
            Calculadora exp = new Exponencial(2, 3);
            Calculadora mut = new Mutiplicacao(4, 8);
            Calculadora sub = new Subtracao(8, 3);
            Calculadora div = new Divisao(8, 2);


            Console.WriteLine(som.calcular());
            Console.WriteLine(exp.calcular());
            Console.WriteLine(mut.calcular());
            Console.WriteLine(sub.calcular());
            Console.WriteLine(div.calcular());
            Console.ReadLine();
        }

    }
}
