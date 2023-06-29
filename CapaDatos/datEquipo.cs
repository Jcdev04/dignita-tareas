using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEquipo
    {
        private readonly static datEquipo _instancia = new datEquipo();
        public static datEquipo Instancia
        {
            get { return datEquipo._instancia; }
        }
        //Listar 

        public List<entEquipo> ListarEquipo()
        {
            List<entEquipo> equipos = new List<entEquipo>();
            SqlCommand cm = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListarEquipos", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entEquipo e = new entEquipo();
                    e.id_equipo = int.Parse(dr["id_equipo"].ToString());
                    e.nombre_equipo = dr["Nombre_Equipo"].ToString();
                    if (dr["id_proy"] != DBNull.Value)
                    {
                        e.id_proy = int.Parse(dr["id_proy"].ToString());
                    }
                   
                    equipos.Add(e);
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


            return equipos;
        }

        //Insertar
        public void AgregarProyectoAEquipo(entEquipo e)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spAgregarProyectoAEquipo", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_equipo", e.id_equipo);
                cm.Parameters.AddWithValue("@id_proy",e.id_proy);
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
