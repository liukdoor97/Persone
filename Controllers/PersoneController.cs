using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persone.Models.Services.Application;
using Persone.Models.ViewModels;
using Persone.Models.InputModels.Persone;

namespace Persone.Controllers
{

    public class PersoneController : Controller
    {

        private readonly IPersoneService personeService;
        public PersoneController(IPersoneService personeService)
        {
            this.personeService = personeService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista delle persone";
            //var personeService = new PersoneService();//Il controller crea un oggetto del servizio applicativo che deve utilizzare
            List<PersoneViewModel> persone = personeService.GetPersone();//recupero la lista delle persone
            return View(persone);//passo l'oggetto contenente la lista dei corsi alla view per mostrare i dati
        }

        //azione che deve recuperare i dati della persona con id = id parametro
        //e popolare la view Detail.cshtml con i dati della persona recuperata
        public IActionResult Detail(int id)
        {
            //var personeService = new PersoneService();
            PersoneViewModel viewModel = personeService.GetPersona(id);
            ViewData["Title"] = $"{viewModel.nome} {viewModel.cognome}";
            return View(viewModel);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Nuova persona";
            var input = new PersonaCreateInputModel();
            return View(input);
        }

        [HttpPost]
        public IActionResult Create(PersonaCreateInputModel input)
        {
            ViewData["Title"] = "Nuova persona";
            PersoneDetailViewModel persona = personeService.CreatePersona(input);//metodo che deve eseguire la query INSERT INTO nel db usando i dati che ho inserito nel form
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Modifica persona";
            PersonaEditInputModel inputModel = personeService.GetPersonaForEditing(id);// metodo che deve recuperare l'id della persona da modificare
            return View(inputModel);
        }

        [HttpPost]
        public IActionResult Edit(PersonaEditInputModel inputModel)
        {
            if (ModelState.IsValid)
            {
                PersoneDetailViewModel persona = personeService.EditPersona(inputModel);
                return RedirectToAction(nameof(Detail), new { id = inputModel.id });
            }

            ViewData["Title"] = "Modifica persona";
            return View(inputModel);
        }

        [HttpPost]
        public IActionResult Delete(PersonaDeleteInputModel inputModel)
        {
            personeService.DeletePersona(inputModel);
            return RedirectToAction(nameof(Index));
        }
    }
}