using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEtapaTarea
    {
        private readonly static logEtapaTarea _instancia = new logEtapaTarea();
        public static logEtapaTarea Instancia
        {
            get { return logEtapaTarea._instancia; }
        }

        // Listar
        public List<entEtapasTarea> ListarEtapaTarea()
        {
            return datEtapaTarea.Instancia.ListarEtapaTarea();
        }
    }
}
