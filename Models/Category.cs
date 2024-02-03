using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moment4_webbapi.Models
{

    public class Category
    {

        //properties
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        //navigation property
        public virtual ICollection<Music>? Musics { get; set; }
    }
}