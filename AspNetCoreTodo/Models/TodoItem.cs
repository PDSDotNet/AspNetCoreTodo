using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        //Estructura que contiene un identificador unico y global. 
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }
        //Title se hacer requiered para que no sea NUL o vacio

        public DateTimeOffset? DueAt { get; set; }
        //el "?" significa que la estructura puede ser NULL
    }
}
