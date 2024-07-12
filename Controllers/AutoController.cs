using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persone.Models.Services.Application.AutoApp;
using Persone.Models.InputModels.AutoInput;
using Persone.Models.ViewModels;
using Persone.Models.Services.Application.Persone;

namespace Persone.Controllers
{
    public class AutoController : Controller
    {

        private readonly IAutoService autoService;
        public AutoController(IAutoService autoService)
        {
            this.autoService = autoService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Lista Auto";
            List<AutoViewModel> auto = autoService.GetListAuto();
            return View(auto);
        }

        public IActionResult Detail(int id)
        {
            AutoViewModel viewModel = autoService.GetAuto(id);
            ViewData["Title"] = $"{viewModel.marca} {viewModel.modello} {viewModel.targa}";
            return View(viewModel);
        }

        public IActionResult Create(int id)
        {
            ViewData["Title"] = "Nuova Auto";
            var auto = new AutoCreateInputModel();
            auto.personaId = id;
            return View(auto);
        }

        [HttpPost]
        public IActionResult Create(AutoCreateInputModel input)
        {
            ViewData["Title"] = "Nuova Auto";
            var auto = autoService.CreateAuto(input);//metodo che deve eseguire la query INSERT INTO nel db usando i dati che ho inserito nel form
            // return RedirectToAction(nameof(Index));
            return Redirect("http://localhost:5000/Persone");
        }
        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Modifica auto";
            AutoEditInputModel inputModel = autoService.GetAutoForEditing(id);// metodo che deve recuperare l'id della persona da modificare
            return View(inputModel);
        }

        [HttpPost]
        public IActionResult Edit(AutoEditInputModel inputModel)
        {
            if (ModelState.IsValid)
            {
                AutoViewModel auto = autoService.EditAuto(inputModel);
                return RedirectToAction(nameof(Detail), new { id = inputModel.id });
            }

            ViewData["Title"] = "Modifica auto";
            return View(inputModel);
            
        }

        [HttpPost]
        public IActionResult Delete(AutoDeleteInputModel inputModel)
        {
            AutoViewModel viewModel = autoService.GetAuto(inputModel.id);
            autoService.DeleteAuto(inputModel);
            // return RedirectToAction(nameof(Index));
            return Redirect($"http://localhost:5000/Persone/Detail/{viewModel.personaId}");
        }

    }
}