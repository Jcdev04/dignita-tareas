using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datContrato
    {
        public static readonly datContrato _instancia = new datContrato();
        public static datContrato Instancia
        {
            get { return datContrato._instancia; }
        }

        public void agregarContrato(entContrato ec)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaContrato", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@ruc_emp", ec.ruc_emp);
                cm.Parameters.AddWithValue("@id_proyecto", ec.id_proyecto);
                cm.Parameters.AddWithValue("@costo", ec.costo);
                cm.Parameters.AddWithValue("@fecha_inicio", ec.fecha_inicio);
                cm.Parameters.AddWithValue("@fecha_fin", ec.fecha_fin);
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

        
        public int SeleccionarUltimoContrato()
        {
            int id_contrato=0;
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaUltimoContrato", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    id_contrato = Convert.ToInt32(dr["id_contrato"]);
                    // Realiza la operación deseada con el valor de id_contrato
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


            return id_contrato;
        }
        
        
    }
}
