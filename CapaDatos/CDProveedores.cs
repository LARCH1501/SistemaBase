using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDProveedores
    {
        private CDConexion conexion = new CDConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarMarcas()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarMarcas";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;

        }
        public DataTable ListarProveedores()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CerrarConexion();
            return Tabla;

        }

        public void InsertarProveedores(int idCategoria, int idMarca, string nombre_prov, string direccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcategoria", idCategoria);
            comando.Parameters.AddWithValue("@idmarca", idMarca);
            comando.Parameters.AddWithValue("@Nombre_prov", nombre_prov);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarProveedores(int idpro, int idCategoria, int idMarca, string nombre_prov, string direccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Proveedores set Idcategoria=" + idCategoria +
                ",Idmarca=" + idMarca + ",Nombre_prov=" + nombre_prov +
                ",Direccion=" + direccion +
                "'WHERE Idproveedor=" + idpro;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
        public void EliminarProducto(int idprod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE Proveedores where Idproveedor=" + idprod;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
