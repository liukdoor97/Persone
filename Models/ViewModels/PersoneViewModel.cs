using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;

namespace Persone.Models.ViewModels
{
    public class PersoneViewModel
    {
        public int Id{get;set;} 
        public string nome {get; set;}
        public string cognome {get; set;}
        public int eta {get; set;}
    }
}