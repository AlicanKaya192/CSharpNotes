using Microsoft.AspNetCore.Mvc;
using Project_OOP.Entity;
using Project_OOP.ProjeContext;

namespace Project_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if (p.Name.Length >= 6 && p.City != "" && p.City.Length >= 3)
            {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.error = "Lütfen geçerli bir isim ve şehir giriniz.";
                return View();
            }
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = _context.Customers.Where(x => x.ID == id).FirstOrDefault();
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = _context.Customers.Where(x => x.ID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = _context.Customers.Where(x => x.ID == p.ID).FirstOrDefault();
            value.Name = p.Name;
            value.City = p.City;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
