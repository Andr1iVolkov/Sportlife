using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sportlife.Data;
using Sportlife.Models.Coach;

namespace Sportlife.Controllers
{
    public class CoachesController : Controller
    {

        private readonly DataEFContext _dataEFContext;

        public CoachesController(DataEFContext dataEFContext)
        {
            _dataEFContext = dataEFContext;
        }

        public async Task<IActionResult> Index()
        {
            // Загружаем города и начальный список залов для города "Киев"
            var cities = await _dataEFContext.Cities.ToListAsync();
            var defaultCity = cities.FirstOrDefault(c => c.Name == "Київ");
            var gyms = await _dataEFContext.Gyms.Where(g => g.CityId == defaultCity.Id).ToListAsync();
            var coaches = await _dataEFContext.Coaches.Where(c => gyms.Select(g => g.Id).Contains(c.GymId)).ToListAsync();

            var model = new CityGymCoachViewModel
            {
                Cities = cities,
                Gyms = gyms,
                Coaches = coaches,
                SelectedCityId = defaultCity.Id,
                SelectedGymId = gyms.FirstOrDefault()?.Id ?? 0
            };

            return View(model);
        }

        public async Task<IActionResult> GetGymsByCity(int cityId)
        {
            var gyms = await _dataEFContext.Gyms.Where(g => g.CityId == cityId).ToListAsync();
            return Json(gyms);
        }

        public async Task<IActionResult> GetCoachesByGym(int gymId)
        {
            var coaches = await _dataEFContext.Coaches.Where(c => c.GymId == gymId).ToListAsync();
            return Json(coaches);
        }

    }
}
