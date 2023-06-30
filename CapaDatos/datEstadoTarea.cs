using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datEstadoTarea
    {
        private readonly static datEstadoTarea _instancia = new datEstadoTarea();
        public static datEstadoTarea Instancia
        {
            get { return datEstadoTarea._instancia; }
        }


        //Listar 

        public List<entEstadoTarea> ListarEstadoTarea()
        {
            List<entEstadoTarea> estado = new List<entEstadoTarea>();
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListarEstadoTarea", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entEstadoTarea e = new entEstadoTarea();
                    e.id_estado = int.Parse(dr["id_estado"].ToString());
                    e.nombre = dr["nombre"].ToString();
                    if (dr["id_estado"] != DBNull.Value)
                    {
                        e.id_estado = int.Parse(dr["id_estado"].ToString());
                    }

                    estado.Add(e);
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


            return estado;
        }
    }
}
