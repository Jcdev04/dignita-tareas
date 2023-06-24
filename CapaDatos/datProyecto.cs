using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProyecto
    {
        private readonly static datProyecto _instancia = new datProyecto();
        public static datProyecto Instancia
        {
            get { return datProyecto._instancia; }
        }
    }
}
