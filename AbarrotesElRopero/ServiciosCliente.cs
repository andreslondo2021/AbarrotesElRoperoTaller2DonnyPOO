using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{
    internal class ServiciosCliente
    {//ACA VA TODAS LAS ACCIONES QUE TIENE EL CLIENTE COMO :CREAR , BUSCAR, ETC..
        Cliente cliente = new();
        List<Cliente> listaCliente = new();
        public void CrearCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente");
            cliente.IdCliente =int.Parse( Console.ReadLine());//toma valor int ID
            Console.WriteLine("\nIngrese el nombre ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese el numero del documento ");
            cliente.Documento = Console.ReadLine();
            Console.WriteLine("\nIngrese la direccion");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("ingrese el telefono del cliente");
            cliente.telefono = int.Parse(Console.ReadLine());// toma valor int Telefono

            listaCliente.Add(cliente);//aca se agrega el objeto a la lista
            
        }
        public void BuscarCliente()
        {
            Console.WriteLine("\nIngrese el numero del Documento de la persona que desea buscar");
            
        
        
        }



    }
}
