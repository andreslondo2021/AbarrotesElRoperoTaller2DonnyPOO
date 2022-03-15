using System;
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
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("\nIngrese el numero del documento ");
          
            cliente.Documento = Console.ReadLine();
            

            Console.WriteLine("\nIngrese la direccion");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("ingrese el telefono del cliente");
            cliente.Telefono = int.Parse(Console.ReadLine());// toma valor int Telefono
            cliente.EstadoCliente = true;//agg el estado
           
            var consulta = listaCliente.Where(persona => persona.Documento.Equals(cliente.Documento)).FirstOrDefault();

            if (consulta == null) listaCliente.Add(cliente);//aca se agrega el objeto a la lista
            else Console.WriteLine("el usuario ya existe con ese documento");

            Console.WriteLine("La cantidad de alumnos registrados son: " + listaCliente.Count);

            listaCliente.ForEach(cliente => Console.WriteLine(cliente.NombreCliente));//CONSULTA LINQ
           

        }//fin de crear cliente
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

            nombre = cliente.NombreCliente,


            direccion = cliente.Direccion,
            telefono = cliente.Telefono

        };
            //muestra los objetos que cumplan con la condicion
            foreach (var cliente in busquedaCliente)
            {

                Console.WriteLine($"\nel nombre es : {cliente.nombre}");
                Console.WriteLine($"\nla direccion es : {cliente.direccion}");
                Console.WriteLine($"\nel telefono es : {cliente.telefono}");
            }


        }  //termina la busqueda del objeto( cliente )

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
            nombre = cliente.NombreCliente,

            documento = cliente.Documento,
            direccion = cliente.Direccion,
            telefono = cliente.Telefono

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
                Console.Clear();


                Console.WriteLine("MODIFIQUE LOS CAMPOS, no se modificara ni ID ni tampoco CC");
                
                Console.WriteLine("Ingrese el nombre");
                var nombreModificado = Console.ReadLine();
                Console.WriteLine("Ingrese la direccion");
                var direccionModificado = Console.ReadLine();
                Console.WriteLine("Ingrese el  telefono");
                var telefonoModificado =int.Parse( Console.ReadLine());
                listaCliente[indiceCliente].NombreCliente = nombreModificado;//CON ESTE SE CAMBIA LA PROPIEDAD DE NOMBRE EN EL OBJETO ENCONTADO, ES DECIR DEL CLIENTE.
                listaCliente[indiceCliente].Direccion = direccionModificado;
                listaCliente[indiceCliente].Telefono = telefonoModificado;
                Console.Clear();
                Console.WriteLine("Se Modifico con exito");
            }

        }//Termina modificar objeto ( cliente)
        public void CambiarEstadoCliente()
        {
            Console.WriteLine("\nIngrese el numero del Documento de la persona que desea buscar");
            validarDocumento = Console.ReadLine();//SE CREA VARIABLE PARA BUSCAR LA COINCIDENCIA DE DOCUMENTO string

            // busqueda del objeto
            var busquedaCliente = ( //aca saldria con algo o simplemente NULL=vacio
            from cliente in listaCliente
            where cliente.Documento == validarDocumento
            select new//se puede cambiar por el nombre de una clase creada para buscar(PODEMOS CREAR UNA CLASE PARA QUE NO QUEDE ANONIMA)
           {
                nombre = cliente.NombreCliente,

                documento = cliente.Documento,
                direccion = cliente.Direccion,
                telefono = cliente.Telefono,
                estado=cliente.EstadoCliente

            }).FirstOrDefault();

            if (busquedaCliente == null) Console.WriteLine("el Documento no fue encontrado, verifique");
            int indiceCliente = listaCliente.FindIndex(empleado => empleado.Documento.Equals(validarDocumento));//ESTE SIRVE PARA SACAR EL INDICE DE DONDE ESTA EL CLIENTE QUE CUMPLA CON LAS CONDICIONES

            if (busquedaCliente != null)
            {
                Console.WriteLine("cambiar de estado : true o false ");
                bool estadoModificado = bool.Parse(Console.ReadLine());
                listaCliente[indiceCliente].EstadoCliente = estadoModificado;
                Console.WriteLine("el estado ha estado modificado exitosamente");
                Console.WriteLine(listaCliente[indiceCliente].NombreCliente);
                Console.WriteLine(listaCliente[indiceCliente].EstadoCliente);


            }//Termina cambiar estado cliente
            else Console.WriteLine("el estado no se ha podido modificar");
        }
        public void ListarClientes()
        {
            foreach (var cliente in listaCliente)
            {
                if (cliente.EstadoCliente==true)
                {
                    Console.WriteLine($"Nombre < {cliente.NombreCliente} > " +
                 $" Documento < {cliente.Documento} >" +
                 $" Direccion < {cliente.Direccion} > " +
                 $"  Estado < {cliente.EstadoCliente} > ");
                }
             
            }
        }

    }
}

