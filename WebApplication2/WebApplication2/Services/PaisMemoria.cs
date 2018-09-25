using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class PaisMemoria:InterfacePais
    {
        public List<string> Obtener()
        {
            List<string> paises = new List<string>() { "mexico", "peru", "venesuela", "japon", "china" };

            return paises;
        }
    }
}
