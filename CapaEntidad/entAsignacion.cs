using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAsignacion
    {
        public string id_asignacion { get; set; }
        public string dni_trabajador { get; set; }
        public int id_tarea { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
    }
}
