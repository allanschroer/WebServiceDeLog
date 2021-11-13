using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using WebServiceDeLog.Models;

namespace WebServiceDeLog.Infra.Repositorio
{
    public class Repositorio : DbContext
    {
        public Repositorio(DbContextOptions<Repositorio> options) : base(options)
        {

        }

        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ColaboradorModel> Colaborador { get; set;}
        public DbSet<PedidoModel> Pedido { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
    }
}
