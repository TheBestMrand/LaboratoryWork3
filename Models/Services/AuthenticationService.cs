using LaboratoryWork3.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryWork3.Models.Services
{
    public class AuthenticationService
    {
        private readonly AppDbContext _dbContext;

        public AuthenticationService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> RegisterUserAsync(string email, string password)
        {
            var user = new User
            {
                Email = email,
                Password = password
            };

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> LoginUserAsync(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user;
        }
    }
}
