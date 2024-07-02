using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;

namespace Persone.Models.ViewModels
{
    public class PersoneDetailViewModel: PersoneViewModel
    {
        public List<AutoViewModel> Auto { get; set; }
    }
}