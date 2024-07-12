using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;
using Persone.Models.InputModels.AutoInput;


namespace Persone.Models.Services.Application.AutoApp
{
    public interface IAutoService
    {
        List<AutoViewModel> GetListAuto();        
        AutoViewModel GetAuto(int id);
        AutoViewModel CreateAuto(AutoCreateInputModel input);
        AutoEditInputModel GetAutoForEditing(int id);
        AutoViewModel EditAuto(AutoEditInputModel input);
        void DeleteAuto(AutoDeleteInputModel input);
        
    }
}