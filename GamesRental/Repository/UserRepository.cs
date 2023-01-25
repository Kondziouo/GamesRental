using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesRental.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;

        }

        public bool Add(Customer customer)
        {
            _context.Add(customer);
            return Save();
        }

        public bool Delete(Customer customer)
        {
            _context.Remove(customer);
            return Save();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            //return await _context.Customers.Include(i => i.).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomerBySurname(string lastname)
        {
            return await _context.Customers.Where(c => c.LastName.Contains(lastname)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Customer customer)
        {
            _context.Update(customer);
            return Save();
        }
    }
}
