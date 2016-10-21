using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebAppCore.Models
{
    public class Meet
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength =3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Required]
        public string venue { get; set; }

    }
}
