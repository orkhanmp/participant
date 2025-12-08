using Core.Result.Abstract;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IParticipantService
    {
        IResult Add(Participant participant);

        IResult Update(Participant participant);
        IResult Delete(int id);

        IDataResult<List<Participant>> GetAll();
        IDataResult<Participant> Get(int id);
    }
}
