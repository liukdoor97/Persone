using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Persone.Models.Services.Infrastructure;
using Persone.Models.ViewModels;
using Persone.Models.Entities;
using Persone.Models.InputModels.AutoInput;

namespace Persone.Models.Services.Application.AutoApp
{
    public class EfCoreAutoService : IAutoService
    {
        //tramite questo oggetto eseguiremo le operazioni CRUD per le auto
        private readonly PersonaDbContext dbContext;

        public EfCoreAutoService(PersonaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Deve recuperare tutte le auto presenti nella tabella auto del db
        //SELECT * FROM auto
        public List<AutoViewModel> GetListAuto()
        {
            List<AutoViewModel> auto = dbContext.Auto.Select(a =>
            new AutoViewModel
            {
                id = a.id,
                marca = a.marca,
                modello = a.modello,
                targa = a.targa
            }).ToList();//dopo che ha recuperarto tutte le righe della tabella, inserirsci tutto nella lista auto

            return auto;
        }

        public AutoViewModel GetAuto(int id)
        {
            AutoViewModel viewModel = dbContext.Auto
            .Where(auto => auto.id == id)
            .Select(auto => new AutoViewModel
            {
                id = auto.id,
                marca = auto.marca,
                modello = auto.modello,
                targa = auto.targa
            }).Single();

            return viewModel;
        }

        public AutoViewModel CreateAuto(AutoCreateInputModel input)
        {
            string marca = input.marca;
            string modello = input.modello;
            string targa = input.targa;
            int personaId = input.personaId;
            var auto = new Auto(marca, modello, targa, personaId);
            dbContext.Add(auto); // tramite il metodo add eseguo una INSERT INTO nella tabella Courses aggiungendo il nuovo corso
            dbContext.SaveChanges();
            return AutoViewModel.FromEntity(auto);
        }

        public AutoEditInputModel GetAutoForEditing(int id)
        {
            AutoEditInputModel viewModel = dbContext.Auto
            .Where(auto => auto.id == id)
            .Select(auto => AutoEditInputModel.FromEntity(auto)).FirstOrDefault();

            return viewModel;

        }

        public AutoViewModel EditAuto(AutoEditInputModel input)
        {
            var auto = dbContext.Auto.Find(input.id);
            auto.ChangeMarca(input.marca);
            auto.ChangeModello(input.modello);
            auto.ChangeTarga(input.targa);
            dbContext.Update(auto);
            dbContext.SaveChanges();

            return AutoViewModel.FromEntity(auto);
        }
    }
}