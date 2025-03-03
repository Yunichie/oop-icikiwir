namespace HelloWorld;
using HelloPrint;

class HelloWorld
{
    public static void Main()
    {
        var name = Console.ReadLine();
        HelloPrint print = new();
        // name ??= "World";
        print.SayHello(name);
    }
}