using ExeArthurQII.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExeArthurQII.Areas.Veiculo.Controllers
{
    [Area("Veiculo")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            carro carros = new carro();
            carros.fabricante = "Chevrolet";
            carros.nome = "Modelo: Chevette";
            carros.categoria = "Categoria: Compacto";

            return View(carros);
        }
    }
}
