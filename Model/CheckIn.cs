using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class CheckIn
    {
        [Key]
        public int CodCheckIn {get; set;} 
        public Cliente? CodCliente {get; set;}
        public string? StatusCheckIn {get; set;}   
        public int PeriodoPermanecia {get; set;}  
        public ICollection<Consumo> Consumos {get; set;} = new List<Consumo>();          
        
    }
}