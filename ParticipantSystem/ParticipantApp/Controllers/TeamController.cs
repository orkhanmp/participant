using BLL.Abstract;
using BLL.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace ParticipantApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;

        public TeamController()
        {
            teamService = new TeamManager();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var teamList = teamService.GetAll().Data;
            return View(teamList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Team team)
        {
            teamService.Add(team);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id != 0)
            {
                var team = teamService.Get(id).Data;
                return View(team);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Team team)
        {
            teamService.Update(team);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            teamService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var team = teamService.Get(id).Data;
            if (team == null)
            {
                return RedirectToAction("Index");
            }
            return View(team);
        }
    }
}