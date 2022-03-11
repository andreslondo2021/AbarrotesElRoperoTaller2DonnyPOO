using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero.Productos
{
    internal class ServiciosProductos
    {
        List<Producto> ListaProductos = new();//Se instancia la lista tipo producto

        //Producto productoConstructor = new(01,"papa",2000,3);//LLAMANDO E INGRESANDO EL CONSTRUCTOR
     

        public int AumentadorId=0;
        public void CrearProducto()
        {
            Producto producto = new();
            AumentadorId++;
            producto.IdProducto = AumentadorId;
             
            Console.WriteLine("ingrese el nombre del producto ");
            producto.NombreProducto = Console.ReadLine();
            Console.WriteLine("ingrese el precio del producto");
            producto.PrecioProducto = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad del producto");
            producto.CantidadProducto = int.Parse(Console.ReadLine());
            ListaProductos.Add(producto);
            Console.WriteLine("los productos agregados fueron : "+ListaProductos.Count);
        }

    }
}
