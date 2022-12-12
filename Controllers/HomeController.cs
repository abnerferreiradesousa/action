using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using crm_ps.Models;
using crm_ps.Context;

namespace crm_ps.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }
    
    public readonly PlataformContext _context;
    public HomeController(PlataformContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Candidate candidate)
    {
        if(ModelState.IsValid) 
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
            var candidateDb = _context.Candidates.OrderBy(c => c.Id).LastOrDefault();
            TempData["CandidateId"] = candidateDb.Id;
            return RedirectToAction("Index", "Course");
        }
        return View();
    }

    // [HttpPost("{id}")]
    // public IActionResult Inscrever(int id)
    // {
    //     var course = _context.Courses.Find(id);

    //     _context.SaveChanges();
        
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
