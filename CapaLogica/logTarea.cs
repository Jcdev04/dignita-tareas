using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public void modificaRegistrarTarea(int id_proy)
        {
            datTarea.Instancia.modificaRegistrarTarea(id_proy);
        }


        public List<entTarea> listarTareasDesarrollador(string dni)
        {
            return datTarea.Instancia.listarTareasDesarrollador(dni);
        }
        public List<entTarea> listarTareasProy(int id_proy)
        {
            return datTarea.Instancia.listarTareasProyecto(id_proy);
        }

        public List<entTarea> listarTareasProyRegistradas(int id_proy)
        {
            return datTarea.Instancia.listarTareasProyectoRegistradas(id_proy);
        }

        public void insertaTarea(entTarea tar)
        {
            datTarea.Instancia.insertaTarea(tar);
        }
        // editar
        public void editarTarea(entTarea tar)
        {
            datTarea.Instancia.modificaTarea(tar);
        }
        public void inhabilitarTarea(entTarea tar)
        {
            datTarea.Instancia.inhabilitaTarea(tar.id_tarea);
        }
        public void modificarEstado( int id_tarea,int estado)
        {
            datTarea.Instancia.modificaEstadoTarea(id_tarea,estado );
        }

        public List<entTarea> listaTareasRegistrada(int id_proy)
        {
            return datTarea.Instancia.listarTareasRegistradas(id_proy);
        }

    }
}
