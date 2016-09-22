using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example.Calculator
{

    interface ICalculator
    {
        Task<IMessage<Result>> AddAsync(IMessage<BinaryOpArgs> param, CancellationToken ct);

    }
}
