using SOLID_Principles;
using SOLID_Principles.DependencyInversion;
using SOLID_Principles.InterfaceSegregation;
using SOLID_Principles.Liskov;
using SOLID_Principles.OpenClosed;
using SOLID_Principles.SingleResponsibility;


namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Principles:");

            var principles = new List<IPrinciple>()
            {
                new Srp(),
                new Ocp(),
                new Lsp(),
                new Isp(),
                new Dip()
            };
            principles.ForEach(type =>
            {
                Console.WriteLine($"- {type.Principle()}");
            });
            Console.Read();
        }
    }
}