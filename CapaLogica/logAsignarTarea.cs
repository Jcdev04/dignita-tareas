using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaLogica
{
    public class logAsignarTarea
    {
        public static readonly logAsignarTarea _instancia = new logAsignarTarea();
        public static logAsignarTarea Instancia
        {
            get { return logAsignarTarea._instancia; }
        }

        public List<entTrabajador> listarTrabajadoresDisponibles(int proy)
        {
            return datAsignacion.Instancia.listarTrabajadoresDisponibles(proy);
        }

        public void asignarTarea(entAsignacion ea)
        {
            datAsignacion.Instancia.agregarAsignacion(ea);
        }
    }
}
