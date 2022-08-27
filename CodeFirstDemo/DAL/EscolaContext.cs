using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using CodeFirstDemo.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirstDemo.DAL
{
    internal class EscolaContext : DbContext
    {
        public EscolaContext() : base("EscolaContext")
        {
        }
            public DbSet<Aluno> Alunos { get; set; }
           public DbSet<Matricula> Matriculas { get; set; }
           public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    }

