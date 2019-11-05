using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAEP.Revisao.MVC.Dominios;

namespace SAEP.Revisao.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ContextoLanHouse _context;

        public LoginController(ContextoLanHouse context)
        {
            _context = context;
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                return RedirectToAction("Index", "Registro");
            }
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
               Usuario retorno = _context.Usuario.FirstOrDefault(x => x.Email == usuario.Email && x.Senha == usuario.Senha);

                if (retorno == null)
                {
                    ViewBag.Mensagem = "Email ou senha inválidos";
                    return View(usuario);
                }
                HttpContext.Session.SetInt32("id", retorno.Id);
                HttpContext.Session.SetString("Email",retorno.Email);
                    ViewBag.Mensagem = "Usuário válido";
                return RedirectToAction("Index", "Registro");
      
            }
            return View("");
        }
    }
}
