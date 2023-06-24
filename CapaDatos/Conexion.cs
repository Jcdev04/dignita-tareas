using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection conexion()
        {
            SqlConnection cn = new SqlConnection();
            //Jesús
            cn.ConnectionString = "Data Source=cambiar\\SQLEXPRESS;Initial Catalog=BD_Dignita;Integrated Security=True";
            return cn;
        }

    }
}
