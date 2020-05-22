using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreBook.Models
{
    public class Series
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Серия")]
        public string Name { get; set; }
    }
}
