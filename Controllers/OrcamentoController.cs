using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteModalMVC.Models;

namespace TesteModalMVC.Controllers
{
    public class OrcamentoController:Controller
    {
        public OrcamentoController(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public IActionResult Index() => View(Context.OrcamentoDespesa.ToList());
    }
}
