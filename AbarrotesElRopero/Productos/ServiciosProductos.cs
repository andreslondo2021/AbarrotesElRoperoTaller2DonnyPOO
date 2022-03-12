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
        BusquedaProductoDto busquedaProducto = new();
     

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
            foreach (var item in ListaProductos)
            {
                Console.WriteLine(item.IdProducto);
                Console.WriteLine(  item.NombreProducto);
            }
        }//termina crear


        public void BuscarProducto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el ID Del producto");
            int ValidarIdProducto = int.Parse(Console.ReadLine());
            /*
             CONSULTA JOIN
            var busqueda = (from Producto in ListaProductos
                            join producto in ListaProductos
                            on Producto.IdProducto equals producto.IdProducto
                            select new BusquedaProductoDto { IdProductoBusqueda = producto.IdProducto,
                                NombreProductoBusqueda=producto.NombreProducto,
                                PrecioProductoBusqueda=producto.PrecioProducto,
                                CantidadProductoBusqueda=producto.CantidadProducto}).ToList();
            */
            var busqueda=from Producto in ListaProductos
                   where Producto.IdProducto == ValidarIdProducto

                   select new
                   {

                       Idproducto =Producto.IdProducto ,
                       nombreProducto = Producto.NombreProducto,
                        cantidadProducto= Producto.CantidadProducto,
                        precioProducto=Producto.PrecioProducto

                   };


            foreach (var producto in busqueda)
            {
                Console.Clear();
                Console.WriteLine($"\nID ( {producto.Idproducto} ) \nNombre  ({producto.nombreProducto} )" +
                    $" \nCantidad ({producto.cantidadProducto})\nPrecio ({producto.precioProducto}) ");
                
            }
        }//se termina el buscar


    }
}
