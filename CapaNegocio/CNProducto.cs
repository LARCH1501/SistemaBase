﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {
        private CDProducto objetoCD = new CDProducto();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarProd(string nombre, string desc, string marca, string precio, string stock)
        {
            objetoCD.Insetar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }
        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
