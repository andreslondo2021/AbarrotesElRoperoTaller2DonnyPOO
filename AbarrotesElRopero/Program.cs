using System;

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
            Console.WriteLine("\ningrese la opcion del modulo que desea utilizar :");
            ingreso = int.Parse(Console.ReadLine());

            Console.Clear();//LIMPIA PANTALLA
            
            do//ACA INGRESA A LA ELECCION DEL MODULO 
            {
                switch (ingreso)
                {
                    case 1:
                        Console.WriteLine("***************** Bienvenido al modulo de Clientes ************");
                        menu.MenuCliente();//llama al menu del cliente


                        switch (switch_on)//Escoge entre las opciones del menu
                        {
                            case 1:
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
