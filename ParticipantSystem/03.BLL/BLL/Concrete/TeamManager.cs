using BLL.Abstract;
using Core.Result.Abstract;
using Core.Result.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDAL teamDAL;

        public TeamManager()
        {
            teamDAL = new TeamDAL();
        }

        public IResult Add(Team team)
        {
            teamDAL.Add(team);
            return new SuccessResult("Team added successfully");
        }

        public IResult Update(Team team)
        {
            teamDAL.Update(team);
            return new SuccessResult("Team updated successfully");
        }

        public IResult Delete(int id)
        {
            var team = teamDAL.Get(t => t.Id == id);
            teamDAL.Delete(team);
            return new SuccessResult("Team deleted successfully");
        }

        public IDataResult<Team> Get(int id)
        {
            var team = teamDAL.GetWithParticipants(id);
            return new SuccessDataResult<Team>(team);
        }

        public IDataResult<List<Team>> GetAll()
        {
            var teams = teamDAL.GetAllWithParticipants(); 
            return new SuccessDataResult<List<Team>>(teams);
        }
    }
}
