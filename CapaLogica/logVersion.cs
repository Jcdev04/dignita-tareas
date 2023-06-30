using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logVersion
    {
        private readonly static logVersion _instancia = new logVersion();
        public static logVersion Instancia
        {
            get { return logVersion._instancia; }
        }
        public List<entVersion> listarVersion(int id)
        {
            return datVersion.Instancia.listarVersion(id);
        }

        public void insertarVersion(entVersion v)
        {
            datVersion.Instancia.insertarVersion(v);
        }
    }
}
