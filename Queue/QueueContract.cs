using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Queue
{
    [ContractClassFor(typeof(IQueue<>))]
    internal abstract class QueueContract<T> : IQueue<T>
    {
        [Pure]
        public int Count
        {
            get
            {
                Contract.Requires(Count >= 0);
                return default(int);
            }
        }

        public void Add(T type)
        {
            Contract.Ensures(Count == Contract.OldValue(Count) +1);
        }

        public T Remove()
        {
            Contract.Requires(Count > 0);
            Contract.Ensures(Count == Contract.OldValue(Count) - 1);
            return default(T);
        }

        [Pure]
        public List<T> ToList()
        {
            Contract.Requires(Count > 0);
            Contract.Ensures(Count == Contract.Result<List<T>>().Count);
            return default(List<T>);
        }

        public void Clear()
        {
            Contract.Ensures(Count == 0);
        }
    }
}
