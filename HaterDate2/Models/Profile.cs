using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaterDate2.Models
{
    public class Profile
    {
        [Required]
        public string ApplicationUserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public virtual ICollection<Hate> Hates { get; set; }
        [Required]
        public Int16 Age { get; set; }
        [Required]
        public Int16 AgeMinPref { get; set; }
        [Required]
        public Int16 AgeMaxPref { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string GenderPref { get; set; }
        [Required]
        public string Bio { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public Int16 Zipcode { get; set; }
        public byte[] Image { get; set; }
        public ICollection<string> FavoriteIds { get; set; }

    }

}