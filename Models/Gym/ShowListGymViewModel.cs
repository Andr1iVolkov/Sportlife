using Sportlife.Data.Entities;

namespace Sportlife.Models.Gym
{
    public class ShowListGymViewModel
    {
        public IEnumerable<ShowListGymModel> Gyms { get; set; }
        public IEnumerable<CityEntity> Cities { get; set; }
    }

}
