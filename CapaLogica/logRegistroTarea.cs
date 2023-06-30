using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logRegistroTarea
    {
        private readonly static logRegistroTarea _instancia = new logRegistroTarea();
        public static logRegistroTarea Instancia
        {
            get { return logRegistroTarea._instancia; }
        }

        public void RegistrarTarea(entRegistroTarea tarea)
        {
            datRegistroTarea.Instancia.agregarRegistroTarea(tarea);
        }

        /*public List<entRegistroTarea> ListarRegistroTareas()
        {
            return datRegistroTarea.Instancia.listarRegistroTareas();
        }

        public void insertaTarea(entRegistroTarea tar)
        {
            datRegistroTarea.Instancia.insertaRegistroTarea(tar);
        }*/
    }
}
