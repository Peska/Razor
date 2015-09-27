using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
	public class HomeController : Controller
	{
		Product product = new Product()
		{
			ProductID = 1,
			Name = "Kayak",
			Description = "A boat for one person",
			Category = "Watersports",
			Price = 275M
		};

		public ActionResult Index()
		{
			return View(product);
		}

		public ActionResult NameAndPrice()
		{
			return View(product);
		}
	}
}