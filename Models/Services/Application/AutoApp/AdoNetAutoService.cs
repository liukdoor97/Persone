using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Persone.Models.Services.Infrastructure;
using Persone.Models.ViewModels;
using Persone.Models.InputModels.AutoInput;
using Persone.Models.Entities;

namespace Persone.Models.Services.Application.AutoApp
{
    public class AdoNetAutoService : IAutoService
    {
        private readonly IDatabaseAccessor db;

        public AdoNetAutoService(IDatabaseAccessor db)
        {
            this.db = db;
        }

        public List<AutoViewModel> GetListAuto()
        {
            FormattableString query = $"SELECT id, marca, modello, targa, personaId FROM auto;";
            DataSet dataSet = db.Query(query);
            var autoDataTable = dataSet.Tables[0];
            var autoList = new List<AutoViewModel>();
            foreach (DataRow autorow in autoDataTable.Rows)
            {
                var auto = AutoViewModel.FromDataRow(autorow);
                autoList.Add(auto);
            }
            return autoList;
        }

        public AutoViewModel GetAuto(int id)
        {
            FormattableString query = $@"SELECT id, marca, modello, targa, personaId FROM auto WHERE id = {id};";
            DataSet dataSet = db.Query(query);
            var autoDataTable = dataSet.Tables[0];
            if (autoDataTable.Rows.Count != 1) //sto controllando se la tabella ha recuperato esattamente una data auto
            {
                throw new InvalidOperationException($"Auto con id = {id} non trovata");
            }
            var autoRow = autoDataTable.Rows[0];
            var auto = AutoViewModel.FromDataRow(autoRow);
            return auto;
        }

        public AutoViewModel CreateAuto(AutoCreateInputModel input)
        {
            FormattableString query = $@"INSERT INTO auto (marca, modello, targa, personaId) VALUES ({input.marca}, {input.modello}, {input.targa}, {input.personaId.ToString()});
            SELECT last_insert_rowid();";
            DataSet dataSet = db.Query(query);
            int id = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            AutoViewModel auto = GetAuto(id);
            return auto;
        }

        public AutoEditInputModel GetAutoForEditing(int id)
        {
            return null;
        }

        public AutoViewModel EditAuto(AutoEditInputModel input)
        {
            return null;
        }

        public void DeleteAuto(AutoDeleteInputModel input){}
    }
}