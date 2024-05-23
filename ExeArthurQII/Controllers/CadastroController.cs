using ExeArthurQII.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Schema;

namespace ExeArthurQII.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            Cadastro cadastro = new Cadastro
            {
                  CodigoFuncionario = 0,
                  NomeFuncionario = " ",
                  funcaofuncionario = " "
            };
            return View();
        }
        public IActionResult ConsultarPessoa() {
            Cadastro exibir = new Cadastro();
            return View();
            
        }

    }
}
