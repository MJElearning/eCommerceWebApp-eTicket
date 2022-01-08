using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetActorById(int ActorId);
        void AddActor(Actor actor);
        Actor UpdateActor(Actor actor, out bool isUpdated);
    }
}
