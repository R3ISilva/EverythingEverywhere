using EverythingEverywhereAllAtOnce.Models;
using Microsoft.AspNetCore.Mvc;

namespace EverythingEverywhereAllAtOnce.Controllers;

public class PatosPrintController : Controller
{
    public PatosPrintController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PrintTicket()
    {
        PrintTicketModel printTicketModel = new PrintTicketModel();
        printTicketModel.FilamentList = GetFilamentList();
        printTicketModel.UserList = GetUserList();

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
    /// Gets all users in database
    /// </summary>
    /// <returns>List of all users in database</returns>
    private List<User> GetUserList()
    {
        List<User> userList = new List<User>();

        //TODO: GET USERS FROM DATABASE
        userList.Add(new User { UserID = 1, UserName = "João" });
        userList.Add(new User { UserID = 2, UserName = "Edgar" });
        userList.Add(new User { UserID = 3, UserName = "Rato" });

        return userList;
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

