using Microsoft.AspNetCore.Mvc;
using JourneyTracker.Web.Models;

namespace JourneyTracker.Web.Controllers
{
    public class TrackerController : Controller
    {
        private readonly AppDbContext _context;

        public TrackerController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()


      
        {
            var logs = _context.StudyLogs.ToList();


            decimal totalHours = logs.Sum(log => log.HoursSpent);
            decimal targetHours = 700;
            decimal progressPercentage = (totalHours / targetHours) * 100;
            ViewBag.TotalHours = totalHours;
            ViewBag.ProgressPercentage = Math.Round(progressPercentage, 1);
            return View(logs);
        }
        [HttpPost]
        public IActionResult Create(StudyLog newLog)
        {
            newLog.LogDate = DateTime.Now;

            _context.StudyLogs.Add(newLog);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }       
            
        
}    
