using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persone.Models.Services.Application;
using Persone.Models.ViewModels;

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
            ViewData["Title"] = viewModel.nome;
            return View(viewModel);
        }

    }
}