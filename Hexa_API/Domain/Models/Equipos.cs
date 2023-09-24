using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hexa_API.Domain.Models
{
    public class Equipos
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR")]
        [MaxLength(128)]
        public string IdEquipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Jugadores> Jugadores { get; set; }

    }
}
