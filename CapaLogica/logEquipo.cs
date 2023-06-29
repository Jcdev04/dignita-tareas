using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logEquipo
    {
        private readonly static logEquipo _instancia = new logEquipo();
        public static logEquipo Instancia
        {
            get { return logEquipo._instancia; }
        }

        public List<entEquipo> Equipos()
        {
            return datEquipo.Instancia.ListarEquipo();
        }

        public void AgregarEquipo(entEquipo e)
        {
            datEquipo.Instancia.AgregarProyectoAEquipo(e);
        }
    }
}
