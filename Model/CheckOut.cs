using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class CheckOut
    {
        [Key]
        public int CodNotaFiscal {get; set;}
        public Cliente? CodCliente {get; set;}
        public string? PagamantoNotaFiscal {get; set;}      
        public double ValorDiariaSolteiro {get; set;} 
        public double ValorDiariaCasal {get; set;} 
        public double ValorDiariaFamília {get; set;} 
        public double ValorDiariaPresidencial {get; set;} 
        public double TaxaColchao {get; set;}        
        
    }
}