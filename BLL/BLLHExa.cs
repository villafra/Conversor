using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BE;
using Interfases;

namespace BLL
{
    public class BLLHexa : IConvertible<Hexadecimal>
    {
        public string DevolverBinario(Hexadecimal numero)
        {
            int Decimal = DevolverDecimal(numero);


        }

        public int DevolverDecimal(Hexadecimal numero)
        {
            List<int> valores = new List<int>();
            double resultado = 0;
            foreach(char c in numero.Numero)
            {
                valores.Add(numero.DevolverValor(c));
            }
            valores.Reverse();
            int x = 0;
            foreach (int num in valores)
            {
                resultado += num * Math.Pow(Convert.ToDouble(16), Convert.ToDouble(x++));
            }
            return (int)resultado;
        }

        public string DevolverHexaDecimal(Hexadecimal numero)
        {
            throw new NotImplementedException();
        }
    }
}
