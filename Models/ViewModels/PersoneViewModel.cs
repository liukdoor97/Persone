using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Persone.Models.ViewModels;

namespace Persone.Models.ViewModels
{
    public class PersoneViewModel
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public int eta { get; set; }

        public static PersoneViewModel FromDataRow(DataRow personeRow)
        {
            var personeViewModel = new PersoneViewModel
            {
                nome = Convert.ToString(personeRow["nome"]),
                cognome = Convert.ToString(personeRow["cognome"]),
                eta = Convert.ToInt32(personeRow["eta"]),
                Id = Convert.ToInt32(personeRow["id"])
            };
            return personeViewModel;
        }
    }
}