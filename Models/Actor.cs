using commerceApplication.Data.Base;

using System.ComponentModel.DataAnnotations;

namespace commerceApplication.Models
{
    public class Actor: IEntityBase


    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture ")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //RelationShips
        //I set Actor_Movie to nullable:
        public List<Actor_Movie>? Actors_Movies { get; set; }
        int IEntityBase.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
