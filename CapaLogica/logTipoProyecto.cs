using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoProyecto
    {
        private readonly static logTipoProyecto _instancia = new logTipoProyecto();
        public static logTipoProyecto Instancia
        {
            get { return logTipoProyecto._instancia; }
        }

        public List<entTipoProyecto> listarTipoProyecto()
        {
            return datTipoProyecto.Instancia.listarTipoProyecto();
        }

    }
}
