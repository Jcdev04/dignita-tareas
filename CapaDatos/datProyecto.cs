using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProyecto
    {
        private readonly static datProyecto _instancia = new datProyecto();
        public static datProyecto Instancia
        {
            get { return datProyecto._instancia; }
        }
        //Listar proyecto
        public List<entProyecto> listarProyectos()
        {
            SqlCommand cm = null;
            List<entProyecto> proyectos = new List<entProyecto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListarProyectos", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entProyecto p = new entProyecto();
                    p.id_proy = Convert.ToInt32(dr["id_proy"]);
                    p.tipo_proy = Convert.ToInt32(dr["tipo_proy"]);
                    p.nombre_proy = dr["nombre_proy"].ToString();
                    p.descripcion = dr["descripcion"].ToString();
                    p.estado = Convert.ToBoolean(dr["estado"]);
                    p.asignado = Convert.ToBoolean(dr["asignado"]);
                    p.inhabilitado = Convert.ToBoolean(dr["inhabilitado"]);
                    proyectos.Add(p);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
            return proyectos;
        }

        public List<entProyecto> listarProyectosScrum(string dni)
        {
            SqlCommand cm = null;
            List<entProyecto> proyectos = new List<entProyecto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaProyectoScrum", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@dni_sm", dni);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entProyecto p = new entProyecto();
                    p.id_proy = Convert.ToInt32(dr["id_proy"]);
                    p.tipo_proy = Convert.ToInt32(dr["tipo_proy"]);
                    p.nombre_proy = dr["nombre_proy"].ToString();
                    p.descripcion = dr["descripcion"].ToString();
                    p.estado = Convert.ToBoolean(dr["estado"]);
                    p.asignado = Convert.ToBoolean(dr["asignado"]);
                    p.inhabilitado = Convert.ToBoolean(dr["inhabilitado"]);
                    proyectos.Add(p);
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
            return proyectos;
        }

        public List<entProyecto> listarProyectosContratados()
        {
            SqlCommand cm = null;
            List<entProyecto> proyectos = new List<entProyecto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("ListarProyectosContratados", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entProyecto p = new entProyecto();
                    p.id_proy = Convert.ToInt32(dr["id_proy"]);
                    p.tipo_proy = Convert.ToInt32(dr["tipo_proy"]);
                    p.nombre_proy = dr["nombre_proy"].ToString();
                    p.contratado = Convert.ToBoolean(dr["contratado"]);
                    p.descripcion = dr["descripcion"].ToString();
                    p.estado = Convert.ToBoolean(dr["estado"]);
                    p.asignado = Convert.ToBoolean(dr["asignado"]);
                    p.inhabilitado = Convert.ToBoolean(dr["inhabilitado"]);
                    proyectos.Add(p);
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
            return proyectos;
        }

        //Agregar
        public void insertaProyecto(entProyecto ep)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaProyecto", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@tipo_proy", ep.tipo_proy);
                cm.Parameters.AddWithValue("@nombre_proy", ep.nombre_proy);
                cm.Parameters.AddWithValue("@descripcion", ep.descripcion);
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
        //Editar
        public void editarProyecto(entProyecto ep)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spEditarProyecto", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", ep.id_proy);
                cm.Parameters.AddWithValue("@tipo_proy", ep.tipo_proy);
                cm.Parameters.AddWithValue("@nombre_proy", ep.nombre_proy);
                cm.Parameters.AddWithValue("@descripcion", ep.descripcion);
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }
        //Inhabilita
        public void inhabilitarProyecto(entProyecto ep)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInhabilitarProyecto", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", ep.id_proy);
                cn.Open();
                cm.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }
        //Contratar
        public void contratarProyecto(entProyecto ep)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spContratadoProyecto", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", ep.id_proy);
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
