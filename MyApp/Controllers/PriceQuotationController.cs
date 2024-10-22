using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{

    public class PriceQuotationController : Controller
    {
        // This will load the form for the first time
        public IActionResult Index()
        {
            var model = new PriceQuotation();  // Create an empty model to pass to the view
            return View(model);  // Load the form
        }

        // This handles the form submission
        [HttpPost]
        public IActionResult Calculate(PriceQuotation model)
        {
            if (ModelState.IsValid)  // Validate the input data
            {
                return View("Index", model);  // Return the calculated values
            }
            else
            {
                return View("Index", model);  // Return the view with validation errors
            }
        }
    }
}