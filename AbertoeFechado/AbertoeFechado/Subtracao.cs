using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbertoeFechado
{
    public class Subtracao : Calculadora
    {
        float numero1, numero2; 

        public Subtracao(float numero1, float numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public override float calcular()
        {
            return numero1 - numero2;
        }
    }
}
