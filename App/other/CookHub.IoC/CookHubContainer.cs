using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Shared.Entities;
using StructureMap;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookHub.IoC
{
    public static class CookHubContainer
    {
        public static IContainer Container { get; private set; }

        public static void Initialize()
        {
            Container = new Container(something => something.Scan(
                scan =>
                {
                    ScanData(scan);
                    scan.LookForRegistries();
                }           
            ));
        }

        private static void ScanData(IAssemblyScanner scanner)
        {
            scanner.AssemblyContainingType<IRecipeContext>();
            scanner.AssemblyContainingType<IIngredientContext>();
            scanner.AssemblyContainingType<IDataContext<User>>();

            scanner.AssemblyContainingType<IRecipeRepository>();
            scanner.AssemblyContainingType<IIngredientRepository>();
        }
    }
}
