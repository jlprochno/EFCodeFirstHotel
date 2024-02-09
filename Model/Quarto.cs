using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Quarto
    {
        [Key]
        public int NumeroQuarto {get; set;}
        public int CodHotel {get; set;}
        public string? Adaptado {get; set;}
        public string? TipoQuarto {get; set;} 
        public Hotel? Hotel {get; set;} 
        public ICollection<Reserva> Reservas {get; set;} = new List<Reserva>();             

    }
}