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


            




            var nombreEmpresa = "ABARROTES EL ROPERO";
            int ingreso = 0; //aca escoge el menu

            Console.WriteLine($"******************* {nombreEmpresa} ******************");
            Console.WriteLine("\nMODULOS DE LA EMPRESA :");
            menu.MenuModulos();//SACA EL MENU DE TODOS LOS MODULOS EXISTENTES
            ingreso = int.Parse(Console.ReadLine());//ingresa la opcion

            Console.Clear();//LIMPIA PANTALLA
            
            do//ACA INGRESA A LA ELECCION DEL MODULO 
            {
                switch (ingreso)
                {
                    case 1:
                        Console.WriteLine("***************** Bienvenido al modulo de Clientes ************");
                        menu.MenuCliente();//llama al menu del cliente
                        ingreso = int.Parse(Console.ReadLine());//ingresa la opcion
                        Console.Clear();
                        switch (ingreso)//Escoge entre las opciones del menu
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
                        }
                       

                        break;
                }




            } while (ingreso!=0);

            Console.WriteLine("¡¡¡¡¡ QUE VUELVA PRONTO !!!");


            Console.ReadKey();
        }
    }
}
