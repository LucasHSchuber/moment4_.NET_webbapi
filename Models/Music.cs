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
        public string? Artist { get; set; }
        public string? Title { get; set; }
        public string? Length { get; set; }
        public string? Genre { get; set; }

    }


}