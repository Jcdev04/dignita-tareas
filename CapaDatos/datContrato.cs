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
    }
}
