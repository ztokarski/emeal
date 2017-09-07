using System;
using System.Collections.Specialized;

namespace emeal.Services
{
    public class ConsoleService
    {
        internal static void OnRecipesChanged(object source, NotifyCollectionChangedEventArgs args)
        {
            Console.WriteLine($@"An action was executed on {source}: {args.Action}");
        }
    }
}