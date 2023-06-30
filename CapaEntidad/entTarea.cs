using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTarea
    {
        public int id_tarea { get; set; }
        public int id_req { get; set; }
        public int id_etapa { get; set; }
        public string nombre_t { get; set; }
        public string descripcion { get; set; }
        public int estado_tarea { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_final { get; set; }
    }
}
