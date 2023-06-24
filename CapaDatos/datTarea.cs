using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datTarea
    {
        private readonly static datTarea _instancia = new datTarea();
        public static datTarea Instancia
        {
            get { return datTarea._instancia; }
        }
    }
}
