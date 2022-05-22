using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDConexion
    {
        //Instanciamos la variable que trae la cadena de conexion hacia la base para encapsularla
        private SqlConnection Conexion = new SqlConnection("Server=LARCH;DataBase=SistemaBase;Integrated Security=true");

        //Metodo para abrir una conexion hacia la base
        public SqlConnection AbrirConexion()
        {
            //Si la conexion esta cerrada, que ejecute Open
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        //Metodo para cerrar una conexion hacia la base
        public SqlConnection CerrarConexion()
        {
            //Si la conexion esta abierta, que ejecute Close
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}