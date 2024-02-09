using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace EFCodeFirstHotel
{
    public class Hotel
    {
        [Key]
        public int CodHotel {get; set;}
        public string? NomeHotel {get; set;}        
        public int QuantidadeQuartos {get; set;}
        public string? TipoQuarto {get;set;}
        public string? EnderecoHotel {get;set;}
        public int QuantidadeEstrelasHotel {get; set;} 
        public ICollection<Quarto> Quartos {get; set;} = new List<Quarto>();  
        public ICollection<Reserva> Reservas {get; set;} = new List<Reserva>();     

    }
}