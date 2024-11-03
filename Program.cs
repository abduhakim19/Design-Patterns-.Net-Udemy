

using Design_Patterns;
using Design_Patterns.Builder;
using Design_Patterns.SOLID;

internal class Program
{
    private static void Main(string[] args)
    {
        //SingleResponsibility solid = new SingleResponsibility();
        //OpenClosed openClosed = new OpenClosed();
        //Liskov liskov = new Liskov();
        //InterfaceSegregation interfaceS = new InterfaceSegregation();
        Builder b = new Builder();

        b.Run();
    }
}