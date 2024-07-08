using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Persone.Models.ViewModels;
using Persone.Models.InputModels.Persone;
using Persone.Models.Services.Infrastructure;
using Persone.Models.Entities;

namespace Persone.Models.Services.Application.Persone
{
    public class EfCorePersoneService : IPersoneService
    {
        //tramite questo oggetto eseguiremo le operazioni CRUD per le persone
        private readonly PersonaDbContext dbContext;

        public EfCorePersoneService(PersonaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Deve recuperare tutte le persone presenti nella tabella persona del db
        //SELECT * FROM persona
        public List<PersoneViewModel> GetPersone()
        {
            List<PersoneViewModel> persone = dbContext.Persona.Select(persona =>
            new PersoneViewModel
            {
                Id = persona.id,
                nome = persona.nome,
                cognome = persona.cognome,
                eta = persona.eta
            }).ToList();//dopo che ha recuperarto tutte le righe della tabella, inserirsci tutto nella lista persone

            return persone;
        }

        public PersoneDetailViewModel GetPersona(int id)
        {
            PersoneDetailViewModel viewModel = dbContext.Persona
            .Where(persona => persona.id == id)
            .Select(persona => new PersoneDetailViewModel
            {
                Id = persona.id,
                nome = persona.nome,
                cognome = persona.cognome,
                eta = persona.eta,
                Auto = persona.Auto.Select(auto => new AutoViewModel
                {
                    id = auto.id,
                    marca = auto.marca,
                    modello = auto.modello,
                    targa = auto.targa
                }).ToList()
            }).Single();

            return viewModel;
        }
        public PersoneDetailViewModel CreatePersona(PersonaCreateInputModel input)
        {
            string nome = input.nome;
            string cognome = input.cognome;
            int eta = input.eta;
            var persona = new Persona(nome, cognome, eta);
            dbContext.Add(persona); // tramite il metodo add eseguo una INSERT INTO nella tabella Courses aggiungendo il nuovo corso
            dbContext.SaveChanges();
            return PersoneDetailViewModel.FromEntity(persona);
        }
        public PersonaEditInputModel GetPersonaForEditing(int id)
        {
            PersonaEditInputModel viewModel = dbContext.Persona
            .Where(persona => persona.id == id)
            .Select(persona => PersonaEditInputModel.FromEntity(persona)).FirstOrDefault();
            return viewModel;
        }
        public PersoneDetailViewModel EditPersona(PersonaEditInputModel inputModel)
        {
            var persona = dbContext.Persona.Find(inputModel.id);
            persona.ChangeNome(inputModel.nome);
            persona.ChangeCognome(inputModel.cognome);
            persona.ChangeEta(inputModel.eta);
            // dbContext.Entry(persona).Property(persona => persona.RowVersion).OriginalValue = inputModel.RowVersion;
            dbContext.Update(persona);
            dbContext.SaveChanges();

            return PersoneDetailViewModel.FromEntity(persona);
        }
        public void DeletePersona(PersonaDeleteInputModel inputModel)
        {
            var persona = dbContext.Persona.Find(inputModel.id);
            dbContext.Remove(persona);
            dbContext.SaveChanges();
        }
    }
}