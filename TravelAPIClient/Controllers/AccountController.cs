using Microsoft.AspNetCore.Mvc;
using TravelAPIClient.Models;

namespace TravelAPIClient.Controllers;

public class AccountController : Controller
{


  public ActionResult Index()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(ApplicationUser applicationUser)
  {
    ApplicationUser.Post(applicationUser);
    return RedirectToAction("Index");
  }

}