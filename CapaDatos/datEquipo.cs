using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEquipo
    {
        private readonly static datEquipo _instancia = new datEquipo();
        public static datEquipo Instancia
        {
            get { return datEquipo._instancia; }
        }
    }
}
