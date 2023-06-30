using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datRegistroTarea
    {
        public static readonly datRegistroTarea _instancia = new datRegistroTarea();
        public static datRegistroTarea Instancia
        {
            get { return datRegistroTarea._instancia; }
        }


        // Insertar
        public void agregarRegistroTarea(entRegistroTarea ec)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaRegistroTarea", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_tarea", ec.id_tarea);
                cm.Parameters.AddWithValue("@fecha_inicio", ec.fecha_inicio);
                cm.Parameters.AddWithValue("@fecha_final", ec.fecha_fin);
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
