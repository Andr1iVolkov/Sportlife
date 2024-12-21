using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sportlife.Data.Entities
{
    [Table("tblCities")]
    public class CityEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(500)]
        public string Name { get; set; }
    }
}
