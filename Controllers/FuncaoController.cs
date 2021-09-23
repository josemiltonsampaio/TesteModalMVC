using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteModalMVC.Models;

namespace TesteModalMVC.Controllers
{
    public class FuncaoController : Controller
    {
        public FuncaoController(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public IActionResult ObterFuncaoTodas()
        {
            var funcoes = Context.Funcoes.ToList();
            return funcoes == null ? NotFound() : Ok(funcoes);
        }

        public IActionResult ObterFuncaoPorId(int id)
        {
            var funcao = Context.Funcoes.FirstOrDefault(f => f.Id == id);
            return funcao == null ? NotFound() : Ok(funcao);
        }

       
    }
}
