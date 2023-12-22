using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Todo
    {
        [Column("todoId")]
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }

    }
}
