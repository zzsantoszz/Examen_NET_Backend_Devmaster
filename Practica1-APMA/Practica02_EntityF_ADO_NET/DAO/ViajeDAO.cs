using Practica02_EntityF_ADO_NET.BEAN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_EntityF_ADO_NET.DAO
{
    public class ViajeDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

        /*
         CREATE PROCEDURE SP_VIAJE_List as select idViaje, idTarjeta, idPais, fechaInicioViaje, fechaFinViaje, estadoViaje from tbViaje;
         */
        public List<ViajeBEAN> listaViajes()
        {
            List<ViajeBEAN> lista = new List<ViajeBEAN>();
            ViajeBEAN viaje;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_VIAJE_List", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                viaje = new ViajeBEAN();
                                viaje.IdViaje = Convert.ToInt32(datos[0]);
                                viaje.IdTarjeta = Convert.ToInt32(datos[1]);
                                viaje.IdPais = Convert.ToInt32(datos[2]);
                                viaje.Fechainicioviaje = Convert.ToDateTime(datos[3]);
                                viaje.Fechafinviaje = Convert.ToDateTime(datos[4]);
                                viaje.EstadoViaje = Convert.ToString(datos[5]);
                                lista.Add(viaje);
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
        /*
         CREATE PROCEDURE SP_ROL_RegistrarViaje
        (@idTarjeta int, @idPais int, @fechaInicioViaje datetime, @fechaFinViaje datetime, @estadoViaje varchar(1))
        as
        INSERT INTO tbViaje(idTarjeta, idPais, fechaInicioViaje, fechaFinViaje, estadoViaje)
        values (@idTarjeta, @idPais, @fechaInicioViaje, @fechaFinViaje, @estadoViaje)
        SELECT idTarjeta, idPais, fechaInicioViaje, fechaFinViaje, estadoViaje FROM tbViaje;
                 
         */
        public List<ViajeBEAN> RegistroListaViaje(ViajeBEAN prolBEAN)
            {
                List<ViajeBEAN> lista = new List<ViajeBEAN>();
                ViajeBEAN viaje;
                try
                {
                    using (var conexion = new SqlConnection(_stringConnection))
                    {
                        using (var comando = new SqlCommand("SP_ROL_RegistrarViaje", conexion))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("@idTarjeta",prolBEAN.IdTarjeta);
                            comando.Parameters.AddWithValue("@idPais", prolBEAN.IdPais);
                            comando.Parameters.AddWithValue("@fechaInicioViaje",prolBEAN.Fechainicioviaje);
                            comando.Parameters.AddWithValue("@fechaFinViaje",prolBEAN.Fechafinviaje);
                            comando.Parameters.AddWithValue("@estadoViaje",prolBEAN.EstadoViaje);
                            conexion.Open();
                            using (var datos = comando.ExecuteReader())
                            {
                                while (datos.Read())
                                {
                                    viaje = new ViajeBEAN();
                                    viaje.IdViaje = Convert.ToInt32(datos[0]);
                                    viaje.IdTarjeta = Convert.ToInt32(datos[1]);
                                    viaje.IdPais = Convert.ToInt32(datos[2]);
                                    viaje.Fechainicioviaje = Convert.ToDateTime(datos[3]);
                                    viaje.Fechafinviaje = Convert.ToDateTime(datos[4]);
                                    viaje.EstadoViaje = Convert.ToString(datos[5]);
                                    lista.Add(viaje);
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
                return listaViajes();
            }

        

    }
}
