﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{
    internal class ServiciosCliente
    {//ACA VA TODAS LAS ACCIONES QUE TIENE EL CLIENTE COMO :CREAR , BUSCAR, ETC..

        List<Cliente> listaCliente = new();//instancia lista tipo objeto
        string validarDocumento;
        public void CrearCliente()
        {
            Console.Clear();
            Cliente cliente = new();
            Console.WriteLine("Ingrese el ID del cliente");
            cliente.IdCliente = int.Parse(Console.ReadLine());//toma valor int ID
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
            Console.Clear();
            Console.WriteLine("\nIngrese el numero del Documento de la persona que desea buscar");
            validarDocumento = Console.ReadLine();//SE CREA VARIABLE PARA BUSCAR LA COINCIDENCIA DE DOCUMENTO string

            // busqueda del objeto
            var busquedaCliente =
        from cliente in listaCliente
        where cliente.Documento == validarDocumento

        select new
        {

            nombre = cliente.Nombre,


            direccion = cliente.Direccion,
            telefono = cliente.telefono

        };
            //muestra los objetos que cumplan con la condicion
            foreach (var cliente in busquedaCliente)
            {

                Console.WriteLine($"\nel nombre es : {cliente.nombre}");
                Console.WriteLine($"\nla direccion es : {cliente.direccion}");
                Console.WriteLine($"\nel telefono es : {cliente.telefono}");
            }


        }  //termina la busqueda del objeto

        public void ModificarCliente()
        {
            Console.Clear();
            Console.WriteLine("\nIngrese el numero del Documento de la persona que desea buscar");
            validarDocumento = Console.ReadLine();//SE CREA VARIABLE PARA BUSCAR LA COINCIDENCIA DE DOCUMENTO string

            // busqueda del objeto
        var busquedaCliente = ( //aca saldria con algo o simplemente NULL=vacio
        from cliente in listaCliente
        where cliente.Documento == validarDocumento
        select new//se puede cambiar por el nombre de una clase creada para buscar(PODEMOS CREAR UNA CLASE PARA QUE NO QUEDE ANONIMA)
        {
            nombre = cliente.Nombre,

            documento = cliente.Documento,
            direccion = cliente.Direccion,
            telefono = cliente.telefono

        }).FirstOrDefault();

            if (busquedaCliente == null) Console.WriteLine("el Documento no fue encontrado, verifique");
            int indiceCliente = listaCliente.FindIndex(empleado => empleado.Documento.Equals(validarDocumento));//ESTE SIRVE PARA SACAR EL INDICE DE DONDE ESTA EL CLIENTE QUE CUMPLA CON LAS CONDICIONES
            
            if (busquedaCliente != null)
            {
                //muestra lo que tiene el usuario encontrado
                Console.WriteLine("el nombre es :"+busquedaCliente.nombre);
                Console.WriteLine("el documento es :"+busquedaCliente.documento);
                Console.WriteLine("la direccion es"+busquedaCliente.direccion);
                Console.WriteLine("el telefono es "+ busquedaCliente.telefono);    


                listaCliente[indiceCliente].Nombre=
            }



        }


    }
}

