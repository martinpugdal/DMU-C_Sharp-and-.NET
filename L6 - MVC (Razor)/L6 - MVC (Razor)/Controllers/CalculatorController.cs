using Microsoft.AspNetCore.Mvc;

namespace L6___MVC__Blazor_.Controllers
{
    public class CalculatorController : Controller
    {
        // Getter for Calculator
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TimeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TimeCalculator(IFormCollection formCollection)
        {
            int hours = int.Parse(formCollection["Hours"]);
            int minutes = int.Parse(formCollection["Minutes"]);
            int seconds = int.Parse(formCollection["Seconds"]);

            // Calculating total seconds
            double totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            // Display the result on a new view or pass it back to the same view
            ViewBag.Result = $"{hours} hours + {minutes} minutes + {seconds} seconds = {totalSeconds} seconds";

            Console.WriteLine(ViewBag.Result);

            return View("TimeCalculatorResult");
        }

        public IActionResult TimeCalculatorResult()
        {
            return View();
        }

        public IActionResult SimpleCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleCalculator(IFormCollection formCollection)
        {
            if (formCollection["Number1"] == string.Empty || formCollection["Number2"] == string.Empty || formCollection["operator"] == string.Empty)
            {
                ViewBag.Error = "Du skal vælge et nummer for at kunne udføre denne regnestykke.";
                return View();
            }


            double number1 = 0;
            double number2 = 0;
            try
            {
                number1 = Convert.ToDouble(formCollection["Number1"]);
                number2 = Convert.ToDouble(formCollection["Number2"]);
            }
            catch (FormatException)
            {
                ViewBag.Error = "Du skal indsætte dem ind som et tal";
                ViewBag.Number1 = formCollection["Number1"];
                ViewBag.Number2 = formCollection["Number2"];
                return View();
            }

            double result = -1;
            switch (formCollection["operator"])
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                    {
                        ViewBag.Error = "Du kan ikke dividere med 0";
                        return View();
                    }
                    break;
            }


            ViewBag.Result = result;
            ViewBag.Number1 = number1.ToString();
            ViewBag.Number2 = number2.ToString();
            ViewBag.Error = null;

            return View();
        }
    }
}