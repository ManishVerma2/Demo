using Microsoft.EntityFrameworkCore;

namespace Demotostart.Models
{
        public class CountryRepository : ICountryRepository
        {
            private readonly ApplicationDbContex context;

            public CountryRepository(ApplicationDbContex context)
            {
                this.context = context;
            }
            public async Task<Country> Add(Country country)
            {
                await context.Countries.AddAsync(country);
                await context.SaveChangesAsync();
                return country;
            }

            public async Task<Country> Delete(int id)
            {
                var result = await GetById(id);
                if (result != null)
                {
                    context.Countries.Remove(result);
                    await context.SaveChangesAsync();
                }
                return null;
            }

            public async Task<IList<Country>> GetAll()
            {
                return await context.Countries.ToListAsync();
            }

            public async Task<Country> GetById(int id)
            {
                return await context.Countries.FirstAsync(x => x.Id == id);
            }

            public async Task<Country> GetByName(string name)
            {
                return await context.Countries.Where(x => x.Name == name).FirstAsync();
            }

            public async Task<Country> Update(Country country)
            {
                context.Countries.Update(country);
                await context.SaveChangesAsync();
                return country;
            }
        }
}

