using Core.Concrete;
using DAL.Abstract;
using DAL.Database;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ParticipantDAL: BaseRepository<Participant, ApplicationDbContext>, IParticipantDAL
    {
        public List<Participant> GetAllWithTeams()
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Participants
                    .Include(p => p.Team)
                    .ToList();
            }
        }

        public Participant GetWithTeam(int id)
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Participants
                    .Include(p => p.Team)
                    .FirstOrDefault(p => p.Id == id);
            }
        }
    }
}
