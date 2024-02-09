using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Consumo
    {   
        [Key]
        public int CodConsumo {get; set;}
        public CheckIn? CodCheckin {get; set;}
        public string? DescricaoConsumo {get; set;}   
        public double ValorConsumo {get; set;} 
        public string? DtConsumo {get; set;} 
        public ICollection<Restaurante> Restaurantes {get; set;} = new List<Restaurante>();
        public ICollection<Lavanderia> Lavanderias {get; set;} = new List<Lavanderia>(); 
        
        
    }
}