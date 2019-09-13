using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Dao
{
    public class clClienteDao
    {

        private static string stringConexion = clConexion.connectionString;

        #region CRUD Cliente
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

        public int crearNuevoCliente(clClienteEntity cliente) {
            int respuesta;
            using (SqlConnection conexion = new SqlConnection(stringConexion)) {
                try {
                    using (SqlCommand command = new SqlCommand("SP_NUEVO_CLIENTE", conexion)) {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@razon", SqlDbType.VarChar, 100).Value = cliente.razonSocial;
                        command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = cliente.nombreComercial;
                        command.Parameters.Add("@rfc", SqlDbType.VarChar, 13).Value = cliente.rfc;
                        command.Parameters.Add("@curp", SqlDbType.VarChar, 20).Value = cliente.curp;
                        command.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = cliente.telefono;
                        command.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = cliente.correo;
                        command.Parameters.Add("@direccion", SqlDbType.VarChar, 1024).Value = cliente.direccion;


                        conexion.Open();
                        respuesta = command.ExecuteNonQuery();
                    }

                }catch(Exception ex) {
                    respuesta = 0;
                    ex.Message.ToString();
                } finally {
                    conexion.Close();
                }
            }
            return respuesta;
        }


        public int editarCliente(clClienteEntity cliente) {

            int respuesta;

            using (SqlConnection conexion = new SqlConnection(stringConexion)) {
                try {
                    using (SqlCommand command = new SqlCommand("SP_EDITAR_CLIENTE", conexion)) {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idCliente", SqlDbType.Int).Value = cliente.idCliente;
                        command.Parameters.Add("@razon", SqlDbType.VarChar, 100).Value = cliente.razonSocial;
                        command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = cliente.nombreComercial;
                        command.Parameters.Add("@rfc", SqlDbType.VarChar, 13).Value = cliente.rfc;
                        command.Parameters.Add("@curp", SqlDbType.VarChar, 20).Value = cliente.curp;
                        command.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = cliente.telefono;
                        command.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = cliente.correo;
                        command.Parameters.Add("@direccion", SqlDbType.VarChar, 1024).Value = cliente.direccion;

                        conexion.Open();
                        respuesta = command.ExecuteNonQuery();
                    }

                } catch (Exception ex) {
                    respuesta = 0;
                    ex.Message.ToString();
                } finally {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        public int eliminarCliente(int idCliente) {
            int respuesta;
            using (SqlConnection conexion = new SqlConnection(stringConexion)) {
                try {
                    using (SqlCommand command = new SqlCommand("SP_ELIMINAR_CLIENTE", conexion)) {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;

                        conexion.Open();
                        respuesta = command.ExecuteNonQuery();
                    }

                } catch (Exception ex) {
                    respuesta = 0;
                    ex.Message.ToString();
                } finally {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        #endregion

    }
}
