using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sportlife.Data.Entities
{
    [Table("tblCoaches")]
    public class CoachEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(500)]
        public string FirstName { get; set; }

        [Required, StringLength(500)]
        public string SecondName { get; set; }

        [Required, StringLength(5000)]
        public string MainImage { get; set; }

        [Required, StringLength(5000)]
        public string ShortDescription { get; set; }

        [Required, StringLength(2000)]
        public string Quote { get; set; }

        [ForeignKey("Gym")]
        public int GymId { get; set; }
        public virtual GymEntity Gym { get; set; }
    }
}
