using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class EntidadesProductos
    {
        public EntidadesProductos(int productID, string productName, string quantityPerUnit, decimal unitPrice, short unitsInStock, short unitsOnOrder, short reorderLevel, bool discontinued)
        {
            ProductID = productID;
            ProductName = productName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int SupplierID { get; set; } //No poner en constructor
        public int CategoryID { get; set; } //No poner en constructor

        //public EntidadesProductos(int productID, string productName, string quantityPerUnit, decimal unitPrice, short unitsInStock, short unitsOnOrder, short reorderLevel, bool discontinued)
        //{
        //    ProductID = productID;
        //    ProductName = productName;
        //    QuantityPerUnit = quantityPerUnit;
        //    UnitPrice = unitPrice;
        //    UnitsInStock = unitsInStock;
        //    UnitsOnOrder = unitsOnOrder;
        //    ReorderLevel = reorderLevel;
        //    Discontinued = discontinued;
        //}

        public EntidadesProductos()
        {

        }
    }
}
