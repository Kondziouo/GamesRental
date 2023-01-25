using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesRental.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Employee employee)
        {
            _context.Employees.Add(employee);
            return Save();
        }

        public bool Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            return Save();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByEmail(string email)
        {
            return await _context.Employees.Where(c => c.Email.Contains(email)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Employee employee)
        {
            _context.Update(employee);
            return Save();
        }
    }
}
