using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persone.Models.Entities
{
    public class Persona
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string cognome {get; set;}
        public int eta {get; set;}
        public ICollection<Auto> Auto { get; set; }//proprietà che rappresenta la relazione 1 a molti tra persona e auto

        public Persona(string nome, string cognome, int eta)
        {
            //controllo se i campi nome, cognome ed età non sono vuoti
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Il nome non può essere vuoto");
            }
            if (string.IsNullOrWhiteSpace(cognome))
            {
                throw new ArgumentException("il cognome non può essere vuoto");
            }
            if (eta <0)
            {
                throw new ArgumentException("L'età non può essere negativa");
            }
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            Auto = new HashSet<Auto>();
        }

        public void ChangeNome(string newNome)
        {
            if (string.IsNullOrWhiteSpace(newNome))
            {
                throw new ArgumentException("La Persona deve avere un nome");
            }
            nome = newNome;
        }
        public void ChangeCognome(string newCognome)
        {
            if (string.IsNullOrWhiteSpace(newCognome))
            {
                throw new ArgumentException("La Persona deve avere un cognome");
            }
            cognome = newCognome;
        }
        public void ChangeEta(int newEta)
        {
            if (newEta <0)
            {
                throw new ArgumentException("L'età non può essere negativa");
            }
            eta = newEta;
        }
    }
}