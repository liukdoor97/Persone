using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persone.Models.InputModels
{
    public class PersonaCreateInputModel
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int eta { get; set; }
    }
}