using System;
using Microsoft.AspNetCore.Mvc;
using EverythingEverywhereAllAtOnce.Models;

namespace EverythingEverywhereAllAtOnce.Controllers;

public class ReadMeController : Controller
{
	public ReadMeController()
	{
        
	}

    public IActionResult Index()
    {
         return View();
    }
}

