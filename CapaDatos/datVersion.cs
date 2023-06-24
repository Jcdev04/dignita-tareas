using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datVersion
    {
        private readonly static datVersion _instancia = new datVersion();
        public static datVersion Instancia
        {
            get { return datVersion._instancia; }
        }
    }
}
