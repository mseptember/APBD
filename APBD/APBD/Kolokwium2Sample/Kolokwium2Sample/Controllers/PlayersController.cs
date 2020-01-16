using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2Sample.DAL;
using Kolokwium2Sample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2Sample.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IDbLayer _service;

        public PlayersController(IDbLayer service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Players = _service.GetPlayers();
            ViewBag.Teams = _service.GetTeams();
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("FirstName,LastName,BirthDate,IdTeam")] Player newPlayer)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Players = _service.GetPlayers();
                ViewBag.Teams = _service.GetTeams();

                ModelState.AddModelError("FirstName", "Invalid first name");
                ModelState.AddModelError("LastName", "Invalid last name");
                ModelState.AddModelError("IdTeam", "Please select a team");

                return View("Index", newPlayer);
            }

            _service.AddNewPlayer(newPlayer);

            return RedirectToAction("Index");
        }
    }
}