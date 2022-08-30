using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    public interface IConvertible<T>
    {
        int DevolverDecimal(T numero);
        string DevolverBinario(T numero);
        string DevolverHexaDecimal(T numero);
      

    }
}
