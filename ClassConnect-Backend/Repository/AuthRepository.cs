using ClassConnect_Backend.Models;
using ClassConnect_Backend.Repository.Interfaces;

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


    }
}
