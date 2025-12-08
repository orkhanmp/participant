using BLL.Abstract;
using BLL.Concrete;
using DAL.Abstract;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace ParticipantApp.Controllers
{
    public class ParticipantController : Controller
    {
        private readonly IParticipantService participantService;

        public ParticipantController()
        {
            participantService = new ParticipantManager();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var ParticipantList = participantService.GetAll().Data;
            return View(ParticipantList);
        }

        [HttpGet("Detail/{id}")]
        public IActionResult Detail (int id)
        {
            var participantGet = participantService.Get(id).Data;
            return View(participantGet);
        }

        [HttpGet]

        public IActionResult Add()
        { 
            return View(); 
        }

        [HttpPost]

        public IActionResult Add (Participant participant)
        {
            participantService.Add(participant);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            if (id != 0)
            {
                var participantId = participantService.Get(id).Data;
                return View(participantId);
            }

            return RedirectToAction();
        }

        [HttpPost]

        public IActionResult Edit(Participant participant)
        { 
            participantService.Update(participant);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            participantService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Search(int? id)
        {
            if (id.HasValue && id.Value > 0)
            {
                var participant = participantService.Get(id.Value).Data;
                if (participant != null)
                {                    
                    var list = new List<Participant> { participant };
                    return View("Index", list);
                }
               
                return View("Index", new List<Participant>());
            }

            
            var participantList = participantService.GetAll().Data;
            return View("Index", participantList);
        }

    }
}
