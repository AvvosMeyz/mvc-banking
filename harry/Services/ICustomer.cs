using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using harry.Models;

namespace harry.Services {
    public interface ICustomer {
        IEnumerable<Customer> GetAll();
    }
}
