using Microsoft.AspNetCore.Mvc;
using QUANTUMWEB.Models;
using System.Diagnostics;

namespace QUANTUMWEB.Controllers
{
    public class MusterilerController : Controller
    {
        


        public IActionResult Musteriler()
        {
            return View();
        }
		MusterilerDb dbop = new MusterilerDb();

		[HttpPost]
		public IActionResult Index([Bind] Musteriler emp)
		{
			try
			{
				if (ModelState.IsValid)
				{
					string res = dbop.Saverecord(emp);
					TempData["msg"] = res;
				}
			}
			catch (Exception ex)
			{

				TempData["msg"] = ex.Message;
			}


			return View();
		}


		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
    




