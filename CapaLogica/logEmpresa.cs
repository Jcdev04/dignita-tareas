using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEmpresa
    {
        private readonly static logEmpresa _instancia = new logEmpresa();
        public static logEmpresa Instancia
        {
            get { return logEmpresa._instancia; }
        }
        //Listar
        public List<entEmpresa> Empresas()
        {
            return datEmpresa.Instancia.listarEmpresas();
        }
        //Agregar
        public void AgregarEmpresa(entEmpresa e)
        {
            datEmpresa.Instancia.agregarEmpresa(e);
        }
        //Modificar
        public void ModificarEmpresa(entEmpresa e)
        {
            datEmpresa.Instancia.modificarEmpresa(e);
        }
        //Inhabilitar
        public void InhabilitarEmpresa(entEmpresa e)
        {
            datEmpresa.Instancia.inhabilitarEmpresa(e);
        }
    }
}
