using GamesPlay.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesPlay.Services
{
    public class UserService : IGenericService<User>
    {
        private readonly GamePlayContext context;

        public UserService(GamePlayContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await context.Users.SingleOrDefaultAsync(x => x.Id == id);
        }
        public async Task Add(User item)
        {
            context.Users.Add(item);
            await context.SaveChangesAsync();
        }

        public async Task Update(User item)
        {
            var result = await context.Users.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (result != null)
            {
                result.Username = item.Username;
                result.Email = item.Email;
                result.Role = item.Role;
                result.Password = item.Password;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteById(int id)
        {
            var result=await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(result!=null)
            {
                context.Users.Remove(result);
                await context.SaveChangesAsync();
            }
        }

    }
}
