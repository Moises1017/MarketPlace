namespace SeuProjeto.Models
{
    public class DbContextBase
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }
            // Configurações adicionais, se necessário
        }
    }
}