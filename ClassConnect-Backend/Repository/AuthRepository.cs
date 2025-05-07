using ClassConnect_Backend.Models;
using ClassConnect_Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassConnect_Backend.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BackendDBContext _dbContext;
        public AuthRepository(BackendDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateUser(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsExistingEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return await _dbContext.Users
                .AsNoTracking()
                .AnyAsync(user => user.Email == email);
        }

    }
}
