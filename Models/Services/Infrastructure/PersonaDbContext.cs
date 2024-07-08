using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Persone.Models.Entities;

namespace Persone.Models.Services.Infrastructure
{
    //classe tramite cui potrò eseguire le operazioni CRUD tra le classi entità e il database
    public partial class PersonaDbContext : DbContext
    {
        public PersonaDbContext()
        {
        }

        public PersonaDbContext(DbContextOptions<PersonaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }//oggetto tramite cui potrò eseguire le operazioni CRUD con la tabella persona del db
        public virtual DbSet<Auto> Auto { get; set; }//oggetto tramite cui potrò eseguire le operazioni CRUD con la tabella Auto del db

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //istruzione che mi connette al database tramite connection string
            optionsBuilder.UseSqlite("Data Source=Data/persona.db");

        }

        //metodo che mi permette di configurare tutte le classi entità con le tabelle del database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //setto tutti i matching tramite l'oggetto modelBuilder
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");//tramite ToTable indico che la classe entità Persona mappa la tabella persona del db
                entity.HasKey(persona => persona.id);//tramite HasKey indico che la proprietà Id è la chiave primaria della tabella   


                //codice per inserire la relazione uno a molti tra la lista di Auto nell'entità Persona
                //e il singolo oggetto Persona nell'entità Auto
                entity.HasMany(persona => persona.Auto)
                .WithOne(auto => auto.Persona)
                .HasForeignKey(auto => auto.personaId);//indico che la chiave esterna è il campo personaId dell'entità Auto


                modelBuilder.Entity<Auto>(e =>
                {
                    e.ToTable("auto");//associo l'entità Auto alla tabella auto del db
                    e.HasKey(auto => auto.id);//indicco la chiave primaria di Auto

                    //mappatuta della proprietà marca di Auto superflua
                    //perchè se la proprietà dell'entità ha lo stesso identico nome del campo nella tabella del db
                    //la mappatura avviene automaticamente

                    //la proprietà Persona nella classe Auto rappresenta il lato 1
                    e.HasOne(auto => auto.Persona)
                        .WithMany(persona => persona.Auto)//che si riferisce lato N alla proprietà Auto dell'entità Persona
                        .HasForeignKey(auto => auto.personaId);
                });
            });
        }
    }
}