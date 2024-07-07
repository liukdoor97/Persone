using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persone.Models.InputModels.Auto
{
    public class AutoCreateInputModel
    {
        public string marca {get; set;}
        public string modello {get; set;}
        public string targa {get; set;}
        public int personaId { get; set; }
    }
}