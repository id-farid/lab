async Task<string> OrderPizza()
{
    Console.WriteLine("Ordering pizza...");
    await Task.Delay(5000);
    return "Pizza delivered";
}

async Task MkeDinner()
{ 
      string status = await OrderPizza();
      Console.WriteLine(status);
      Console.WriteLine("Dinner is ready");
}

await MkeDinner();
Console.WriteLine("Other tasks are running beside async call");
