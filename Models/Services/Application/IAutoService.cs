using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;
using Persone.Models.InputModels.Auto;


namespace Persone.Models.Services.Application
{
    public interface IAutoService
    {
        List<AutoViewModel> GetListAuto();
        AutoViewModel GetAuto(int id);
        AutoViewModel CreateAuto(AutoCreateInputModel input);
        
    }
}