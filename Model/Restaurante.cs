using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Restaurante
    {
        [Key]
        public int CodConsumoRestarante {get; set;}
        public Consumo? CodConsumo {get; set;}
        public double ConsumoRestaurante {get; set;}   
        public double ConsumoFrigobar {get; set;} 
        public double ConsumoEntregaQuarto {get; set;} 
        public double TaxaEntregaQuarto {get; set;}            
        
    }
}