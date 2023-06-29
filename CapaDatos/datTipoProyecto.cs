using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datTipoProyecto
    {
        private static readonly datTipoProyecto _instancia = new datTipoProyecto();
        public static datTipoProyecto Instancia
        {
            get { return datTipoProyecto._instancia; }
        }

        public List<entTipoProyecto> listarTipoProyecto()
        {
            SqlCommand cm = null;
            List<entTipoProyecto> lista = new List<entTipoProyecto>();

            try
            {
                SqlConnection sql = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaTipoProyecto", sql);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entTipoProyecto tp = new entTipoProyecto();
                    tp.id_tipo_proy = Convert.ToInt32(dr["id_tipo_proy"]);
                    tp.nombre = dr["nombre"].ToString();
                    lista.Add(tp);
                }
            }catch(Exception ex){
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }

            return lista;
        }

    }
}
