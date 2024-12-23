using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sportlife.Data.Entities
{
    [Table("tblCoachCategoriesTraining")]
    public class CoachCategoryTrainingEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Coach")]
        public int CoachId { get; set; }
        public virtual CoachEntity Coach { get; set; }

        [ForeignKey("TrainingCategory")]
        public int CategoryId { get; set; }
        public virtual TrainingCategoryEntity TrainingCategory { get; set; }
    }
}
