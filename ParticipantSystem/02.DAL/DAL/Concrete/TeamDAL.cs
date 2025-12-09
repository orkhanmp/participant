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
    public class TeamDAL: BaseRepository<Team, ApplicationDbContext>, ITeamDAL
    {
        public List<Team> GetAllWithParticipants()
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Teams
                    .Include(t => t.Participants)
                    .ToList();
            }
        }

        public Team GetWithParticipants(int id)
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Teams
                    .Include(t => t.Participants)
                    .FirstOrDefault(t => t.Id == id);
            }
        }
    }
}