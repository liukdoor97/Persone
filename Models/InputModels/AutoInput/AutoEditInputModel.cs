using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Persone.Models.Entities;

namespace Persone.Models.InputModels.AutoInput
{
    public class AutoEditInputModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modello { get; set; }
        public string targa { get; set; }
        public int personaId { get; set; }


        public static AutoEditInputModel FromEntity(Auto auto)
        {
            return new AutoEditInputModel
            {
                id = auto.id,
                marca = auto.marca,
                modello = auto.modello,
                targa = auto.targa,
                personaId = auto.personaId
            };
        }
    }
}