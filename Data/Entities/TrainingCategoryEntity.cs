using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sportlife.Data.Entities
{
    [Table("tblTrainingCategory")]
    public class TrainingCategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }
        public virtual ICollection<CoachCategoryTrainingEntity> CoachCategoryTraining { get; set; }
    }
}
