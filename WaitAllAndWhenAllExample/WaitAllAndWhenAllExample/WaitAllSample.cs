using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitAllAndWhenAllExample
{
    internal class WaitAllSample
    {

        public async Task DoSomeWorkAsync()
        {
            Console.WriteLine($"DoSomeWorkAsync in WaitAll is starting.");
            await Task.Delay(4000); // Simulating some asynchronous work
            Console.WriteLine($"DoSomeWorkAsync in WaitAll is is done.");
        }

        public async Task DoSomeOtherWorkAsync()
        {
            Console.WriteLine($"DoSomeOtherWorkAsync in WaitAll is starting.");
            await Task.Delay(4000); // Simulating some asynchronous work
            Console.WriteLine($"DoSomeOtherWorkAsync in WaitAll is is done.");
        }
    }
}
