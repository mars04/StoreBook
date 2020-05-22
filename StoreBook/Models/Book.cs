using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreBook.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Автор")]
        public Author Author { get; set; }

        [Display(Name = "Редактор")]
        public Editor Editor { get; set; }

        [Display(Name = "Жанр")]
        public Genre Genre { get; set; }

        [Display(Name = "Издательство")]
        public Publish Publish { get; set; }

        [Display(Name = "Серия")]
        public Series Series { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        public string ImageURL { get; set; }

    }
}
