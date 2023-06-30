using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTarea
    {
        private readonly static logTarea _instancia = new logTarea();
        public static logTarea Instancia
        {
            get { return logTarea._instancia; }
        }


        public List<entTarea> ListarTareas(int id_req)
        {
            return datTarea.Instancia.listarTareas(id_req);
        }

        public List<entTarea> listarTareasDesarrollador(string dni)
        {
            return datTarea.Instancia.listarTareasDesarrollador(dni);
        }
    }
}
