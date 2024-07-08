using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Persone.Models.Entities;

namespace Persone.Models.ViewModels
{
    public class PersoneDetailViewModel: PersoneViewModel
    {
        public List<AutoViewModel> Auto { get; set; }

        public static new PersoneDetailViewModel FromDataRow(DataRow personeRow)
        {
            var personaDetailViewModel = new PersoneDetailViewModel
            {
                nome = Convert.ToString(personeRow["nome"]),
                cognome = Convert.ToString(personeRow["cognome"]),
                eta =Convert.ToInt32(personeRow["eta"]),
                Id = Convert.ToInt32(personeRow["id"]),

                
                Auto = new List<AutoViewModel>()
            };
            return personaDetailViewModel;
        }

        public static PersoneDetailViewModel FromEntity(Persona persona){
            return new PersoneDetailViewModel {
                Id = persona.id,
                nome = persona.nome,
                cognome = persona.cognome,
                eta = persona.eta,
                Auto = persona.Auto
                                    .Select(auto => AutoViewModel.FromEntity(auto))
                                    .ToList()
            };
        }
    }
}