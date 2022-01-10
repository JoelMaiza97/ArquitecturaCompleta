using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Entidades;
using Negocio;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de wsProductos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsProductos : System.Web.Services.WebService
    {

        [WebMethod]
        public List<EntidadesProductos> DevolverListaProductos()
        {
            return NegocioProductos.DevolverListaProductos();
        }

        [WebMethod]
        public EntidadesProductos InsertarProducto(EntidadesProductos entidadesProductos)
        {
            return NegocioProductos.Nuevo(entidadesProductos);
        }

        [WebMethod]

        public List<EntidadesProductos> DevolverListaProductosStockMenor10()
        {
            return NegocioProductos.DevolverListaProductosStockMenor10();
        }
    }
}
