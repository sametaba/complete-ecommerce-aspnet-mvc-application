using eTicketsQ.Data.Base;
using eTicketsQ.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketsQ.Models
{
    public class NewMovieVM
    {

        public int Id { get; set; }

        [Display(Name="Movie Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie Poster")]
        [Required(ErrorMessage = "Poster is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "SSelect a Category")]
        [Required(ErrorMessage = "Category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Actor is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select Cinema(s)")]
        [Required(ErrorMessage = "Cinma is required")]
        public int CinemaId { get; set; }


        [Display(Name = "Select Producer(s)")]
        [Required(ErrorMessage = "Prodcuer is required")]
        public int ProducerId { get; set; }
        
    }
}
