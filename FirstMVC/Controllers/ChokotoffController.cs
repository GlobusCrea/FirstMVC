using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class ChokotoffController : Controller
    {
        [HttpGet]
        public ViewResult ConfirmForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ConfirmForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Merci", guestResponse);
            }
            else
            {
                return View();
            }
        }
	}
}