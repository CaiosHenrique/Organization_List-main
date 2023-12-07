
namespace Organization_List.Models
{
    public class Tarefa
    {  
        public int IdTarefa {get; set;}

        public string? DescTarefa {get; set;} 
        
        public bool StatusTarefa {get; set;} = false;

        public DateTime DataCriacao {get; set;} = DateTime.Now;

        public string NomeTarefa {get; set;} = "Tarefa";

    }
}