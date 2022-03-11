using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{
    internal class Menu
    {
        
        public void MenuModulos()
        {
            Console.WriteLine("\n1. Modulo clientes");
            Console.WriteLine("2. Modulo productos");//oscar
            Console.WriteLine("3. Modulo ventas");//anyela
            Console.WriteLine("4. Modulo reportes");//luis
            Console.WriteLine("5. Modulo configuracion");//todos
            Console.WriteLine("\n0. salir");
            Console.WriteLine("\ningrese la opcion del modulo que desea utilizar :");
        }
        

        public void MenuCliente()
        {
            
            Console.WriteLine("\n1. Crear cliente");
            Console.WriteLine("2. Buscar cliente");
            Console.WriteLine("3. Modificar cliente");
            Console.WriteLine("4. Cambiar estado del  cliente");
            Console.WriteLine("5. Listar clientes");
            Console.WriteLine("\n0. Volver al menu de modulos");
            Console.WriteLine("\nSeleccione la opcion que desea ejecutar");

        }
        public void MenuProducto()
        {
            Console.WriteLine("\n1. Crear producto");
            Console.WriteLine("2. Buscar producto");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Cambiar estado del  producto");
            Console.WriteLine("5. Listar productos");
            Console.WriteLine("\n0. Volver al menu de modulos");
            Console.WriteLine("\nSeleccione la opcion que desea ejecutar");
        }
       
      

    }
}
