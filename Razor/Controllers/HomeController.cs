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

		public ActionResult DemoExpression()
		{
			ViewBag.ProductCount = 1;
			ViewBag.ExpressShip = true;
			ViewBag.ApplyDiscount = false;
			ViewBag.Supplier = null;

			return View(product);
		}

		public ActionResult DemoArray()
		{
			Product[] products =
			{
				new Product { Name ="Kayak1", Price = 275M},
				new Product { Name ="Kayak2", Price = 276M},
				new Product { Name ="Kayak3", Price = 277M},
				new Product { Name ="Kayak4", Price = 278M}
			};

			return View(products);
		}
	}
}