using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIT365_SacramentProgram.Models
{
    public class Meeting
    {
        //PRIMARY MEETING IDENTIFIERS
        //*****************************

        public int Id { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Date")]
        public DateTime MeetingDate { get; set; }
        [Display(Name = "Theme"), StringLength(255, MinimumLength = 4, ErrorMessage = "Max 255 characters in length")]
        public String? Theme { get; set; }

        //PRESIDING, CONDUCTING, MUSIC
        //*****************************
        [Display(Name = "Presiding"), StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters in length"), Required]
        public String Presiding { get; set; }
        [Display(Name = "Conducting"), StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters in length"), Required]
        public String Conducting { get; set; }
        [Display(Name = "Music Director"), StringLength(50, MinimumLength = 4, ErrorMessage = "Must be between 4 and 50 characters in length"), Required]
        public String Director { get; set; }
        [Display(Name = "Organist"), StringLength(50, MinimumLength = 4, ErrorMessage = "Must be between 4 and 50 characters in length"), Required]
        public String Organist { get; set; }

        //OPENING PRAYERS AND SONGS
        //*****************************
        [Display(Name = "Invocation"), StringLength(50, MinimumLength = 4, ErrorMessage = "Must be between 4 and 50 characters in length"), Required]
        public String Invocation { get; set; }
        [Required(ErrorMessage ="An opening hymn is required"),Display(Name ="Opening Hymn Number"),Range(1, 999)]
        public Int16 OpeningHymnNumber { get; set; }
        [Required(ErrorMessage = "An opening hymn description is required"), Display(Name = "Opening Hymn Description")]
        public String OpeningHymnDescription { get; set; }
        [Required(ErrorMessage = "An opening hymn is required"), Display(Name = "Sacrament Hymn Number"), Range(1, 999)]
        public Int16 SacramentHymnNumber { get; set; }
        [Required(ErrorMessage = "A sacrament hymn description is required"), Display(Name = "Sacrament Hymn Description")]
        public String SacramentHymnDescription { get; set; }


        //SPEAKERS
        //********************************************************************
        public IList<Speaker> Speakers { get; set; }

        //OPTIONAL INTERMEDIATE Music
        //****************************
        [Display(Name = "Intermediate Musical Number"),StringLength(50, MinimumLength = 4, ErrorMessage = "Must be between 4 and 50 characters in length")]
        public string? IntermediateMusic { get; set; }

        //CLOSING HYMN AND BENEDICTION
        //******************************
        [Required(ErrorMessage = "An closing hymn is required"), Display(Name = "Closing Hymn Number"), Range(1, 999)]
        public Int16 ClosingHymnNumber { get; set; }
        [Required(ErrorMessage = "An closing hymn description is required"), Display(Name = "Closing Hymn Description")]
        public String ClosingHymnDescription { get; set; }
        [Display(Name = "Benediction"), StringLength(50, MinimumLength = 4, ErrorMessage = "Must be between 4 and 50 characters in length"), Required]
        public String Benediction { get; set; }

        public Meeting()
        {
            this.Speakers = new List<Speaker>();
        }

    }
}
