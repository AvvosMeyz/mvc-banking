using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harry.Services {
    public interface IQueue<T> {
        void Enqueue(T item);
        void Peek();
        IEnumerable<T> Get();
    }
}
