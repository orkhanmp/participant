using Core.Concrete;
using DAL.Abstract;
using DAL.Database;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class TeamDAL: BaseRepository<Team, ApplicationDbContext>, ITeamDAL
    {
    }
}