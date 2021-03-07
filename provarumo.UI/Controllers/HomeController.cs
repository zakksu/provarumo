using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using provarumo.Models.Entities;
using provarumo.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace provarumo.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var pedidos = new PedidoModel().Listar();
            return View(pedidos);
        }

        public IActionResult Copa()
        {
            var pedidos = new PedidoModel().Listar();
            return View(pedidos);
        }

        public IActionResult Cozinha()
        {
            var pedidos = new PedidoModel().Listar();
            return View(pedidos);
        }

        public IActionResult CadastrarPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarPedido(PedidoEntity pedido)
        {
            var pedidoModel = new PedidoModel();
            pedidoModel.Inserir(pedido);
            var pedidos = new PedidoModel().Listar();
            return View("Index", pedidos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
