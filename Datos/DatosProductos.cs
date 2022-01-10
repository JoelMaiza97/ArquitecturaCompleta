using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class DatosProductos
    {

        public static List<EntidadesProductos> DevolverListaProductos()
        {
            List<EntidadesProductos> listaProductosEntidad = new List<EntidadesProductos>();
            List<Products> listaProductsLINQ = new List<Products>();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var resultado = from p in contexto.Products
                                select p;
                listaProductsLINQ = resultado.ToList();
            }
            foreach (var item in listaProductsLINQ)
            {
                listaProductosEntidad.Add(new EntidadesProductos(
                    item.ProductID,
                    item.ProductName,
                    item.QuantityPerUnit,
                    (decimal)item.UnitPrice,
                    (short)item.UnitsInStock,
                    (short)item.UnitsOnOrder,
                    (short)item.ReorderLevel,
                    item.Discontinued
                ));
            }
            return listaProductosEntidad;
        }

        public static EntidadesProductos Nuevo(EntidadesProductos entidadesProductos)
        {
            try
            {
                Products productsLinQ = new Products();
                productsLinQ.ProductName = entidadesProductos.ProductName;
                productsLinQ.SupplierID = entidadesProductos.SupplierID;
                productsLinQ.CategoryID = entidadesProductos.CategoryID;
                productsLinQ.QuantityPerUnit = entidadesProductos.QuantityPerUnit;
                productsLinQ.UnitPrice = entidadesProductos.UnitPrice;
                productsLinQ.UnitsInStock = entidadesProductos.UnitsInStock;
                productsLinQ.UnitsOnOrder = entidadesProductos.UnitsOnOrder;
                productsLinQ.ReorderLevel = entidadesProductos.ReorderLevel;
                productsLinQ.Discontinued = entidadesProductos.Discontinued;

                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    contexto.Products.InsertOnSubmit(productsLinQ);
                    contexto.SubmitChanges();
                }
                entidadesProductos.ProductID = productsLinQ.ProductID;
                return entidadesProductos;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
