﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{
    internal class Menu
    {

        public void MenuCliente()
        {
            Console.WriteLine("1. Crear cliente");
            Console.WriteLine("2. Buscar cliente");
            Console.WriteLine("3. Modificar cliente");
            Console.WriteLine("1. Eliminar cliente");

        }
        public void MenuModulos()
        {
            Console.WriteLine("1. Modulo clientes");
            Console.WriteLine("2. Modulo productos");
            Console.WriteLine("3. Modulo ventas");
            Console.WriteLine("4. Modulo reportes");
            Console.WriteLine("5. Modulo configuracion");
            Console.WriteLine("0. salir");

        }


    }
}