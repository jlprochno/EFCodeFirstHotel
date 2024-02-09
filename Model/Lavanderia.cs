using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Lavanderia
    {
        [Key]
        public int CodConsumoLavanderia {get; set;}
        public Consumo? CodConsumo {get; set;}
        public string? ServicoLavanderia {get; set;}   
        public double ValorServicoLavanderia {get; set;} 
        public double ValorConsumoLavanderia {get; set;}         
        
    }
}