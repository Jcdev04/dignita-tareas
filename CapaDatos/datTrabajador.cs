using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class datTrabajador
    {
        private readonly static datTrabajador _instancia = new datTrabajador();
        public static datTrabajador Instancia
        {
            get { return datTrabajador._instancia; }
        }

    }
}
