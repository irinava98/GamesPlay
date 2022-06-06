using GamesPlay.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesPlay.Services
{
    public class GameService : IGenericService<Game>
    {
        private readonly GamePlayContext context;

        public GameService(GamePlayContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await context.Games.ToListAsync();
        }

        public async Task<Game> GetById(int id)
        { 
            return await context.Games.SingleOrDefaultAsync(x=>x.Id == id); 
        }

        public async Task Add(Game item)
        {
            context.Games.Add(item);
            await context.SaveChangesAsync();
        }


        public async Task Update(Game item)
        {
            var result = await context.Games.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (result != null)
            {
                result.Title = item.Title;
                result.Category = item.Category;
                result.GameLink = item.GameLink;
                result.ImageUrl = item.ImageUrl;
                result.Summary = item.Summary;
                result.Likes = item.Likes;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await context.Games.FirstOrDefaultAsync(x => x.Id == id);
            if(result!=null)
            {
                context.Games.Remove(result);
                await context.SaveChangesAsync();
            }
        }


    }
}
