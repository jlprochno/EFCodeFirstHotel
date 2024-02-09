using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario {get; set;}
        public string? CargoFuncionario {get; set;}
        public string? NomeFuncionario {get; set;}
        public ICollection<Reserva> Reservas {get; set;} = new List<Reserva>();        

    }
}