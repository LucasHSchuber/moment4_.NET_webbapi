using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace moment4_webbapi.Models
{

    public class Music
    {

        //properties
        [Key]
        public int SongId { get; set; }
        public string? ArtistName { get; set; }
        public string? Title { get; set; }
        public int Length { get; set; }
        //FK
        public int CategoryId { get; set; }
        //navigation property
        public virtual Category? Category { get; set; }


    }


}