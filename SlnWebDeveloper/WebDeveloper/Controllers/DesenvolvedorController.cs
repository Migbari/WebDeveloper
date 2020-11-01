using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using WebDeveloper.Application.Interface;
using WebDeveloper.Domain.Entities;
using WebDeveloper.ViewModels;

namespace WebDeveloper.Controllers
{
    public class DesenvolvedorController : Controller
    {
        private readonly IDesenvolvedorAppService _desenvolvedorAppService;

        public DesenvolvedorController(IDesenvolvedorAppService desenvolvedorAppService)
        {
            _desenvolvedorAppService = desenvolvedorAppService;
        }
        // GET: Desenvolvedor
        public ActionResult Index()
        {
            var desenvolvedorViewModel = Mapper.Map<IEnumerable<Desenvolvedor>, IEnumerable<DesenvolvedorViewModel>>(_desenvolvedorAppService.ConsultarTodos());
            return View(desenvolvedorViewModel);
        }

        // GET: Desenvolvedor/Details/5
        public ActionResult Details(int id)
        {
            var desenvolvedor = _desenvolvedorAppService.Consultar(id);
            var desenvolvedorViewModel = Mapper.Map<Desenvolvedor, DesenvolvedorViewModel>(desenvolvedor);

            return View(desenvolvedorViewModel);
        }

        // GET: Desenvolvedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Desenvolvedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DesenvolvedorViewModel desenvolvedorViewModel)
        {
            if (ModelState.IsValid)
            {
                var desenvolvedorDomain = Mapper.Map<DesenvolvedorViewModel, Desenvolvedor>(desenvolvedorViewModel);
                _desenvolvedorAppService.Incluir(desenvolvedorDomain);

                return RedirectToAction("Index");
            }
            return View(desenvolvedorViewModel);
        }

        // GET: Desenvolvedor/Edit/5
        public ActionResult Edit(int id)
        {
            var desenvolvedor = _desenvolvedorAppService.Consultar(id);
            var desenvolvedorViewModel = Mapper.Map<Desenvolvedor, DesenvolvedorViewModel>(desenvolvedor);

            return View(desenvolvedorViewModel);
        }

        // POST: Desenvolvedor/Edit/5
        [HttpPost]
        public ActionResult Edit(DesenvolvedorViewModel desenvolvedorViewModel)
        {
            if (ModelState.IsValid)
            {
                var desenvolvedorDomain = Mapper.Map<DesenvolvedorViewModel, Desenvolvedor>(desenvolvedorViewModel);
                _desenvolvedorAppService.Alterar(desenvolvedorDomain);

                return RedirectToAction("Index");
            }
            return View(desenvolvedorViewModel);
        }

        // GET: Desenvolvedor/Delete/5
        public ActionResult Delete(int id)
        {
            var desenvolvedor = _desenvolvedorAppService.Consultar(id);
            _desenvolvedorAppService.Excluir(desenvolvedor);

            return RedirectToAction("Index");
        }

        // POST: Desenvolvedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var desenvolvedor = _desenvolvedorAppService.Consultar(id);
            _desenvolvedorAppService.Excluir(desenvolvedor);

            return RedirectToAction("Index");
        }
    }
}
