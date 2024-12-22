using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sportlife.Data.Entities
{
    [Table("tblGyms")]
    public class GymEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(5000)]
        public string MainImage { get; set; }

        [Required, StringLength(100)]
        public string ShortAddress { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual CityEntity City { get; set; }

        [Required, StringLength(200)]
        public string FullAddress { get; set; }

        [Required, StringLength(200)]
        public string Format { get; set; }

        [Required, StringLength(200)]
        public string PhoneNumber { get; set; }
    }
}
