using MotoApp;
var stack = new BasicStack<double>();

stack.Push(item: 4.5);
stack.Push(item: 43);
stack.Push(item: 333);

var stackString = new BasicStack<string>();
stackString.Push(item: "Company");
stackString.Push(item: "Company");
stackString.Push(item: "Company");


double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");