using System;

namespace AbarrotesElRopero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new();//SE INSTANCIA EL MENU PARA SACAR CUALQUIER MENU DEL OBJETO
            var nombreEmpresa = "ABARROTES EL ROPERO";
             int ;

            Console.WriteLine($"******************* {nombreEmpresa} ******************");
            Console.WriteLine("\nMODULOS DE LA EMPRESA :");
            menu.MenuModulos();//SACA EL MENU DE TODOS LOS MODULOS EXISTENTES
            Console.WriteLine("\ningres la opcion que desea escoger :");
            
            
            do
            {

            } while (true);




            Console.ReadKey();
        }
    }
}
