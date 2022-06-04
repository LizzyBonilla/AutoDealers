using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealers.BL
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }
}
