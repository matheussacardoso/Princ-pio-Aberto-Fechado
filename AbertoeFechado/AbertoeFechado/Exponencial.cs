using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbertoeFechado
{
    public class Exponencial : Calculadora
    {
        float numero, exponencial;

        public Exponencial(float numero, float exponencial)
        {
            this.numero = numero;
            this.exponencial = exponencial;
        }
        public override float calcular()
        {
            int a;
            float valor=1;
            for (a = 0; a < exponencial; a++)
            {
                valor = valor * numero;
            }
            return valor;
        }
    }
}
