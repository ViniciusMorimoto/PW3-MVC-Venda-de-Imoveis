using Aula004.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;

namespace Aula4.Controllers
{
    public class ImoveisController : Controller
    {
        // GET: ImoveisController
        public ActionResult Index()
        {
            var lista = LerLista();

            return View(lista);
        }

        private List<Imoveis> LerLista()
        {
            List<Imoveis> lista;
            string imoveis = HttpContext.Session.GetString("imoveis");

            if (String.IsNullOrEmpty(imoveis))
                lista = IniciarLista();
            else
            {
                lista = JsonConvert.DeserializeObject<List<Imoveis>>(imoveis);
                if (lista.Count == 0)
                    lista = IniciarLista();
            }

            return lista;
        }

        private List<Imoveis> IniciarLista()
        {
            List<Imoveis> lista = Imoveis.Lista;
            AtualizarLista(lista);
            return lista;
        }

        private void AtualizarLista(List<Imoveis> lista)
        {
            string imoveis = JsonConvert.SerializeObject(lista);
            HttpContext.Session.SetString("imoveis", imoveis);
        }

        // GET: ImoveisController/Details/5
        public ActionResult Details(int id)
        {
            var lista = LerLista();
            return View(lista[id]);
        }

        // GET: ImoveisController/Create
        public ActionResult Create()
        {
            return View(new Imoveis());
        }

        // POST: ImoveisController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Imoveis imoveis)
        {
            try
            {
                var lista = LerLista();
                lista.Add(imoveis);
                AtualizarLista(lista);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImoveisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(LerLista()[id]);
        }

        // POST: ImoveisController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Imoveis imoveis)
        {
            try
            {
                var lista = LerLista();
                lista[id] = imoveis;
                AtualizarLista(lista);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImoveisController/Delete/5
        public ActionResult Delete(int id)
        {
            var lista = LerLista();
            return View(lista[id]);
        }

        // POST: ImoveisController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Imoveis imoveis)
        {
            try
            {
                var lista = LerLista();
                lista.RemoveAt(id);
                AtualizarLista(lista);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}