using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;

namespace Persone.Models.ViewModels
{
    public class AutoViewModel
    {
        public int idAuto {get; set;}
        public string marca {get; set;}
        public string modello {get; set;}
        public string targa {get; set;}
    }
}