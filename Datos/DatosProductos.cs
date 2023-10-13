﻿using proyectoFinalAPI.Conexion;
using proyectoFinalAPI.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace proyectoFinalAPI.Datos
{
    public class DatosProductos
    {
        ConexionBD cn = new ConexionBD();
        public async Task <List<ModeloProductos>> MostrarProductos()
        {
            var lista = new List<ModeloProductos>();
            // El using abre la conexion y la cierra automaticamente
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("mostrarProductos", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using(var item = await cmd.ExecuteReaderAsync()) 
                    {
                    while(await item.ReadAsync())
                        {
                        var mproductos = new ModeloProductos();
                            mproductos.id = (int)item["id"];
                            mproductos.descripcion = (string)item["descripcion"];
                            mproductos.precio = (decimal)item["precio"];
                            lista.Add(mproductos);
                        }
                    }
                }
            }
            // La lista retorna todos los datos
            return lista;    
        }
    }
}
