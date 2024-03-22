using DesignPatterns.Iterator;

var list = new CustomList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
var iterator = list.Iterator;

while (!iterator.Complete)
{
    var n = iterator.Next();
    Console.WriteLine(n);
}
