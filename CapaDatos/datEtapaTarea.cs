using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEtapaTarea
    {
        private static readonly datEtapaTarea _instancia = new datEtapaTarea();
        public static datEtapaTarea Instancia
        {
            get { return datEtapaTarea._instancia; }
        }

        //Listar 

        public List<entEtapasTarea> ListarEtapaTarea()
        {
            List<entEtapasTarea> etapas = new List<entEtapasTarea>();
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaEtapaTarea", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entEtapasTarea e = new entEtapasTarea();
                    e.id_etapa = int.Parse(dr["id_etapa"].ToString());
                    e.nombre = dr["nombre"].ToString();
                    if (dr["id_etapa"] != DBNull.Value)
                    {
                        e.id_etapa = int.Parse(dr["id_etapa"].ToString());
                    }

                    etapas.Add(e);
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


            return etapas;
        }
    }
}
