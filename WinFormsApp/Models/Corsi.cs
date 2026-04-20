using System.ComponentModel.DataAnnotations;

namespace WinFormsApp.Models
{
    public class Corsi
    {
        [Key]
        public int CorsoId { get; set; } // Proprietà

        [Required]
        public string NomeCorso { get; set; }

        [Required]
        public string Descrizione { get; set; }

        public DateOnly DataInizion {  get; set; } = new DateOnly();
    }
}
