using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entContrato
    {
        public int id_contrato { get; set; }
        public string ruc_emp { get; set; }
        public int id_proyecto { get; set; }
        public float costo { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
    }
}
