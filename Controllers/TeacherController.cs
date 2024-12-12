using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Data;
using mvc.Models;

public class TeacherController : Controller
{
    private readonly ApplicationDbContext _context;

    // Constructeur 
    public TeacherController(ApplicationDbContext context)
    {
        _context = context;
    }



    // public async Task<IActionResult> ShowDetails(int? id)
    // {
    //     if (id == null) return NotFound();

    // var teacher = await _context.Teachers
    //     .FirstOrDefaultAsync(m => m.Id == id);
    // if (teacher == null) return NotFound();

    //     return View();
    // }

    // GET: /Add
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }


    // // POST: /Add
    // [HttpPost]
    // public async Task<IActionResult> Add(Teacher teacher)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         _context.Add(teacher);
    //         await _context.SaveChangesAsync();
    //         return RedirectToAction(nameof(Index));
    //     }
    //     return View(teacher);
    // }

    // // GET: /Delete/Id
    // public async Task<IActionResult> Delete(int? id)
    // {
    //     if (id == null) return NotFound();

    // var teacher = await _context.Teachers
    //     .FirstOrDefaultAsync(m => m.Id == id);
    // if (teacher == null) return NotFound();

    //     return View();
    // }

    // // POST: Students/Delete/Id
    // [HttpPost, ActionName("Delete")]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> DeleteConfirmed(int id)
    // {
    // var teacher = await _context.Teachers.FindAsync(id);
    // _context.Teachers.Remove(teacher);
    // await _context.SaveChangesAsync();
    //     return RedirectToAction(nameof(Index));
    // }

    // // GET: Students/Edit/Id
    // public async Task<IActionResult> Edit(int? id)
    // {
    //     if (id == null) return NotFound();

    // var teacher = await _context.Teachers.FindAsync(id);
    // if (teacher == null) return NotFound();

    //     return View();
    // }

    // // POST: Students/Edit/ID
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Edit(int id, Teacher teacher)
    // {
    // if (id != teacher.Id) return NotFound();

    // if (ModelState.IsValid)
    // {
    //     try
    //     {
    //         _context.Update(teacher);
    //         await _context.SaveChangesAsync();
    //     }
    //     catch (DbUpdateConcurrencyException)
    //     {
    //         if (!TeacherExists(teacher.Id)) return NotFound();
    //         else throw;
    //     }
    //     return RedirectToAction(nameof(Index));
    // }
    //     return View(teacher);
    // }

    // private bool TeacherExists(int id)
    // {
    //     return _context.Teachers.Any(e => e.Id == id);
    // }

    // public async Task<IActionResult> Index()
    // {
    //     // Récupère tous les enseignants de la BDD
    //     var teachers = await _context.Users.ToListAsync();
    //     return View(teachers);
    // }

}

