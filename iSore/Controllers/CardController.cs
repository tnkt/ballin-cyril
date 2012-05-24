using System;
using System.Web.Mvc;
using iSore.Models;

namespace iSore.Controllers
{
  public class CardController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet]
    public ActionResult Create()
    {
      return View();
    }
    [HttpGet]
    public ActionResult Edit(Guid id)
    {
      return View();
    }
    [HttpGet]
    public ActionResult Details(Guid id)
    {
      return View();
    }

    [HttpPost]
    public ActionResult Delete(Guid id)
    {
      TempData["card"] = card;
      TempData["success"] = true;
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult Create(Card card)
    {
      TempData["card"] = card;
      TempData["success"] = true;
      return RedirectToAction("Create");
    }
    [HttpPost]
    public ActionResult Edit(Card card)
    {
      TempData["card"] = card;
      TempData["success"] = true;
      return RedirectToAction("Edit");
    }
  }
}