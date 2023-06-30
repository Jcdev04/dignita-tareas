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
            //cambiar el nombre del servidor
           cn.ConnectionString = "Data Source=LAPTOP-BH5K91S6\\SQLEXPRESS; Initial Catalog=DB_DIGNITA; Integrated Security = True";
          // cn.ConnectionString = "Data Source=DESKTOP-6GFT52T; Initial Catalog=DB_DIGNITA; Integrated Security = True";
            
            return cn;
        }

    }
}
