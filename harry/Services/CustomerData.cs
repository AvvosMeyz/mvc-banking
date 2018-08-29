using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using harry.Models;

namespace harry.Services {
    public class CustomerData : ICustomer, IComparable<Customer>
    {
        public int Number;
        public int Prio;
      

        public CustomerData(int number, int priority) {
            this.Number = number;
            this.Prio = priority;

            _customers = new List<Customer>
            {
                new Customer {Number = 100, Prio= 2},
                new Customer {Number = 111, Prio= 2},
                new Customer {Number = 112, Prio= 2},
                new Customer {Number = 113, Prio= 2},
                new Customer {Number = 55,  Prio= 1},
            };
        }

        public IEnumerable<Customer> GetAll() {
            return _customers.OrderBy(r => r.Number);
        }

        public int CompareTo(Customer other) {
            if (this.Prio == other.Prio) return -1;
            else if (this.Prio < other.Prio) return 1;
            else return 0;
        }


        List<Customer> _customers;
    }
}
