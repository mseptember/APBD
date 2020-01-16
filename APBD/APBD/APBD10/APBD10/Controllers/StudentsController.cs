using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace APBD10.Controllers
{
    public class StudentsController : Controller
    {
        private readonly s17110Context _context;

        public StudentsController()
        {
            _context = new s17110Context();
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.Include(student => student.Studies).ToListAsync());
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            
            var student = await _context.Student.FirstAsync(s => s.IdStudent == id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            ViewBag.ListOfStudies = _context.Studies.ToList();
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to
        [HttpPost]
        public async Task<IActionResult> Create([Bind("IdStudent,FirstName,LastName,Address,IndexNumber,IdStudies")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.ListOfStudies = _context.Studies.ToList();
            return View(student);
        }
    }
}