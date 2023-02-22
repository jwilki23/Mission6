using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    //Creating TrackerEntry class with the getters and setters for each data field, specifying the data type and any restrictions with the entry
    public class TrackerEntry
    {
        [Key]
        [Required]
        public int EntryID { get; set; }
        //build foreign key relationship
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
