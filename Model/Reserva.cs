using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Reserva
    {
        [Key]
        public int CodReserva {get; set;}
        public Hotel? CodHotel {get; set;}
        public Quarto? NumeroQuarto {get; set;}
        public Cliente? CodCliente {get; set;}
        public DateOnly? DtReserva {get; set;}
        public DateOnly? DtInicioReserva {get; set;}
        public DateOnly? DtFimReserva {get; set;}
        public string? TipoReserva {get; set;}
        public string? StatusReserva {get; set;}
        public Funcionario? CodFuncionario {get; set;}
        public string? colchaoOpcional {get; set;}      

    }
}