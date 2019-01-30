using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.ORM.EF.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            
            builder.Property(c => c.Id)
               .IsRequired();

            builder.Property(c => c.Nome)                
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Login)                
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(c => c.Senha)
             .HasMaxLength(11)
             .IsRequired();

            builder.Property(c => c.Status)
             .HasMaxLength(11)
             .IsRequired();
            
        }
    }
}
