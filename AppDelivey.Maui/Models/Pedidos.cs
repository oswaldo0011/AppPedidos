using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDelivey.Maui.Models
{
    internal class Pedidos
    {
        public int Id { get; set; }
        public string Productos { get; set; }
        public string imagen { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal Precio{ get; set; }
        public decimal? Total { get; set; }
    }
}
