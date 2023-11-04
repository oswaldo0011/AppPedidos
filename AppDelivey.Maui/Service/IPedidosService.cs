using AppDelivey.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDelivey.Maui.Service
{
    internal interface IPedidosService
    {
        public Task<List<AppPedidosMaui>> Get();

    }
}
