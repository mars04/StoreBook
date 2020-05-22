using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreBook.Models
{
    public class Author
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Автор")]
        public string Name { get; set; }
    }
}
