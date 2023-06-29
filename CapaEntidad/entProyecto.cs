using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProyecto
    {
        public int id_proy { get; set; }
        public int tipo_proy { get; set; }
        public string nombre_proy { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public bool asignado { get; set; }
        public bool inhabilitado { get; set; }
    }
}
