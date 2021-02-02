using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesProject.Data;
using SuperHeroesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesProject.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext _context;
        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHeroController
        public ActionResult Index()
        {
            var heroes = _context.SuperHeroes.ToList();
            return View(heroes);
        }

        // GET: SuperHeroController/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superhero = _context.SuperHeroes.FirstOrDefault(i => i.Id == id);
            return View(superhero);
        }

        // GET: SuperHeroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                _context.SuperHeroes.Add(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superhero = _context.SuperHeroes.Single(i => i.Id == id);
            return View();
        }

        // POST: SuperHeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                _context.SuperHeroes.Update(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                _context.Remove(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
