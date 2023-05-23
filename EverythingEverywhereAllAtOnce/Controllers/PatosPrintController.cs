using System;
using Microsoft.AspNetCore.Mvc;
using EverythingEverywhereAllAtOnce.Models;

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
}

