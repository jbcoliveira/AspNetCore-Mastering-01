using Joao.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joao.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }

        //DIP - Problemas quando não é possivel alterar o construtor
        //public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        //{

        //    var pedido = _pedidoRepository.ObterPedido();
        //    return View();
        //}

    }
}
