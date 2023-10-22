// See https://aka.ms/new-console-template for more information
using WaitAllAndWhenAllExample;

Console.WriteLine("Example of WaitAll");

await PerformMultipleOperationFromWaitllAsync();

Console.WriteLine("example of whenall");

await PerformMultipleOperationFromWhenAllAsync();



async Task PerformMultipleOperationFromWhenAllAsync()
{
    WhenAllExample whenallexample = new WhenAllExample();
    Task task3 = whenallexample.DoSomethingAsync();
    Task task4 = whenallexample.DoSomethingElseAsync();
    await Task.WhenAll(task3, task4);
    Console.WriteLine("All tasks in WhenAll are complete!");
}

async Task PerformMultipleOperationFromWaitllAsync()
{
    WaitAllSample waitAllSample = new WaitAllSample();
    Task task1 = waitAllSample.DoSomeWorkAsync();
    Task task2 = waitAllSample.DoSomeOtherWorkAsync();
    Task.WaitAll(task1, task2);
    Console.WriteLine("All tasks in WaitAll are complete!");

}






