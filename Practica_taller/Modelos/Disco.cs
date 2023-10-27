using System.ComponentModel.DataAnnotations;

namespace Practica_taller.Modelos
{
    public class Disco
    {
        // Llave primaria
        [Key]
        public int id_disco { 
            get; set; 
        }
        public string titulo { 
            get; set; 
        }
        public string autor { get; set; }
        public int age { get; set; }
    }
}