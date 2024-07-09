using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persone.Models.Entities
{
    public class Auto
    {
        public int id {get; set;}
        public string marca {get; set;}
        public string modello {get; set;}
        public string targa {get; set;}
        public Persona Persona {get; set;}
        public int personaId { get; set; }

        public Auto(string marca, string modello, string targa, int personaId){
            //controllo se i campi marca, modello e targa non sono vuoti
            if (string.IsNullOrWhiteSpace(marca))
            {
                throw new ArgumentException("La marca non può essere vuota");
            }
            if (string.IsNullOrWhiteSpace(modello))
            {
                throw new ArgumentException("il modello non può essere vuoto");
            }
            if (string.IsNullOrWhiteSpace(targa))
            {
                throw new ArgumentException("La targa non può essere vuota");
            }
            this.marca = marca;
            this.modello = modello;
            this.targa = targa;
            this.personaId = personaId;
        }

        public void ChangeMarca(string newMarca)
        {
            if (string.IsNullOrWhiteSpace(newMarca))
            {
                throw new ArgumentException("L'Auto deve avere una marca");
            }
            marca = newMarca;
        }
        public void ChangeModello(string newModello)
        {
            if (string.IsNullOrWhiteSpace(newModello))
            {
                throw new ArgumentException("L'Auto deve avere un modello");
            }
            modello = newModello;
        }
        public void ChangeTarga(string newTarga)
        {
            if (string.IsNullOrWhiteSpace(newTarga))
            {
                throw new ArgumentException("L'Auto deve avere una targa");
            }
            targa = newTarga;
        }
    }
}