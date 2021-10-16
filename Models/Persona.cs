using System.ComponentModel.DataAnnotations;

namespace bertozzi.mattia._5H.PrimoEF.Models
{
    public class Persona
    {
        [Key]
        public int idPersona { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [EmailAddress]
        public string Email{ get; set; }
    }


}