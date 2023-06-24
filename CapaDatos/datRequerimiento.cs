using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datRequerimiento
    {
        private static readonly datRequerimiento _instancia = new datRequerimiento();
        public static datRequerimiento Instancia
        {
            get { return datRequerimiento._instancia; }
        }



    }
}
