using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitAllAndWhenAllExample
{
    internal class WhenAllExample
    {

        public async Task DoSomethingAsync()
        {
            Console.WriteLine($"DoSomethingAsync in WhenAll is starting.");
            await Task.Delay(4000); // Simulating some asynchronous work
            Console.WriteLine($"DoSomethingAsync in WhenAll is is done.");
        }

        public async Task DoSomethingElseAsync()
        {
            Console.WriteLine($"DoSomethingElseAsync in WhenAll is starting.");
            await Task.Delay(4000); // Simulating some asynchronous work
            Console.WriteLine($"DoSomethingElseAsync in WhenAll is is done.");
        }
    }
}
