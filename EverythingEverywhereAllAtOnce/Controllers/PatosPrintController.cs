using Bussiness;
using EverythingEverywhereAllAtOnce.Models;
using Microsoft.AspNetCore.Mvc;

namespace EverythingEverywhereAllAtOnce.Controllers;

public class PatosPrintController : Controller
{
    private Application Current;
    public PatosPrintController(Application application)
    {
        Current = application;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PrintTicket()
    {
        PrintTicketModel printTicketModel = new PrintTicketModel();
        printTicketModel.FilamentList = GetFilamentList();
        printTicketModel.UserList = UserEntity.GetAllUsersList();

        return View(printTicketModel);
    }

    /// <summary>
    /// Gets all filament in stock
    /// </summary>
    /// <returns>List of all filament in stock</returns>
    private List<Filament> GetFilamentList()
    {
        List<Filament> filamentList = new List<Filament>();

        //TODO: GET FILLAMENT FROM DATABASE
        filamentList.Add(new Filament { FilamentID = 1, FilamentName = "PLA PRETO" });
        filamentList.Add(new Filament { FilamentID = 2, FilamentName = "PLA BRANCO" });
        filamentList.Add(new Filament { FilamentID = 3, FilamentName = "PLA CINZENTO" });

        return filamentList;
    }

    /// <summary>
    /// Adds a new print ticket to database
    /// </summary>
    /// <param name="NewPrintTicket">Filled Model from view</param>
    /// <returns>status and/or redirect</returns>
    [HttpPost]
    private IActionResult NewPrintTicket(PrintTicketModel NewPrintTicket)
    {
        return new JsonResult(true);
        if (ModelState.IsValid)
        { }
    }
}

