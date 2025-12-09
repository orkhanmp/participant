using Core.Result.Abstract;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface ITeamService
    {        
        IResult Add(Team team);
        IResult Update(Team team);
        IResult Delete(int id);
        IDataResult<Team> Get(int id);
        IDataResult<List<Team>> GetAll();
    }
}
