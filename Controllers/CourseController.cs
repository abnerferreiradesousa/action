using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crm_ps.Context;
using crm_ps.Models;

namespace crm_ps.Controllers;

public class CourseController : Controller
{
    public readonly PlataformContext _context;

    public CourseController(PlataformContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var candidates = _context.Courses.ToList();
        return View(candidates);
    }

    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(Course course)
    {
        if(ModelState.IsValid)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(course);
    }
}