using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVersion
    {
        public int id_version { get; set; }
        public string nombre_req { get; set; }
        public int id_proy { get; set; }
        public string descripcion { get; set; }
    }
}
