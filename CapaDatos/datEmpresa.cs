using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEmpresa
    {
        private readonly static datEmpresa _instancia = new datEmpresa();
        public static datEmpresa Instancia
        {
            get { return datEmpresa._instancia; }
        }
        //Listar
        public List<entEmpresa> listarEmpresas()
        {
            List <entEmpresa> empresas = new List<entEmpresa>();
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaEmpresa", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entEmpresa e = new entEmpresa();
                    e.RUC = dr["RUC"].ToString();
                    e.razon_social = dr["razon_social"].ToString();
                    e.rubro = dr["rubro"].ToString();
                    e.direccion = dr["direccion"].ToString();
                    e.telefono = dr["telefono"].ToString();
                    e.correo = dr["correo"].ToString();
                    e.inhabilitado = Convert.ToBoolean(dr["inhabilitado"]);
                    empresas.Add(e);
                }
            } catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }


            return empresas;
        }
        //Agregar
        public void agregarEmpresa(entEmpresa e)
        {
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaEmpresa", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@RUC", e.RUC);
                cm.Parameters.AddWithValue("@razon_social", e.razon_social);
                cm.Parameters.AddWithValue("@rubro", e.rubro);
                cm.Parameters.AddWithValue("@direccion", e.direccion);
                cm.Parameters.AddWithValue("@telefono", e.telefono);
                cm.Parameters.AddWithValue("@correo", e.correo);
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
        //Modificar
        public void modificarEmpresa(entEmpresa e)
        {
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spModificarEmpresa", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@RUC", e.RUC);
                cm.Parameters.AddWithValue("@razon_social", e.razon_social);
                cm.Parameters.AddWithValue("@rubro", e.rubro);
                cm.Parameters.AddWithValue("@direccion", e.direccion);
                cm.Parameters.AddWithValue("@telefono", e.telefono);
                cm.Parameters.AddWithValue("@correo", e.correo);
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
        //Inhabilitar
        public void inhabilitarEmpresa(entEmpresa e)
        {
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spDeshabilitaEmpresa", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@ruc", e.RUC);
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
