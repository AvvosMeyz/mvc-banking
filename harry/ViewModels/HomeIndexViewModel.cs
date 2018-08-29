using harry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harry.ViewModels {
    public class HomeIndexViewModel {
        public IEnumerable<Customer> Customers { get; set; }
    }
}
