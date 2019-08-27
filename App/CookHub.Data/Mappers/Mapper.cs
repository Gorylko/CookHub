using System;
using System.Collections.Generic;
using System.Text;

namespace CookHub.Data.Mappers
{
    public class Mapper<TInput, TOutput>
    {
        Func<TInput, TOutput> Map { get; set; }

        Func<TInput, TOutput> MapCollection { get; set; }
    }
}
