using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;
using Persone.Models.InputModels;

namespace Persone.Models.Services.Application
{
    public interface IPersoneService
    {
        List<PersoneViewModel> GetPersone();
        PersoneDetailViewModel GetPersona(int id);
        PersoneDetailViewModel CreatePersona(PersonaCreateInputModel input);
        PersonaEditInputModel GetPersonaForEditing(int id);
        PersoneDetailViewModel EditPersona(PersonaEditInputModel inputModel);
    }
}