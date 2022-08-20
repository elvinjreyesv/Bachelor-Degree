using System;

namespace Proyecto_3.inv.mantenimientos
{
    public class EProducto
    {
        //Estas son propiedades Autoimplementadas y su uso requiere
        // del Framework 4.0 Client Profile como mínimo
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }
        public Decimal Cantidad { get; set; }
    }

    public interface IProducto
    {
        bool LoadDataRow(EProducto producto);
    }
}