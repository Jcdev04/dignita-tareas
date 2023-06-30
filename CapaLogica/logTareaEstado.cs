using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTareaEstado
    {
        private readonly static logTareaEstado _instancia = new logTareaEstado();
        public static logTareaEstado Instancia
        {
            get { return logTareaEstado._instancia; }
        }


        public void modificaEstadoTarea(entTarea et)
        {
            datTarea.Instancia.modificaEstadoTarea(et);
        }

        public List<entEstadoTarea> ListarEstadoTarea()
        {
            return datEstadoTarea.Instancia.ListarEstadoTarea();
        }
    }
}
