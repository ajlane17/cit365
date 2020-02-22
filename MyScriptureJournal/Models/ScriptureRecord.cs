using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class ScriptureRecord
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Book { get; set; }

        [Required]
        [Range(1, 1024)]
        public short Chapter { get; set; }

        [Required]
        [Range(1, 1024)]
        public short Verse { get; set; }

        [StringLength(int.MaxValue)]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        [Required]
        [Display(Name = "Created")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Display(Name = "Modified")]
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }
    }
}
