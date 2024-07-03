using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persone.Models.ViewModels;
using Persone.Models.Services.Infrastructure;
using System.Data;

namespace Persone.Models.Services.Application
{
    public class AdoNetPersonaService : IPersoneService
    {
        private readonly IDatabaseAccessor db;

        public AdoNetPersonaService(IDatabaseAccessor db)
        {
            this.db = db;
        }

        public List<PersoneViewModel> GetPersone()
        {
            //query che verrà eseguita nel database
            string query = "SELECT id, nome, cognome, eta FROM persona";
            //un oggetto di tipo DataSet è un insieme di oggetti di tipo DataTable
            DataSet dataSet = db.Query(query); 

            //Un dataTable è una tabella in cui vengono memorizzati i dati recuperati da una SELECT nel db
            //dato che in un dataSet possono esserci più tabelle, con l'indice accedo all'i-esima tabella
            var dataTable = dataSet.Tables[0];
            var personeList = new List<PersoneViewModel>();
            //scorro l'oggetto DataTable riga per riga tramite la proprietà Rows
            //per ogni riga (oggetto DataRow) leggi i dati e crea l'oggetto PersoneViewModel
            foreach(DataRow personeRow in dataTable.Rows){
                var persona = PersoneViewModel.FromDataRow(personeRow);
                personeList.Add(persona);
            }
            return personeList;
        }

        public PersoneDetailViewModel GetPersona(int id)
        {
            throw new NotImplementedException();
        }
    }
}