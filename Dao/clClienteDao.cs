using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Dao
{
    public class clClienteDao
    {

        private static string stringConexion = clConexion.connectionString;

        public DataTable buscarClientes()
        {
            DataTable dtClientes = new DataTable();

            using (SqlConnection conexion = new SqlConnection(stringConexion))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("SP_BUSCAR_CLIENTES", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        conexion.Open();
                        adapter.Fill(dtClientes);
                    }

                }catch(Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    conexion.Close();
                }

            }



            return dtClientes;
        }


        public DataTable buscarClientesPorNombre(string nombre)
        {
            DataTable dtClientes = new DataTable();
            using (SqlConnection conexion = new SqlConnection(stringConexion))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("SP_BUSCAR_CLIENTE_POR_NOMBRE", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@pNombre", SqlDbType.VarChar, 50).Value = nombre;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        conexion.Open();
                        adapter.Fill(dtClientes);

                    }

                }catch(Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return dtClientes;
        }
    }
}
