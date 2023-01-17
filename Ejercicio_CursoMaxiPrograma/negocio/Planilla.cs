using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Collections;

namespace negocio
{
	public class Planilla
	{
		public List<Jugador> Listar()
		{
            List<Jugador> lista = new List<Jugador>();
            AccesoDatos datos = new AccesoDatos();
            try
			{

				datos.setearConsulta("select j.Nombre, j.Edad, p.Descripcion, j.Peso, j.UrlImagen, j.Altura, J.Id  from JUGADORES J, POSICION P where j.IdPosicion = p.Id");
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					Jugador temporal = new Jugador();
					temporal.Id = (int)datos.Lector["Id"];
					temporal.Nombre = (string)datos.Lector["Nombre"];
					temporal.Edad = (int)datos.Lector["Edad"];
					temporal.Posicion = new Posicion();
					temporal.Posicion.Descripcion = (string)datos.Lector["Descripcion"];
					temporal.Peso = (double)datos.Lector["Peso"];
					temporal.UrlImagen = (string)datos.Lector["UrlImagen"];
					temporal.Altura = (double)datos.Lector["Altura"];

					lista.Add(temporal);
				}
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void agregar(Jugador jugador)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("insert into JUGADORES values ('" + jugador.Nombre + "', " + jugador.Edad + ", '" + jugador.UrlImagen + "', @IdPosicion , " + jugador.Peso + ", " + jugador.Altura + ")");
				datos.setearParametro("@IdPosicion", jugador.Posicion.Id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void modificar(Jugador jugador)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("update JUGADORES set Nombre = @nombre, Edad = @edad, UrlImagen = @img, IdPosicion = @idposi, Peso = @peso, Altura = @altu where Id = @id");
				datos.setearParametro("@nombre", jugador.Nombre);
				datos.setearParametro("@edad", jugador.Edad);
				datos.setearParametro("@img", jugador.UrlImagen);
				datos.setearParametro("@idposi", jugador.Posicion.Id);
				datos.setearParametro("@peso", jugador.Peso);
				datos.setearParametro("@altu", jugador.Altura);
				datos.setearParametro("@id", jugador.Id);

				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally 
			{ 
				datos.cerrarConexion();
			}
		}
		public void eliminarFijo(int id)
		{
			try
			{
				AccesoDatos datos = new AccesoDatos();
				datos.setearConsulta("delete from JUGADORES where Id = @id");
				datos.setearParametro("@id", id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void eliminarLogico(int id)
		{
			try
			{
				AccesoDatos datos = new AccesoDatos();
				datos.setearConsulta("update JUGADORES set Activo = 0 where Id = @id");
				datos.setearParametro("@id", id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public List<Jugador> filtrar(string campo, string criterio, string filtro)
        {
            List<Jugador> jugador = new List<Jugador>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				string consulta = "select j.Nombre, j.Edad, p.Descripcion, j.Peso, j.UrlImagen, j.Altura, J.Id  from JUGADORES J, POSICION P where j.IdPosicion = p.Id and ";
				if (campo == "Nombre")
				{
					switch (criterio)
					{
						case "Comienza con":
							consulta += "j.Nombre like '" + filtro + "%'";
							break;
						case "Termina con":
							consulta += "j.Nombre like '%" + filtro + "'";
							break;
						default:
							consulta += "j.Nombre like '%" + filtro + "%'";
							break;
					}
				}
				else
				{
					switch (criterio)
					{
						case "Mayor a":
							consulta += "j.Edad > " + filtro;
							break;
						case "Menor a":
							consulta += "j.Edad < " + filtro;
                            break;
						default:
							consulta += "j.Edad = " + filtro;
							break;
					}
				}
				datos.setearConsulta(consulta);
				datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Jugador temporal = new Jugador();
                    temporal.Id = (int)datos.Lector["Id"];
                    temporal.Nombre = (string)datos.Lector["Nombre"];
                    temporal.Edad = (int)datos.Lector["Edad"];
                    temporal.Posicion = new Posicion();
                    temporal.Posicion.Descripcion = (string)datos.Lector["Descripcion"];
                    temporal.Peso = (double)datos.Lector["Peso"];
                    temporal.UrlImagen = (string)datos.Lector["UrlImagen"];
                    temporal.Altura = (double)datos.Lector["Altura"];

                    jugador.Add(temporal);
				}
                return jugador;
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
