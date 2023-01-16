using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PosicionNegocio
    {
        public List<Posicion> Listar()
        {
            List<Posicion> lista = new List<Posicion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion From POSICION");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Posicion temporal = new Posicion();
                    temporal.Id = (int)datos.Lector["Id"];
                    temporal.Descripcion = (string)datos.Lector["Descripcion"];

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
    }
}
