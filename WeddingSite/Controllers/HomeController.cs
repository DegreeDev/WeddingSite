using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeddingSite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
		public ActionResult Us()
		{
			return View(); 
		}

		public ActionResult Proposal()
		{
			return View(); 
		}

		public ActionResult RSVP()
		{
			return View();
		}
		public ActionResult Registry()
		{
			return View();
		}
		public ActionResult Reception()
		{
			return View();
		}
		public ActionResult Ceremony()
		{
			return View();
		}
		public ActionResult Photos()
		{
			var photos = new List<string>
			{ 
				"IMG_3946.jpg",
				"IMG_3948.jpg",
				"IMG_3949.jpg",
				"IMG_3967.jpg",
				"IMG_3968.jpg",
				"IMG_3970.jpg",
				"IMG_3973.jpg",
				"IMG_3976.jpg",
				"IMG_3978.jpg",
				"IMG_3980.jpg",
				"IMG_4008.jpg",
				"IMG_4027.jpg",
				"IMG_4030.jpg",
				"IMG_4074.jpg",
				"IMG_4077.jpg",
				"IMG_4089.jpg",
				"IMG_4106.jpg",
				"IMG_4116.jpg",
				"IMG_4133.jpg",
				"IMG_4152.jpg",
				"IMG_4153.jpg",
				"IMG_4173.jpg",
				"IMG_4175.jpg",
				"IMG_4190.jpg",
				"IMG_4196.jpg",
				"IMG_4198.jpg",
				"IMG_4201.jpg",
				"IMG_4204.jpg",
				"IMG_4207.jpg",
				"IMG_4217.jpg",
			};

			//var d = new DirectoryInfo(@"C:\Users\Matthew\Dropbox\Natalya & Matt Photos");
			//var copyTo = new DirectoryInfo(@"C:\Users\Matthew\Documents\Visual Studio 2012\Projects\WeddingSite\WeddingSite\Content\images\gallery");
			//foreach (var file in d.EnumerateFiles("*.jpg").Where(x=> photos.Contains(x.Name)))
			//{
			//	file.CopyTo(copyTo + @"\" + file.Name);
			//}

			return View(photos);
		}
		public ActionResult Party()
		{
			return View();
		}
		public ActionResult Guests()
		{
			return View();
		}

		public ActionResult Admin()
		{
			return View();
		}

		public ActionResult Upload()
		{
			return View(); 
		}
	}
}
