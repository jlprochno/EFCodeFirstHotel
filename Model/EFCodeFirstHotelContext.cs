using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstHotel
{
    public class EFCodeFirstHotelContext : DbContext
    {
        [Key]
        public DbSet<Hotel> Hoteis {get; set;} = null!;
        public DbSet<Quarto> Quartos {get; set;} = null!;
        public DbSet<Funcionario> Funcionarios {get; set;} = null!;
        public DbSet<Cliente> Clientes {get; set;} = null!;
        public DbSet<ContatosCliente> ContatosClientes {get; set;} = null!;
        public DbSet<Reserva> Reservas {get; set;} = null!;
        public DbSet<CheckIn> CheckIns {get; set;} = null!;
        public DbSet<Consumo> Consumos {get; set;} = null!;
        public DbSet<CheckOut> CheckOuts {get; set;} = null!;
        public DbSet<Restaurante> Restaurantes {get; set;} = null!;
        public DbSet<Lavanderia> Lavanderias {get; set;} = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCodeFirstHotel;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True"); 
        }
    }
}