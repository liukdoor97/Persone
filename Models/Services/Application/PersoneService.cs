using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;

namespace Persone.Models.Services.Application
{
    public class PersoneService
    {
        public List<PersoneViewModel> GetPersone()
        {
            var listaPersone = new List<PersoneViewModel>();//oggetto che conterrà la lista delle persone
            var rand = new Random();
            for (int i = 1; i <= 10; i++)//creo 10 persone random
            {
                var persona = new PersoneViewModel//creo un oggetto di tipo CourseViewModel e lo popolo in maniera random
                {
                    Id = i,
                    nome = "Luca",
                    cognome = "Porta",
                    eta = rand.Next(18, 80),
                };
                listaPersone.Add(persona);
            }
            return listaPersone;
        }

        //metodo che deve creare un oggetto di tipo PersoneViewModel
        //e deve essere popolato con i dati della persona con id = id parametro
        public PersoneDetailViewModel GetPersona(int id)
        {
            var rand = new Random();
            var persona = new PersoneDetailViewModel
            {
                Id = id,
                nome = "Luca",
                cognome = "Porta",
                eta = rand.Next(18, 80),
                Auto = new List<AutoViewModel>()
            };

            // lista macchine per persona con limite 10
            for (var i = 1; i <= 10; i++)
            {
                var auto = new AutoViewModel
                {
                    marca = "Fiat",
                    modello = "Cinquecento",
                    targa = "BA 123 CD"
                };
                persona.Auto.Add(auto);
            }

            return persona;
        }
    }
}