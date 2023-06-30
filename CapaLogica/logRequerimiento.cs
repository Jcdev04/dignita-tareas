using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimiento
    {
        private readonly static logRequerimiento _instancia = new logRequerimiento();
        public static logRequerimiento Instancia
        {
            get { return logRequerimiento._instancia; }
        }
        //Listar
        public List<entRequerimiento> listarRequerimientos(int idProy)
        {
            return datRequerimiento.Instancia.listarRequerimientos(idProy);
        }
        // insertar
        public void insertarRequerimiento(entRequerimiento req)
        {
            datRequerimiento.Instancia.insertaRequerimiento(req);
        }
        // editar
        public void editarRequerimiento(entRequerimiento req)
        {
            datRequerimiento.Instancia.editarRequerimiento(req);
        }
        public void inhabilitarRequerimiento(int id_req)
        {
            datRequerimiento.Instancia.inhabilitaRequerimiento(id_req);
        }
    }
}
