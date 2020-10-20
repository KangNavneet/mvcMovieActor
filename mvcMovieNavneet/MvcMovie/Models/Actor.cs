using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
