using System.ComponentModel.DataAnnotations;

namespace Demotostart.Models
{
    public interface ICountryRepository
    {
        Task<IList<Country>> GetAll();
        Task<Country> GetById(int id);
        Task<Country> GetByName(string name);
        Task<Country> Add(Country country);
        Task<Country> Update(Country country);
        Task<Country> Delete(int id);
    }
}
