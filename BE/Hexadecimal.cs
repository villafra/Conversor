using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Hexadecimal
    {
        public string Numero { get; set; }

        public int DevolverValor(char numero)
        {
            //Tabla valor = (Tabla)Enum.Parse(typeof(Tabla),numero);

            if (Convert.ToInt32(numero) < 10)
            {
                return Convert.ToInt32(numero);
            }
            else
            {
                return (int)(Tabla)Enum.Parse(typeof(Tabla), numero.ToString());
            }
        }
        public enum Tabla
        {
            A=10,
            B=11,
            C=12,
            D=13,
            E=14,
            F=15
        }
    }
}
