using GamesPlay.Models;
using GamesPlay.Services;
using Microsoft.AspNetCore.Mvc;

namespace GamesPlay.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GameController : GenericController<Game>
    {
        public GameController(GameService service) : base(service)
        {
        }
    }
}
