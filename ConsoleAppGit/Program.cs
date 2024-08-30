using System.Runtime.InteropServices;

namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emil.printLine("For loops: 1 /");
            Emil.print("Pick: ");
            int x = Convert.ToInt32(Console.ReadLine()!);

            switch(x)
            {
                default:
                    break;

                case 1:
                    forLoops();
                    break;
            }
        }

        static void forLoops()
        {   
            for(int i = 1; i <= 10; i++)
            {
                Emil.print($"{i} ");
            }
        }
    }
}
