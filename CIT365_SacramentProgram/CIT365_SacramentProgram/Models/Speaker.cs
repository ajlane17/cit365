using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIT365_SacramentProgram.Models
{
    public enum SpeakerType
    {
        Adult,
        Youth
    }
    public class Speaker
    {
        public int SpeakerId { get; set; }
        
        [Required]
        [MaxLength(50)]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Topic { get; set; }

        [Required]
        public SpeakerType Type { get; set; } = SpeakerType.Adult;

        [Required]
        public int MeetingId { get; set; }
    }
}
