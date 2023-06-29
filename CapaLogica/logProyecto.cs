using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProyecto
    {
        private readonly static logProyecto _instancia = new logProyecto();
        public static logProyecto Instancia
        {
            get { return logProyecto._instancia; }
        }
        //Listar
        public List<entProyecto> listarProyectos()
        {
            List<entProyecto> proyectos = new List<entProyecto>();
            proyectos = datProyecto.Instancia.listarProyectos();
            return proyectos;
        }

        //ListarProyectosContratados

        public List<entProyecto> listarProyectosContratados()
        {
            List<entProyecto> proyectos = new List<entProyecto>();
            proyectos = datProyecto.Instancia.listarProyectosContratados();
            return proyectos;
        }
        // Listar proyectos por scrum master
        public List<entProyecto> listarProyectoScrum(string dni)
        {
            List<entProyecto> proyectos = new List<entProyecto>();
            proyectos = datProyecto.Instancia.listarProyectosScrum(dni);
            return proyectos;
        }
        //Agregar
        public void agregarProyecto(entProyecto p)
        {
            datProyecto.Instancia.insertaProyecto(p);
        }
        //Editar
        public void editarProyecto(entProyecto p)
        {
            datProyecto.Instancia.editarProyecto(p);
        }
        //Inhabilitar
        public void inhabilitarProyecto(entProyecto p)
        {
            datProyecto.Instancia.inhabilitarProyecto(p);
        }
        //Contratar
        public void contratarProyecto(entProyecto p)
        {
            datProyecto.Instancia.contratarProyecto(p);
        }
    }
}
