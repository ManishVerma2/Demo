using Demotostart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Demotostart.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContex context;
        private readonly ICountryRepository repository;

        public CountryController(ApplicationDbContex context, ICountryRepository repository)
        {
            this.context = context;
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(context.Countries.Select(c=> new CountryViewModel()
            { 
                id = c.Id,
                CName=c.Name,
               

            }).ToList());
        }
        [HttpPost]
        public IActionResult Create(CountryViewModel model)
        {
            if(ModelState.IsValid)
            {
                context.Countries.Add(new Country()
                {   Id=model.id,
                    Name = model.CName ,
                    

                });
                context.SaveChanges();
            }
            return PartialView("_CountryListPv", context.Countries.Select(c => new CountryViewModel()
            {
                id=c.Id,
                CName = c.Name,
                
            }).ToList());
        }
        [HttpPost]
        public IActionResult Update(CountryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var countryToUpdate = context.Countries.Find(model.id);
                if (countryToUpdate != null)
                {
                    countryToUpdate.Name = model.CName;
                  

                    context.SaveChanges();
                }
            }

            return PartialView("_CountryListPv", context.Countries.Select(c => new CountryViewModel()
            {
                id = c.Id,
                CName = c.Name,
               
                
            }).ToList());
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var countryToDelete = context.Countries.Find(id);
            if (countryToDelete != null)
            {
                context.Countries.Remove(countryToDelete);
                context.SaveChanges();
            }

            return PartialView("_CountryListPv", context.Countries.Select(c => new CountryViewModel()
            {
                id = c.Id,
                CName = c.Name,
               
            }).ToList());
        }


    }
}
