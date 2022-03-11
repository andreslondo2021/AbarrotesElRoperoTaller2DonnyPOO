using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesElRopero
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

      
         
        public  Producto(int IdProducto,string NombreProducto,double PrecioProducto,int CantidadProducto)//CONSTRUCTOR CON PARAMETROS
        {
            this.IdProducto = IdProducto;
            this.NombreProducto = NombreProducto;
            this.PrecioProducto = PrecioProducto;
            this.CantidadProducto = CantidadProducto;
            //PARA QUE SIRVE EL CONSTRUCTOR SI LA FUNCIONALIDAD DE ESTE ES DEJAR VALORES POR DEFECTO A TOODOS LOS OBJETOS
        }
        public Producto()//CONSTRUCTOR POR DEFECTO SIN PARAMETROS
        {

        }
      
       

    }

}
