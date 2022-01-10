using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public static class NegocioProductos
    {

        public static List<EntidadesProductos> DevolverListaProductos()
        {
            return DatosProductos.DevolverListaProductos();
        }

        public static List<EntidadesProductos> DevolverListaProductosStockMenor10()
        {
            var resultado = DatosProductos.DevolverListaProductos().Where(x => x.UnitPrice < 10).ToList();
            return resultado;
        }

        public static EntidadesProductos Nuevo(EntidadesProductos entidadesProductos)
        {
            return DatosProductos.Nuevo(entidadesProductos);
        }

    }
}
