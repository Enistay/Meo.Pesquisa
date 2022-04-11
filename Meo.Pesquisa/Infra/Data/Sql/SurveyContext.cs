using Meo.Pesquisa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meo.Pesquisa.Infra.Data.Sql
{
    public class SurveyContext : DbContext
    {
        public DbSet<Form> Form { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<OptionQuestion> Options { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public SurveyContext(DbContextOptions<SurveyContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Form>()
                .Property(p => p.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Form>()
                .Property(p => p.Description)
                .HasMaxLength(200);

            modelBuilder.Entity<Question>()
                .Property(p => p.Description)
                .HasMaxLength(200);            

            modelBuilder.Entity<Question>()
                .Property(p => p.InputType)
                .HasMaxLength(50);

            modelBuilder.Entity<OptionQuestion>()
               .Property(p => p.Description)
               .HasMaxLength(100);

            modelBuilder.Entity<Answer>()
               .Property(p => p.Description)
               .HasMaxLength(150);
        }

    }
}
