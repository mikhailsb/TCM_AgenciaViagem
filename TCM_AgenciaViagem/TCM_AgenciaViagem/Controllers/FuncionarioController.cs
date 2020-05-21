using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TCM_AgenciaViagem.Models;

namespace TCM_AgenciaViagem.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario funcionario = new Funcionario();

            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            return View("Resultado", funcionario);
        }

        public ActionResult Resultado(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}