using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDBContext _appDBContext;

        public ActorsService(AppDBContext context)
        {
            _appDBContext = context;
        }
        public void AddActor(Actor actor)
        {
            _appDBContext.Actors.Add(actor);
            _appDBContext.SaveChanges();
        }

        public Actor GetActorById(int ActorId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _appDBContext.Actors.ToListAsync();
            return result;
        }

        public Actor UpdateActor(Actor actor, out bool isUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
