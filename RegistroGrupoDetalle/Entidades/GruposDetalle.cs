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
        public string Cargo { get; set; }

        [ForeignKey("GrupoId")]

        public GruposDetalle()
        {
            Id = 0;
            PersonaId = 0;
        }


    }
}
