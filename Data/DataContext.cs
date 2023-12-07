// Purpose: To create the database context for the application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Organization_List.Models;

namespace Organization_List.Data
{

    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> TB_TAREFAS {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Tarefa() {IdTarefa = 1, DescTarefa = "Passear Com o Tobias no parque pois está um dia lindo", StatusTarefa = false, DataCriacao = DateTime.Now, NomeTarefa = "Passear com o Cachorro"};
            new Tarefa() {IdTarefa = 2, DescTarefa = "Fazer o almoço para a mamãe", StatusTarefa = false, DataCriacao = DateTime.Now, NomeTarefa = "Fazer o almoço"};
            new Tarefa() {IdTarefa = 3, DescTarefa = "Estudar para a prova de matemática", StatusTarefa = false, DataCriacao = DateTime.Now, NomeTarefa = "Estudar"};
            new Tarefa() {IdTarefa = 4, DescTarefa = "Fazer o trabalho de história", StatusTarefa = false, DataCriacao = DateTime.Now, NomeTarefa = "Fazer o trabalho"};
        }
    }
}