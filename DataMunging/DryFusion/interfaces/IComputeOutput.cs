using System.Collections.Generic;

namespace DryFusion.interfaces
{
    public interface IComputeOutput<T>
    {
          void Compute(IEnumerable<T> enumerable);
    }
}