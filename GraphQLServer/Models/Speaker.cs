using System.ComponentModel.DataAnnotations;

namespace GraphQLServer.Models
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Name { get; set; } 

        [StringLength(4000)]
        public string? Bio { get; set; }

        [StringLength(1000)]
        public virtual string? WebSite { get; set; }

        public ICollection<SessionSpeaker> SessionSpeakers { get; set; } = new List<SessionSpeaker>();
    }
}
