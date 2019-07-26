using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookHub.ConsoleTester.Worker;
using CookHub.Data.DbContext.Realization;

namespace CookHub.ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new DbWorker("Data Source=LAPTOP-P3338OQH;Initial Catalog=CookHubDB;Integrated Security=True", new ProcedureExecutor());
            var recipe = worker.GetById(3);
            Console.ReadKey();
        }
    }
}
