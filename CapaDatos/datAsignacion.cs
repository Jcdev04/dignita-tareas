using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class datAsignacion
    {
        public static readonly datAsignacion _instancia = new datAsignacion();
        public static datAsignacion Instancia
        {
            get { return datAsignacion._instancia; }
        }

        //Listar
        public List<entTrabajador> listarTrabajadoresDisponibles(int id_proy)
        {
            List<entTrabajador> lista = new List<entTrabajador>();
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListarDesarrolladoresPorProyecto", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", id_proy);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entTrabajador e = new entTrabajador();
                    e.dni = dr["dni"].ToString();
                    e.nombre = dr["nombre"].ToString();
                    e.apellido = dr["apellido"].ToString();
                    lista.Add(e);
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
            return lista;
        }

        public void agregarAsignacion(entAsignacion ec)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaAsignacion", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@dni_trabajador", ec.dni_trabajador);
                cm.Parameters.AddWithValue("@id_tarea", ec.id_tarea);
                cm.Parameters.AddWithValue("@fecha_inicio", ec.fecha_inicio);
                cm.Parameters.AddWithValue("@fecha_fin", ec.fecha_fin);
                cn.Open();
                cm.ExecuteNonQuery();
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
