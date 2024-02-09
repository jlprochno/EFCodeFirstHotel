using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Cliente
    {   
        [Key]
        public int CodCliente {get; set;}
        public string? NomeCliente {get; set;}
        public string? EmailCliente {get; set;}   
        public string? NacionalidadeCliente {get; set;}   
        public ICollection<ContatosCliente> ContatosClientes {get; set;} = new List<ContatosCliente>(); 
        public ICollection<Reserva> Reservas {get; set;} = new List<Reserva>();  
        public ICollection<CheckIn> CheckIns {get; set;} = new List<CheckIn>();  
        public ICollection<CheckOut> CheckOuts {get; set;} = new List<CheckOut>();

    }
}