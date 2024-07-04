using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;
using System.Data;
using Persone.Models.Services.Infrastructure;

namespace Persone.Models.ViewModels
{
    public class AutoViewModel
    {
        public int id {get; set;}
        public string marca {get; set;}
        public string modello {get; set;}
        public string targa {get; set;}
        public PersoneViewModel persona {get; set;}

        public static AutoViewModel FromDataRow(DataRow dataRow)
        {
            var autoViewModel = new AutoViewModel
            {
                id = Convert.ToInt32(dataRow["id"]),
                marca = Convert.ToString(dataRow["marca"]),
                modello = Convert.ToString(dataRow["modello"]),
                targa = Convert.ToString(dataRow["targa"]),
                persona = new PersoneViewModel()
            };
            return autoViewModel;
        }
    }
}