using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sportlife.Data;
using Sportlife.Data.Entities;
using Sportlife.Models.Gym;
using System.Collections.Generic;

namespace Sportlife.Controllers
{
    public class GymController : Controller
    {

        private readonly DataEFContext _dataEFContext;

        public GymController(DataEFContext dataEFContext)
        {
            _dataEFContext = dataEFContext;
        }

        public IActionResult ShowListGym(ShowListGymModel listGymModel)
        {
            var cities = _dataEFContext.Cities
                .Where(c => c.Name != "Київ") 
                .ToList();

            var cityList = new List<CityEntity> { new CityEntity { Name = "Київ" } };
            cityList.AddRange(cities);

            var query = _dataEFContext.Gyms.AsQueryable();

            if (!string.IsNullOrEmpty(listGymModel.City?.Name))
            {
                query = query.Where(g => g.City.Name == listGymModel.City.Name);
            }
            else
            {
                query = query.Where(g => g.City.Name == "Київ");
            }


            var listGyms = query.Include(g => g.City)
                .Select(g => new ShowListGymModel()
                {
                    Id = g.Id,
                    MainImage = g.MainImage,
                    ShortAddress = g.ShortAddress,
                    City = g.City,
                    FullAddress = g.FullAddress,
                    Format = g.Format,
                    PhoneNumber = g.PhoneNumber
                }).ToList();

            var model = new ShowListGymViewModel
            {
                Gyms = listGyms,
                Cities = cities
            };

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_GymListPartial", model);
            }


            return View("ShowListGym", model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
