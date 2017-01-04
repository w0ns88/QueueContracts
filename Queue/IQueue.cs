using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Queue
{
    [ContractClass(typeof(QueueContract<>))]
    public interface IQueue<T>
    {
        // Returns a value bigger or equal to 0
        int Count { get; }

        // Adds a value of the required type into the Queue   
        void Add(T type);

        // Removes the value that was added first in the Queue
        // If the Queue is empty then throw an exception
        T Remove();

        // Returns representation of the queue
        List<T> ToList();

        // Removes all values from the QueueS
        void Clear();
    }
}
