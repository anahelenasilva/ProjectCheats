using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameManager.DataAccess;

namespace VideoGameManager.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController : ControllerBase
    {
        private readonly VideoGameDataContext _context;

        public GamesController(VideoGameDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Game> GetAll() => this._context.Games.Include(i => i.Genre);

        [HttpGet]
        [Route("{id}")]
        public Game GetById(int id) => this._context.Games.Include(i => i.Genre).FirstOrDefault(f => f.Id == id);

        [HttpPost]
        public async Task<Game> Post([FromBody] Game game)
        {
            this._context.Games.Add(game);
            await this._context.SaveChangesAsync();
            return game;
        }
    }
}
