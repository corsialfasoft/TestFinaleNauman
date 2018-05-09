using EsercizioMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EsercizioMvc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        IDomainModel dm =new DomainModel();
        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddMenu() {
            return View();
        }
        [HttpPost]
        public ActionResult AddMenu(string nome, DateTime data, string orario, string primo, string secondo, string contorno, string dolce) {
            try {
                List<Piatto> piatti = new List<Piatto>() { new Piatto(primo, (Portata)0), new Piatto(secondo, (Portata)1), new Piatto(contorno, (Portata)2), new Piatto(dolce, (Portata)3) };
                dm.Add(new Menu(nome,data,orario,piatti));
            } catch (Exception) {
                ViewBag.Message= "Errore nel inserimento";
                return View();
            }
            ViewBag.Message = "Insermento avenuto con successo";
            return View();
        }
        public ActionResult ListaMenu() {
            ViewBag.ListMenu= dm.GetListMenu();
            return View();
        }
        public ActionResult DettaglioMenu(string nome) {
            ViewBag.Menu = dm.GetMenu(nome);
            return View();
        }
    }
}