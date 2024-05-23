using ExeArthurQII.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExeArthurQII.Areas.Veiculo.Controllers
{
    [Area("Veiculo")]
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Moto()
        {
            motos moto = new motos();
            moto.fabricante = "Honda";
            moto.nome = "Modelo: CB 750";
            moto.cilindradas = "750 Cilindradas";
            moto.categoria = "Categoria: Classic";
            moto.Partida = "Partida: Pedal e Eletrica";


            return View(moto);

        }
        public IActionResult Carros()
        {

            carro carros = new carro();
            carros.fabricante = "Chevrolet";
            carros.nome = "Modelo: Chevette";
            carros.categoria = "Categoria: Compacto";
            carros.Marcha = "Partida: Pedal e Eletrica";
            carros.Tipo = "Tipo: sedã";
            
            return View(carros);
        
        }
        public IActionResult Veiculos()
        {
            return View();
        }
    }
}
