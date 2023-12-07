using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System;
using Organization_List.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace Organization_List.Models
{
    public class Tarefa
    {  
        [Key]
        [Column ("IdTarefa")]
        public int IdTarefa {get; set;} 

        public string? DescTarefa {get; set;} 
        
        public bool StatusTarefa {get; set;} = false;

        public DateTime DataCriacao {get; set;} = DateTime.Now;

        public string NomeTarefa {get; set;} = "Tarefa";

        public TarefasEnum TarefaClass {get; set;}

    }
    
}