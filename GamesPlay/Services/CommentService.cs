using GamesPlay.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesPlay.Services
{
    public class CommentService : IGenericService<Comment>
    {

        private readonly GamePlayContext context;

        public CommentService(GamePlayContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Comment>> GetAll()
        {
            return await context.Comments.ToListAsync();
        }

        public async Task<Comment> GetById(int id)
        {
            return await context.Comments.SingleOrDefaultAsync(x=> x.Id == id);
        }

        public async Task Add(Comment item)
        {
            context.Comments.Add(item);
            await context.SaveChangesAsync();
        }


        public async Task Update(Comment item)
        {
            var result = await context.Comments.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (result != null)
            {
                result.UserId = item.UserId;
                result.Content = item.Content;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await context.Comments.FirstOrDefaultAsync(x => x.Id == id);
            if(result!=null)
            {
                context.Comments.Remove(result);
                await context.SaveChangesAsync();
            }
        }

       
    }
}
