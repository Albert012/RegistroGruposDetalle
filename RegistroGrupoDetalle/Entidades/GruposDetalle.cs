using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroGrupoDetalle.Entidades
{
    public class GruposDetalle
    {
        [Key]

        public int Id { get; set; }
        public int GrupoId { get; set; }
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Persona { get; set; }
        public string Cargo { get; set; }

        public GruposDetalle()
        {
            Id = 0;
            GrupoId = 0;
        }

        public GruposDetalle(int id, int grupoId, int personaId, string cargo)
        {
            Id = id;
            GrupoId = grupoId;
            PersonaId = personaId;
            Cargo = cargo;
        }
    }
}
