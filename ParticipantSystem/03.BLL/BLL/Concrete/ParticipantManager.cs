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
    public class ParticipantManager: IParticipantService
    {
        private readonly IParticipantDAL participantDAL;

        public ParticipantManager()
        {
            participantDAL = new ParticipantDAL();
        }

        public IResult Add(Participant participant)
        { 
            participantDAL.Add(participant);
            return new SuccessResult("Participant added successfully.");        
        }

        public IResult Delete(int id)
        {
            var participantGet = participantDAL.Get(x => x.Id == id);
            if (participantGet is not null)
            {
                participantGet.Deleted = id;
                participantDAL.Update(participantGet);
                return new SuccessResult("Participant deleted successfully");
            }


            return new ErrorResult("Participant not found");        
        }

        public IDataResult<Participant> Get(int id)
        { 
            return new SuccessDataResult<Participant>(participantDAL.Get(x=>x.Id == id && x.Deleted==0));
        }

        public IDataResult<List<Participant>>GetAll()
        {
            return new SuccessDataResult<List<Participant>>(participantDAL.GetAll(x => x.Deleted == 0));
        }

        public IResult Update(Participant participant)
        { 
            participantDAL.Update(participant);
            return new SuccessResult("Participant updated successfully");        
        }
    }
}
