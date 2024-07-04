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
            //In un'unica variabile string io inserisco tutte le query che devono essere eseguite
            string query = "SELECT id, nome, cognome, eta FROM persona WHERE id =" + id 
            + "; SELECT id, marca, modello, targa, personaId FROM auto WHERE personaId =" + id;
            //in questo dataSet ci saranno due tabelle: la prima con i dati della persona e la seconda con i dati delle auto della persona
            DataSet dataSet = db.Query(query);
            var personaDataTable = dataSet.Tables[0]; //accedo dal dataSet alla prima tabella cioè a quella che è stata restituita dall'esecuzione della prima query
            if(personaDataTable.Rows.Count != 1) //sto controllando se la tabella ha recuperato esattamente una data persona
            {
                throw new InvalidOperationException($"Persona con id = {id} non trovata");
            }
            var personaRow = personaDataTable.Rows[0];//accedo alla prima riga della tabella
            var personaDetailViewModel = PersoneDetailViewModel.FromDataRow(personaRow);
            
            
            var autoDataTable = dataSet.Tables[1];//accedo dal dataSet alla seconda tabella. cioè a quella che è stata restituita dall'esecuzione della seconda query
            foreach(DataRow autoRow in autoDataTable.Rows){
                var auto = AutoViewModel.FromDataRow(autoRow);
                personaDetailViewModel.Auto.Add(auto);
            }

            return personaDetailViewModel;
        }
    }
}