using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week5.Ristorante.Core.Interfaces;
using Week5.Ristorante.Core.Models;
using Week5.Ristorante.MVC.Models;

namespace Week5.Ristorante.MVC.Controllers
{
    public class PiattoController : Controller
    {
        private readonly IBusinessLayer bl;
        public PiattoController(IBusinessLayer businessLayer)
        {
            this.bl = businessLayer;
        }

       // [Route("Pt/Index", Order = 1)]
        [Route("Piatto/Piatto", Order = 2)]
        public IActionResult Index()
        {
            var model = bl.FetchPiatti();
            return View(model);
        }

        [HttpGet("piatto/details/{id}")]
        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            var piat = bl.GetPiattoById(id);

            if (piat == null)
            {
                return View("NotFound", new NotFoundViewModel()
                {
                    EntityId = id,
                    Message = "Something wrong"
                });
            }
            return View(piat);
        }
        [Authorize(Policy = "AccountAdministrator")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Policy = "AccountAdministrator")]
        [HttpPost]
        public IActionResult Create(PiattoViewModel data)
        {
            //validazione
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                //chiamata al business layer
                PiattoResult result = bl.AddNewPiatto(new Piatto
                {
                    Nome = data.Nome,
                    Descrizione = data.Descrizione,
                    Tipo = (Core.Models.Tipo)data.Tipo,
                    Prezzo = data.Prezzo
                });
                //restituzione della view
                if (result.Success)
                {
                    return RedirectToAction("Piatto");
                }
            }

            return View();
        }
        [Authorize(Policy = "AccountAdministrator")]
        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            //recupero l'impiegato da modificare
            var model = bl.GetPiattoById(id);
            if (model == null)
            {
                return View("NotFound", new NotFoundViewModel { EntityId = id, Message = "Sorry, not found" });
            }
            var empViewModel = new PiattoViewModel
            {
                Id = model.Id,
                Nome = model.Nome,
                Descrizione = model.Descrizione,
              Tipo = (Models.Tipo)model.Tipo,
           
                Prezzo = model.Prezzo
            };
            return View(empViewModel);
        }
        [HttpPost]
        public IActionResult Edit(PiattoViewModel data)
        {
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                var result = bl.EditPiatto(new Piatto
                {
                    Id = data.Id,
                    Nome = data.Nome,
                    Descrizione = data.Descrizione,
                    Tipo = (Core.Models.Tipo)data.Tipo,
                    Prezzo = data.Prezzo
                }
                );
                if (result.Success)
                {
                    return RedirectToAction("Piatto");
                }
            }

            return View();
        }
        [Authorize(Policy = "AccountAdministrator")]
        public IActionResult Delete(int id)
        {
            var model = bl.GetPiattoById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Piatto data)
        {
            var piattoToDelete = bl.GetPiattoById(data.Id);

            var result = bl.DeletePiatto(piattoToDelete);
            if (result.Success)
            {
                return RedirectToAction("Piatto");
            }

            return View();
        }
    }
}
