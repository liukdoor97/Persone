using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

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
    }
}