﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{
    internal class ServiciosCliente
    {//ACA VA TODAS LAS ACCIONES QUE TIENE EL CLIENTE COMO :CREAR , BUSCAR, ETC..
        Cliente cliente = new();
        List<Cliente> listaCliente = new();//instancia lista tipo objeto

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
             
            Console.WriteLine("La cantidad de alumnos registrados son: " + listaCliente.Count);

            listaCliente.ForEach(cliente => Console.WriteLine(cliente.Nombre));//CONSULTA LINQ
            
        }
        public void BuscarCliente()
        {
            Console.WriteLine("\nIngrese el numero del Documento de la persona que desea buscar");
           string  validarDocumento =Console.ReadLine();//SE CREA VARIABLE PARA BUSCAR LA COINCIDENCIA DE DOCUMENTO string

            // busqueda del objeto
            var busquedaCliente =
        from cliente in listaCliente
        where cliente.Documento==validarDocumento
        select new
        {
            nombre = cliente.Nombre,

            documento = cliente.Documento,
            direccion=cliente.Direccion,
            telefono=cliente.telefono

        };
            //muestra los objetos que cumplan con la condicion
            foreach (var cliente in busquedaCliente)
            {
                Console.WriteLine($"\nel nombre es : {cliente.nombre}");
                Console.WriteLine($"\nel numero del documento es : {cliente.documento}");
                Console.WriteLine($"\nla direccion es : {cliente.direccion}");
                Console.WriteLine($"\nel telefono es : {cliente.telefono}");
            }
            //termina la busqueda del objeto
           
        }




    }
}
