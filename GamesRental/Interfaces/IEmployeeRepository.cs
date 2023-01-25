using GamesRental.Models;

namespace GamesRental.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetByIdAsync(int id);
        Task<IEnumerable<Employee>> GetEmployeesByEmail(string email);
        bool Add(Employee employee);
        bool Update(Employee employee);
        bool Delete(Employee employee);
        bool Save();
    }
}
