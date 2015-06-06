using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LIBNEGOCIO
{
    public static class ClsAplicacion1
    {
        static SqlConnection cn = new SqlConnection(ClsConexion.Neptuno);
        public static DataTable ListarPedidos()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_ListarPedidos", cn);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }
        public static DataTable ProductosVendidosporPedidos(string idpedidos)
        {
            SqlCommand cmd = new SqlCommand(
                    "usp_ProductosVendidosporPedidos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpedidos", idpedidos);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }
        public static DataTable DatosdelEmpleados(string idempleados)
        {
            SqlCommand cmd = new SqlCommand("usp_DatosdelEmpleados", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigos", idempleados);
            cn.Open();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            cn.Close();
            return tbl;
        }
    }
}
