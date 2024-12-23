using Sportlife.Data.Entities;

namespace Sportlife.Models.Coach
{
    public class CityGymCoachViewModel
    {
        public List<CityEntity> Cities { get; set; }
        public List<GymEntity> Gyms { get; set; }
        public List<CoachEntity> Coaches { get; set; }

        public int SelectedCityId { get; set; }
        public int SelectedGymId { get; set; }
    }
}
