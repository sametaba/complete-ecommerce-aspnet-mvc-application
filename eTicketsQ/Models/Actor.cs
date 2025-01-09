﻿using System.ComponentModel.DataAnnotations;

namespace eTicketsQ.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage="Profile Picture is required")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Full name must be between 3-50 chars.")]
        public string FullName { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Bio must be between 3-50 chars.")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }   
}
