using System.ComponentModel.DataAnnotations;

namespace WinFormsApp.Models
{
    public class Docenti
    {
        [Key]
        public int DocenteId { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public string Cognome { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Telefono { get; set; } = string.Empty;
        public int CorsoId { get; set; }
        public Corsi Corsi { get; set; } = new();
    }
}
