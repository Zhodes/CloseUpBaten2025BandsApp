using CloseUpBåten2025BandsApp.Web.Models;
using CloseUpBåten2025BandsApp.Web.Services;
using CloseUpBåten2025BandsApp.Web.Services.BandService;
using Microsoft.AspNetCore.Mvc;

namespace CloseUpBåten2025BandsApp.Web.Controllers;

public class BandsController : Controller
{
    private static BandService service = new BandService();

    [HttpGet("")]
    public IActionResult Index() => View(service.GetAllBands());

    [HttpGet("Details{id}")]
    public IActionResult Details(int id)
    {
        var model = service.GetById(id);
        return View(model);
    }


    [HttpGet("/create")]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost("/create")]
    public IActionResult Create(Band band)
    {
        if (!ModelState.IsValid)
        {

            return View();
        }
            
        service.AddBand(band);
        return RedirectToAction(nameof(Index));
    }
}
