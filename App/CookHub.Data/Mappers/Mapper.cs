using System;
using System.Collections.Generic;
using System.Text;

namespace CookHub.Data.Mappers
{
    public class Mapper<TInput, TOutput>
    {
        public Func<TInput, TOutput> Map { get; set; }

        public Func<TInput, TOutput> MapCollection { get; set; }
    }
}
