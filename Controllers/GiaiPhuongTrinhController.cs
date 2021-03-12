using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise.Controllers
{
    public class GiaiPhuongTrinhController : Controller
    {
        // GET: GiaiPhuongTrinh
        public ActionResult giaiPhuongTrinh()
        {
            return View();
        }


        public ActionResult phuongTrinhBac1(string number1, string number2)
        {
            if (number1 != null && number2 != null)
            {
                float result = (float)(0 - int.Parse(number2)) / int.Parse(number1);
                TempData["result"] = result.ToString();
            }
            return View();
        }

        public ActionResult phuongTrinhBac2(string number1, string number2, string number3)
        {
            if (number1 != null && number2 != null && number3 != null)
            {
                int temp1 = int.Parse(number1);
                int temp2 = int.Parse(number2);
                int temp3 = int.Parse(number3);
                int delta = temp2 * temp2 - 4 * temp1 * temp3;
                if (delta < 0)
                {
                    TempData["result"] = "phương trình vô nghiệm";
                }else if (delta == 0)
                {
                    float result = ((float) temp2 * (-1) / (2*temp1));
                    TempData["result"] = result.ToString();  
                }else
                {
                    double result1 = (temp2 * (-1) + Math.Sqrt((double)delta)) / (2*temp1);
                    double result2 = (temp2 - Math.Sqrt((double)delta)) / (2 * temp1);
                    TempData["result"] = "nghiệm thứ 1 = " + result1.ToString() + " và " + "nghiệm thứ 2 = " + result2.ToString();
                }
            }
            return View();
        }
    }
}