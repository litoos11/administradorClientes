using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace Dao
{
    public class clContactoDao
    {
        private static string stringConexion = clConexion.connectionString;

        public int crearNuevoContacto(clContactoEntity contacto)
        {
            int respuesta;
            using(SqlConnection conexion = new SqlConnection(stringConexion))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand("SP_NUEVO_CONTACTO", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idCliente", SqlDbType.Int).Value = contacto.idCliente;
                        command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = contacto.nombre;
                        command.Parameters.Add("@aPaterno", SqlDbType.VarChar, 50).Value = contacto.apellidoPaterno;
                        command.Parameters.Add("@aMaterno", SqlDbType.VarChar, 50).Value = contacto.apellidoMaterno;
                        command.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = contacto.telefono;
                        command.Parameters.Add("@direccion", SqlDbType.VarChar, 1024).Value = contacto.direccion;
                        command.Parameters.Add("@puesto", SqlDbType.VarChar, 30).Value = contacto.puesto;
                        command.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = contacto.correo;

                        conexion.Open();
                        respuesta = command.ExecuteNonQuery();
                    }

                }catch(Exception ex)
                {
                    ex.Message.ToString();
                    respuesta = 0;
                }
                finally
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        public DataTable buscarContactosPorIdCliente(int idCliente)
        {
            DataTable dtContactos = new DataTable();

            using(SqlConnection conexion = new SqlConnection(stringConexion))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand("SP_BUSCAR_CONTACTOS_POR_IDCLIENTE", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        conexion.Open();
                        adapter.Fill(dtContactos);
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

            return dtContactos;
        }

        public int editarContacto(clContactoEntity contacto)
        {
            int respuesta;
            using (SqlConnection conexion = new SqlConnection(stringConexion))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("SP_EDITAR_CONTACTO", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idContacto", SqlDbType.Int).Value = contacto.idContacto;
                        command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = contacto.nombre;
                        command.Parameters.Add("@aPaterno", SqlDbType.VarChar, 50).Value = contacto.apellidoPaterno;
                        command.Parameters.Add("@aMaterno", SqlDbType.VarChar, 50).Value = contacto.apellidoMaterno;
                        command.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = contacto.telefono;
                        command.Parameters.Add("@direccion", SqlDbType.VarChar, 1024).Value = contacto.direccion;
                        command.Parameters.Add("@puesto", SqlDbType.VarChar, 30).Value = contacto.puesto;
                        command.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = contacto.correo;

                        conexion.Open();
                        respuesta = command.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    respuesta = 0;
                }
                finally
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        public int eliminarContacto(int idContacto)
        {
            int respuesta;
            using (SqlConnection conexion = new SqlConnection(stringConexion))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("SP_ELIMINAR_CONTACTO", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idContacto", SqlDbType.Int).Value = idContacto;

                        conexion.Open();
                        respuesta = command.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    ex.Message.ToString();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

    }
}
