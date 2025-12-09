// BLL/Concrete/ParticipantManager.cs
using BLL.Abstract;
using Core.Result.Abstract;
using Core.Result.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using Entities.TableModels;

namespace BLL.Concrete
{
    public class ParticipantManager : IParticipantService
    {
        private readonly IParticipantDAL participantDAL;

        public ParticipantManager()
        {
            participantDAL = new ParticipantDAL();
        }

        public IDataResult<List<Participant>> GetAll()
        {
            var participants = participantDAL.GetAllWithTeams(); 
            return new SuccessDataResult<List<Participant>>(participants);
        }

        public IDataResult<Participant> Get(int id)
        {
            var participant = participantDAL.GetWithTeam(id); 
            return new SuccessDataResult<Participant>(participant);
        }

        
        public IResult Add(Participant participant)
        {
            participantDAL.Add(participant);
            return new SuccessResult("Participant added successfully");
        }

        public IResult Update(Participant participant)
        {
            participantDAL.Update(participant);
            return new SuccessResult("Participant updated successfully");
        }

        public IResult Delete(int id)
        {
            var participant = participantDAL.Get(p => p.Id == id);
            participantDAL.Delete(participant);
            return new SuccessResult("Participant deleted successfully");
        }
    }
}