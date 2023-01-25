using GamesRental.Models;

namespace GamesRental.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetByIdAsync(int id);
        Task<IEnumerable<Customer>> GetCustomerBySurname(string lastname);
        bool Add(Customer customer);
        bool Update(Customer customer);
        bool Delete(Customer customer);
        bool Save();
    }
}
