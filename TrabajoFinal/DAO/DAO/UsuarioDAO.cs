using DAO.BEAN;
using DAO.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class UsuarioDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD_ADO"].ConnectionString;  //conexion para ADO
        #endregion

        public void ListaUsuario()//EF
        {
            Console.Clear();
            using (var db = new connBD_EF())
            {
                List<tb_usuario> listacliente = db.tb_usuario.ToList();
                Console.WriteLine("Id_Usuario \t Codigo_Usuario \t User \t\t Tipo_usuario \t\t\t Estado");
                foreach (var item in listacliente)
                {
                    Console.WriteLine(item.idUsuario + "\t\t" + item.cod_usuario + "\t\t\t" + item.user_acceso + "\t\t\t" + item.idTipo_usuario + "\t\t" + item.estado_usuario);
                }

            }
        }

        public List<UsuarioBEAN> listaUsuario_ADO() //Listar ADO
        {
            List<UsuarioBEAN> lista = new List<UsuarioBEAN>();
            UsuarioBEAN usuario_list;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_LISTAR_USUARIO", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                usuario_list = new UsuarioBEAN();
                                usuario_list.user_name = Convert.ToString(datos[0]);
                                usuario_list.tipo_usuario = Convert.ToString(datos[1]);
                                lista.Add(usuario_list);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return lista;
        }

        public Boolean registoUsuario_ADO(UsuarioBEAN usuario_agregar) //Registrar ADO
        {
            bool rpta = false;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_REGISTRAR_USUARIO", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@user_acceso", usuario_agregar.user_name);
                        comando.Parameters.AddWithValue("@pass", usuario_agregar.pass_name);
                        comando.Parameters.AddWithValue("@nombre_tipo_usuario", usuario_agregar.tipo_usuario);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        rpta = true;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return rpta;
        }

        public List<UsuarioBEAN> registroListadoUsuario(UsuarioBEAN usuario_agregar_list) //Registrar agregar_listar ADO
        {
            List<UsuarioBEAN> lista = new List<UsuarioBEAN>();
            UsuarioBEAN usuario_list;

            try
            { 
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_REGISTRAR_LISTAR_USUARIO", conexion))
                     {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@user_acceso", usuario_agregar_list.user_name);
                        comando.Parameters.AddWithValue("@pass", usuario_agregar_list.pass_name);
                        comando.Parameters.AddWithValue("@nombre_tipo_usuario", usuario_agregar_list.tipo_usuario);
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                usuario_list = new UsuarioBEAN();
                                usuario_list.user_name = Convert.ToString(datos[0]);
                                usuario_list.tipo_usuario = Convert.ToString(datos[1]);
                                lista.Add(usuario_list);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public Boolean editarUsuario_ADO(UsuarioBEAN usuario_edicion) //Editar ADO
        {
            bool rpta = false;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_EDITAR_USUARIO", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@user_acceso_old", usuario_edicion.user_name);
                        comando.Parameters.AddWithValue("@user_acceso_new", usuario_edicion.user_name_new);
                        comando.Parameters.AddWithValue("@pass", usuario_edicion.pass_name);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        rpta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return rpta;
        }

        public List<UsuarioBEAN> editarListadoUsuario(UsuarioBEAN usuario_edicion_list) //Editar editar_listar ADO
        {
            List<UsuarioBEAN> lista = new List<UsuarioBEAN>();
            UsuarioBEAN usuario_list;

            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_EDITAR_LISTAR_USUARIO", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@user_acceso_old", usuario_edicion_list.user_name);
                        comando.Parameters.AddWithValue("@user_acceso_new", usuario_edicion_list.user_name_new);
                        comando.Parameters.AddWithValue("@pass", usuario_edicion_list.pass_name);
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                usuario_list = new UsuarioBEAN();
                                usuario_list.user_name = Convert.ToString(datos[0]);
                                usuario_list.tipo_usuario = Convert.ToString(datos[1]);
                                lista.Add(usuario_list);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public UsuarioBEAN buscarUsuario_username(string user_name) //Buscar usuario ADO
        {
            UsuarioBEAN usuario = new UsuarioBEAN();
            using (var conexion = new SqlConnection(_stringConnection))
            {
                using (var comando = new SqlCommand("SP_BUSCAR_USUARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@user_acceso", user_name);
                    conexion.Open();
                    using (var datos = comando.ExecuteReader())
                    {
                        while (datos.Read())
                        {
                            usuario.user_name = datos[0].ToString();
                            usuario.nombre_tipo_usuario = datos[1].ToString();
                        }
                    }
                }
            }
            return usuario;
        }
    }
}
