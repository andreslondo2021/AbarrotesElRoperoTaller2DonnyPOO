using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{

    internal class Cliente
    {//ACA VA TODA LA INFORMACION DEL CLIENTE 
        public int IdCliente{ get; set;}
        public string Documento{ get; set; }
        public string NombreCliente{get; set;}
        public string Direccion{get; set;}
        public int Telefono{get; set;} //TELEFONO DEL CLIENTE IRA COMO INTEGER
        public bool EstadoCliente { get; set; }

    }
}
