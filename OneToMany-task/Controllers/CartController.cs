using System;
using Microsoft.AspNetCore.Mvc;

namespace OneToMany_task.Controllers
{
	public class CartController :Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

