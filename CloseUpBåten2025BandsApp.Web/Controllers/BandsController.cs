using CloseUpBåten2025BandsApp.Web.Models;
using CloseUpBåten2025BandsApp.Web.Services;
using CloseUpBåten2025BandsApp.Web.Services.BandService;
using CloseUpBåten2025BandsApp.Web.Views.Bands;
using Microsoft.AspNetCore.Mvc;

namespace CloseUpBåten2025BandsApp.Web.Controllers;

public class BandsController(BandService service) : Controller
{
    private BandService service = service;

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = service.GetAllBands();

        var viewModel = new IndexVM()
        {
            BandVMs = model
            .Select(e => new IndexVM.BandVM()
            {
                Id = e.Id,
                Name = e.Name,
            })
        .ToArray()
        };
        return View(viewModel);
    }



    [HttpGet("Details{id}")]
    public IActionResult Details(int id)
    {
        var model = service.GetById(id);

        DetailsVM viewModel = new()
        {
            Name = model.Name,
            Description = model.Description,
            PerformanceTime = model.PerformanceTime,
        };

        return View(viewModel);
    }


    [HttpGet("/create")]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost("/create")]
    public IActionResult Create(CreateVM viewModel)
    {
        if (!ModelState.IsValid) return View();
        
        Band band = new()
        {
            Name = viewModel.Name,
            Description = viewModel.Description,
        };
        service.AddBand(band);
        return RedirectToAction(nameof(Index));
    }
}
