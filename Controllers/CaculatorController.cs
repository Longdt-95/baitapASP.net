using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise.Controllers
{
    public class CaculatorController : Controller
    {
        // GET: Caculator
        public ActionResult indexCaculator()
        {
            return View();
        }

        public ActionResult caculator(string inputNumber)
        {
            ViewBag.number = inputNumber;
            return View();
        }

        public ActionResult addition(FormCollection formCollection)
        {
            int result = 0;
            string operators = formCollection[formCollection.GetKey(formCollection.Count - 1)];
            /*       foreach (string item in formCollection.AllKeys)
                   {
                       if (operators.Equals("addition"))
                       {
                           result += int.Parse(formCollection[item]);
                       }else if (operators.Equals("subtraction"))
                       {
                           result -= int.Parse(formCollection[item]);
                       }
                       else if (operators.Equals("multiplication"))
                       {
                           result *= int.Parse(formCollection[item]);
                       }else
                       {
                           result /= int.Parse(formCollection[item]);
                       }
                       temp++;
                       if (temp == formCollection.Count) break;
                   }*/
            switch (operators) {
                case "addition":
                    for (int i = 0; i < formCollection.Count - 1; i++)
                    {
                        result += int.Parse(formCollection[i]);
                    }
                    break;
                case "subtraction":
                    result = int.Parse(formCollection[0]);
                    for (int i = 1; i < formCollection.Count - 1; i++)
                    {
                        result -= int.Parse(formCollection[i]);
                    }
                    break;
                case "multiplication":
                    result = 1;
                    for (int i = 0; i < formCollection.Count - 1; i++)
                    {
                        result *= int.Parse(formCollection[i]);
                    }
                    break;
                case "division":
                    result = int.Parse(formCollection[0]);
                    for (int i = 1; i < formCollection.Count - 1; i++)
                    {
                        result /= int.Parse(formCollection[i]);
                    }
                    break;
            }

            TempData["result"] = result;
            return RedirectToAction("ViewResult");
        }
        public ActionResult ViewResult()
        {
            return View();
        }
    }
}