using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Persone.Models.InputModels.Persone
{
    public class PersonaEditInputModel
    {
        public int id {get; set;}
        public string nome { get; set; }
        public string cognome { get; set; }
        public int eta { get; set; }

        public static PersonaEditInputModel FromDataRow(DataRow personeRow)
        {
            var personaEditInputModel = new PersonaEditInputModel
            {
                nome = Convert.ToString(personeRow["nome"]),
                cognome = Convert.ToString(personeRow["cognome"]),
                eta = Convert.ToInt32(personeRow["eta"]),
                id = Convert.ToInt32(personeRow["id"])
            };
            return personaEditInputModel;
        }
    }
}