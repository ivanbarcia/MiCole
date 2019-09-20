using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using API.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<ErrorDetails> ErrorDetails { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Funcion> Funcion { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolFuncion> RolFuncion { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<CursoAsignatura> CursoAsignatura { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
        public DbSet<TutorAlumno> TutorAlumno { get; set; }
        public DbSet<TipoProfesional> TipoProfesional { get; set; }
        public DbSet<Profesional> Profesional { get; set; }
        public DbSet<ProfesionalCurso> ProfesionalCurso { get; set; }
        public DbSet<AlumnoCurso> AlumnoCurso { get; set; }
        public DbSet<Notificacion> Notificacion { get; set; }
        public DbSet<Autorizacion> Autorizacion { get; set; }
        public DbSet<AutorizacionRetiro> AutorizacionRetiro { get; set; }
        public DbSet<ConfiguracionHoraria> ConfiguracionHoraria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DATABASE"));
            }
        }

        public override int SaveChanges()
        {
            try
            {
                var modifiedEntries = ChangeTracker.Entries()
                    .Where(x => x.Entity is AuditableEntity
                                && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));

                foreach (var entry in modifiedEntries)
                {
                    var entity = entry.Entity as AuditableEntity;

                    if (entity == null) continue;

                    var identityName = string.Empty;

                    //if (HttpContext.Current != null)
                    //    identityName = HttpContext.Current.Request.LogonUserIdentity.Name;

                    var now = DateTime.Now;

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entity.Estado = 1;
                            entity.UsuarioNovedad = identityName;
                            entity.FechaNovedad = now;
                            break;
                        default:
                            //base.Entry(entity).Property(x => x.FechaAlta).IsModified = false;
                            //base.Entry(entity).Property(x => x.UsuarioAlta).IsModified = false;
                            entity.Estado = entity.Estado;
                            entity.UsuarioNovedad = identityName;
                            entity.FechaNovedad = now;
                            break;
                    }
                }

                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message, ex.InnerException.InnerException);
            }
        }
    }
}
