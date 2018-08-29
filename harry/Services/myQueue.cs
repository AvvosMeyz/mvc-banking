using harry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harry.Services {
    public class myQueue<T> where T : IComparable<T>, IQueue<T> {

        public List<T> data;

        public myQueue() {
            data = new List<T>();
        }

        public void Enqueue(T item) {
            data.Add(item);

            int count = 1; // counting how many customer are consecutive starting with 1.
            int lasti = data.Count - 1; // index for last item
            int previ = lasti - 1; // previous item of the last index
            int order; // customer with a higher priority will inserted according to this order number


            // find out if higher proirity customer comes after regular customer
            if (lasti > 0 && data[lasti].CompareTo(data[lasti - 1]) == 0)
            {
                // count how many customers are consecutive
                for (int i = data.Count - 2; i > 0; i--)
                {
                    if (data[i].CompareTo(data[i - 1]) == -1)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                // if it is more than 2 devide that number with 2 and take the floor. then insert the item.
                if (count > 2)
                {
                    order = (count / 2);
                    data.Insert(lasti - order, item);
                    data.RemoveAt(data.Count - 1);
                }

            }
        }

        public void Peek() {
            data.RemoveAt(0);
        }


        public IEnumerable<T> Get() {

            return data;

        }

    }
}
