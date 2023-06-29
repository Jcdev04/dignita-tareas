using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class datRequerimiento
    {
        private static readonly datRequerimiento _instancia = new datRequerimiento();
        public static datRequerimiento Instancia
        {
            get { return datRequerimiento._instancia; }
        }
        //Listar requerimiento
        public List<entRequerimiento> listarRequerimientos(int idProy)
        {
            List<entRequerimiento> lista = new List<entRequerimiento>();
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaRequerimientos", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", idProy);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimiento p = new entRequerimiento();
                    p.id_proy = Convert.ToInt32(dr["id_proy"]);
                    p.id_req = Convert.ToInt32(dr["id_req"]);
                    p.nombre_req = dr["nombre_req"].ToString();
                    p.descripcion = dr["descripcion"].ToString();
                    p.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(p);
                }
            } catch (Exception ex)
            {
                throw ex;
            }
            finally {
                cm.Connection.Close();
            }
            return lista;
        }
        //Agregar requerimiento
        public void insertaRequerimiento(entRequerimiento ep)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaRequerimiento", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", ep.id_proy);
                cm.Parameters.AddWithValue("@nombre_req", ep.nombre_req);
                cm.Parameters.AddWithValue("@descripcion", ep.descripcion);
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

        //Edita requerimiento
        public void editarRequerimiento(entRequerimiento ep)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spEditaRequerimiento", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", ep.id_proy);
                cm.Parameters.AddWithValue("@nombre_req", ep.nombre_req);
                cm.Parameters.AddWithValue("@descripcion", ep.descripcion);
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
        //Inhabilita requerimiento
        public void inhabilitaRequerimiento(int id_req)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInhabilitaRequerimiento", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_req", id_req);
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
