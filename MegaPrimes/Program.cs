
namespace MegaPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MegaPrimesLogic.GetMegaPrimes(10).First().ToString());
        }
    }
}
