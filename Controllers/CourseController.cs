using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crm_ps.Context;
using crm_ps.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

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
        var courses = _context.Courses.ToList();
        return View(courses);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Course course)
    {
        if(ModelState.IsValid)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(course);
    }

    [HttpPost]
    public IActionResult Insc(string ids)
    {
        string[] idList = ids.Split('s');

        int res;
        int res2;

        int.TryParse(idList[0], out res);
        int.TryParse(idList[1], out res2);

        var candidateCourse = new CandidateCourse() {
            CandidateId = res,
            CourseId = res2,
        };
        
        _context.CandidateCourses.Add(candidateCourse);
        _context.SaveChanges();
        
        return RedirectToAction("Index", "Course");
    }
}