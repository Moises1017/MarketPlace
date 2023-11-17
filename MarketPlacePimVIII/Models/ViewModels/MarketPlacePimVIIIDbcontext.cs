using MarketplacePimVIII.Models;
using System;

namespace SeuProjeto.Models
{
    public class MarketPlacePimVIIIDbcontext : DbContext
{
        private DbSet<Cliente> clientes;

        public MarketPlacePimVIIIDbcontext(DbSet<Cliente> clientes)
        {
            this.clientes = clientes ?? throw new System.ArgumentNullException(nameof(clientes));
        }

        public DbSet<Cliente> GetClientes()
        {
            return clientes;
        }

        public void SetClientes(DbSet<Cliente> value)
        {
            clientes = value;
        }

        public DbSet<Endereco> Enderecos { get; set; }
    }
}
