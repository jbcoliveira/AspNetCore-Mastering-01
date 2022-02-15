using Joao.UI.Site.Data;
using Joao.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joao.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {

        private readonly MyDBContext _contexto;

        public TesteCrudController(MyDBContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {

            Pedido pedido = new Pedido {
                DataPedido = DateTime.Now,
                Descricao = "Descricao qualquer"
            };

            _contexto.Pedidos.Add(pedido);
            _contexto.SaveChanges();

            Pedido pedido2 = _contexto.Pedidos.Find(pedido.Id);

            return View();
        }
    }
}
