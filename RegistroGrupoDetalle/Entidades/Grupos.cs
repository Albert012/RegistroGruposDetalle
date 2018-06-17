using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace RegistroGrupoDetalle.Entidades
{
    public class Grupos
    {
        [Key]

        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Decimal Cantidad { get; set; }//Cantidad de Estudiantes
        public Decimal Grupo { get; set; }//Grupo deseado
        public Decimal Integrantes { get; set; }//Integrantes por grupo

        [StringLength(100)]
        public string Comentarios { get; set; }

        public virtual ICollection<GruposDetalle> Detalle { get; set; }

        public Grupos()
        {
            this.Detalle = new List<GruposDetalle>();
        }

        public void AgregarDetalle(int id, int GrupoId, int PersonaId)
        {
            this.Detalle.Add(new GruposDetalle(id, GrupoId, PersonaId));
        }

        /*public Grupos()
        {
            GrupoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            Grupo = 0;
            Integrantes = 0;
        }*/


    }
}
