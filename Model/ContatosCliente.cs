using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstHotel
{
    public class ContatosCliente
    {
        [Key]
        public int CodContato {get; set;}
        public Cliente? CodCliente {get; set;}
        public string? TelefoneContato {get; set;}
        public string? EnderecoContato {get; set;}  

    }
}