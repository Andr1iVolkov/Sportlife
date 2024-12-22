using Sportlife.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sportlife.Models.Gym
{
    public class ShowListGymModel
    {
        public int Id { get; set; }
        public string MainImage { get; set; }
        public string ShortAddress { get; set; }
        public virtual CityEntity City { get; set; }
        public string FullAddress { get; set; }
        public string Format { get; set; }
        public string PhoneNumber { get; set; }
    }
}
