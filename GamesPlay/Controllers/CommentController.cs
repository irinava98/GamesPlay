using GamesPlay.Models;
using GamesPlay.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GamesPlay.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CommentController : GenericController<Comment>
    {
        public CommentController(CommentService service) : base(service)
        {
        }
    }
}
