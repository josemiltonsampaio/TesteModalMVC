using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteModalMVC.Models;

namespace TesteModalMVC.Controllers
{
    public class PesquisaController:Controller
    {
        public PesquisaController(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public IActionResult Index(string campo, string callback)
        {
            TempData["campo"] = campo;
            TempData["callback"] = callback;
            return View(Context.Funcoes.ToList());
        }
    }
}
