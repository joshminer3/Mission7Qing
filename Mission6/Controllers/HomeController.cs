using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    private ContextClass blahContext { get; set; }


    public HomeController(ContextClass someName)
    {
        blahContext = someName;
    }

    public IActionResult Index()
    {
        return View();
    }

    //view podcasts method
    public IActionResult Podcast()
    {
        return View("Podcast");
    }

    //Add movie method
    [HttpGet]
    public IActionResult Movies()
    {
        ViewBag.Cats = blahContext.Categories.ToList();

        return View();
    }

    //View table function
    public IActionResult SeeMovies()
    {
        var applications = blahContext.Responses
            .Include(x => x.Category)
            .ToList();

        return View(applications);
    }

    //Get function that assigns the id to a variable to pull up present data
    [HttpGet]
    public IActionResult Edit(int appid)
    {
        ViewBag.Cats = blahContext.Categories.ToList();

        var category = blahContext.Responses.Single(x => x.AppId == appid);

        return View("Movies", category);
    }

    //Editing funciton that saves changes
    [HttpPost]
    public IActionResult Edit(MovieForm blah)
    {
        blahContext.Update(blah);
        blahContext.SaveChanges();

        return RedirectToAction("SeeMovies");
    }

    //Get function for deleting that also gets the ID
    [HttpGet]
    public IActionResult Delete(int appid)
    {
        var application = blahContext.Responses.Single(x => x.AppId == appid);

        return View(application);
    }

    //Post function for Deleting records
    [HttpPost]
    public IActionResult Delete(MovieForm ar)
    {
        blahContext.Responses.Remove(ar);
        blahContext.SaveChanges();

        return RedirectToAction("SeeMovies");
    }


    //Post functioin for adding a movie that validates data entered
    [HttpPost]
    public IActionResult Movies(MovieForm ar)
    {
        if (ModelState.IsValid)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirm");
        }

        else
        {
            ViewBag.Cats = blahContext.Categories.ToList();

            return View(ar);
        }
    }

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
}

