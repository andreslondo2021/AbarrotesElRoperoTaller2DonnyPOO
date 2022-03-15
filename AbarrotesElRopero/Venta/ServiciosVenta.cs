using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero.Venta
{
    internal class ServiciosVenta
    {
        List<Venta> listaventa = new();
        public int contadorIdVenta=0;
        public void CrearVenta()
        {

            Venta venta = new();
            contadorIdVenta++;
            Console.Clear();
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("FECHA : "+ fecha);
            venta.IdVenta = contadorIdVenta;
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
           
            var busqueda = from Producto in 
                           where Producto.IdProducto == ValidarIdProducto

                           select new
                           {
                               Idproducto = Producto.IdProducto,
                               nombreProducto = Producto.NombreProducto,
                               cantidadProducto = Producto.CantidadProducto,
                               precioProducto = Producto.PrecioProducto
                           };
            


            foreach (var producto in busqueda)
            {
                Console.Clear();
                Console.WriteLine($"\nID ( {producto.Idproducto} ) \nNombre  ({producto.nombreProducto} )" +
                    $" \nCantidad ({producto.cantidadProducto})\nPrecio ({producto.precioProducto}) ");

            }
             */


        }
        public void BuscarVenta()
        {

        }
        public void ListarVenta() { 
        }
    }
    }

