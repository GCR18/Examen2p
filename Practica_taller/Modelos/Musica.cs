using System.ComponentModel.DataAnnotations;

namespace Practica_taller.Modelos
{
    public class Musica
    {
        // Llave primaria
        [Key]
        public int id_musica { 
            get; set; 
        }
        public string titulo { 
            get; set; }
        public string genero { get; set; }
        public int numero_reproducciones { get; set; }
    }
}