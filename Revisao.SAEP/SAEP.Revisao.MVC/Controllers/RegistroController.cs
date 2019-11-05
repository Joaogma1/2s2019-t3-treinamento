using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAEP.Revisao.MVC.Dominios;

namespace SAEP.Revisao.MVC.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ContextoLanHouse _context;

        public RegistroController(ContextoLanHouse context)
        {
            _context = context;
        }

        // GET: Registro
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Create", "Login");
            }
            var contextoLanHouse = _context.RegistroDefeito.Include(r => r.IdDefeitoNavigation).Include(r => r.IdTipoEquipamentoNavigation);
            return View(await contextoLanHouse.ToListAsync());
        }

        // GET: Registro/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            ViewData["IdDefeito"] = new SelectList(_context.Defeito, "Id", "NomeDefeito");
            ViewData["IdTipoEquipamento"] = new SelectList(_context.TipoEquipamento, "Id", "Nome");
            return View();
        }

        // POST: Registro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataRegistro,IdTipoEquipamento,IdDefeito,Descricao")] RegistroDefeito registroDefeito)
        {

            if (ModelState.IsValid)
            {
                _context.Add(registroDefeito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDefeito"] = new SelectList(_context.Defeito, "Id", "NomeDefeito", registroDefeito.IdDefeito);
            ViewData["IdTipoEquipamento"] = new SelectList(_context.TipoEquipamento, "Id", "Nome", registroDefeito.IdTipoEquipamento);
            ViewBag.Mensagem = $"O Defeito {registroDefeito.Descricao} cadastrado com sucesso";
            return View(registroDefeito);
        }
    }
}
