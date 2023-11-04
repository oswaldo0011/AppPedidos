using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDelivey.Maui.Models
{
    public class modelAdmin
    {
        public List<CarritoItemModel> Items { get; set; }
        public decimal TotalCarrito { get; set; }
    }

    public class CarritoItemModel
    {
        public string Producto { get; set; }
        public object Precio { get; set; }
        public object Cantidad { get; set; }
    }
}
