using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using harry.Models;
using harry.Services;
using harry.ViewModels;

namespace harry.Controllers {
    public class HomeController : Controller {


        // Singleton for queue inst. only one que object throughout the app's life
       //  static private IQueue<Customer> _que;

       //  public HomeController(IQueue<Customer> que) {
        //     _que = que;      
            
             
        // }

        
        [HttpGet]
        public IActionResult Index() {

            


            Customer e1 = new Customer { Number = 100, Prio = 2 };
            Customer e2 = new Customer { Number = 101, Prio = 2 };
            Customer e3 = new Customer { Number = 102, Prio = 2 };
            Customer e4 = new Customer { Number = 55, Prio = 1 };

            //  _que.Enqueue(e1);
            //  _que.Enqueue(e2);
            //  _que.Enqueue(e3);
            // _que.Enqueue(e4);

            //   var model = _que.get();

            var model = new HomeIndexViewModel();
        //    model.Customers = _que.Get();

            return View(nameof(About), model);
        }

        public IActionResult About() {
            

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
