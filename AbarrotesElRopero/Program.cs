using AbarrotesElRopero.Productos;
using System;
using System.Collections.Generic;

namespace AbarrotesElRopero
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Menu menu = new();//SE INSTANCIA EL MENU PARA SACAR CUALQUIER MENU DEL OBJETO
            ServiciosCliente serviciocliente = new();//SE INSTANCIA LOS SERVICIOS DEL CLIENTE
            ServiciosProductos servicioProducto = new();

             var nombreEmpresa = " --------------- ABARROTES EL ROPERO ------------------\n";
            int ingresoMod = 0; //aca escoge el menu
            int ingresoMenu = 0;//escoge en el menu de cliente
            do//ACA INGRESA A LA ELECCION DEL MODULO 
            {
                Console.WriteLine(nombreEmpresa+"\n");
                menu.MenuModulos();
                ingresoMod = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (ingresoMod)
                {
                    case 1:
                        Console.WriteLine("***************** Bienvenido al modulo de Clientes ************");
                        menu.MenuCliente();//llama al menu del cliente
                        ingresoMenu= int.Parse(Console.ReadLine());//ingresa la opcion
                        Console.Clear();

                        switch (ingresoMenu)//Escoge entre las opciones del menu
                        {

                            case 1://crear cliente
                                serviciocliente.CrearCliente();


                                break;
                            case 2://Buscar cliente
                                serviciocliente.BuscarCliente();
                                break;
                            case 3: //Modificar cliente
                                serviciocliente.ModificarCliente();
                                break;
                            case 4:

                                //aca se cambia el estado en true o false
                                serviciocliente.CambiarEstadoCliente();
                                break;
                            case 5:
                                serviciocliente.ListarClientes();
                                break;
                            case 0:

                                break;
                        }//cierra switch de cliente
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(nombreEmpresa + "\n");
                        menu.MenuProducto();
                        
                        ingresoMenu = int.Parse(Console.ReadLine());
                        switch (ingresoMenu)
                        {
                           case 1:
                                servicioProducto.CrearProducto();  
                              break;
                            case 2:
                                servicioProducto.BuscarProducto();
                                break;
                        }
                        break;


                }//cierra switch de modulos
      





            } while (ingresoMod != 0);

            Console.WriteLine("¡¡¡¡¡ QUE VUELVA PRONTO !!!");


            Console.ReadKey();


        }
    }
}
