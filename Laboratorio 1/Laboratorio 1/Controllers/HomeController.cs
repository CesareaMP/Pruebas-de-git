using Laboratorio_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorio_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Cliente> clientes = new List<Cliente>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            clientes.Add(new Cliente() { Nombre = "Luisa", Apellido = "Gonzales", Descripcion = "Proveedor", Telefono = "384928256" });
            clientes.Add(new Cliente() { Nombre = "Alberto", Apellido = "Perez", Descripcion = "Gerente", Telefono = "38478456" });
            clientes.Add(new Cliente() { Nombre = "Alessandro", Apellido = "Coulborn", Descripcion = "Vendedor", Telefono = "789928256" });
            clientes.Add(new Cliente() { Nombre = "Leah", Apellido = "Jenner", Descripcion = "Director", Telefono = "38492835" });
            clientes.Add(new Cliente() { Nombre = "Alland", Apellido = "Gonzales", Descripcion = "Director de Marketin", Telefono = "795618256" });
            clientes.Sort();

        }

        public List<Cliente> Index()
        {
            return clientes;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}