using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datVersion
    {
        private readonly static datVersion _instancia = new datVersion();
        public static datVersion Instancia
        {
            get { return datVersion._instancia; }
        }
        // Listar versiones
        public List<entVersion> listarVersion(int idProy)
        {
            SqlCommand cm = null;
            List<entVersion> versiones = new List<entVersion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaVersiones", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", idProy);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entVersion v = new entVersion();
                    v.id_version = Convert.ToInt32(dr["id_version"]);
                    v.id_proy = Convert.ToInt32(dr["id_proy"]);
                    v.nombre_version = dr["nombre_version"].ToString();
                    v.descripcion = dr["descripcion"].ToString();
                    versiones.Add(v);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
            return versiones;
        }
        // insertar
        public void insertaVerion(entVersion ver)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaVersiones", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", ver.id_proy);
                cm.Parameters.AddWithValue("@nombre_version", ver.nombre_version);
                cm.Parameters.AddWithValue("@descripcion", ver.descripcion);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }
    }
}
