using Microsoft.AspNetCore.Mvc;
using CircleCalculator.Models;

public class CircleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(double radius)
    {
        if (radius <= 0)
        {
            ViewBag.Error = "Bán kính phải lớn hơn 0";
            return View("Index");
        }

        var circle = new CircleModel { Radius = radius };
        ViewBag.DienTich = Math.Round(circle.DienTich, 2);
        ViewBag.ChuVi = Math.Round(circle.ChuVi, 2);
        ViewBag.DuongKinh = Math.Round(circle.DuongKinh, 2);
        ViewBag.HasResult = true;

        return View("Index");
    }
} 