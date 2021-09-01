using System;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool extended = false;

            PrinterClass PrinterObject = new PrinterClass();

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("Datatypes\n\n\rType something and see what datatypes it could be stored as! (Type 'EXTEND' to get more datatypes.)\n\r-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");

                if (input == "EXTEND")
                {
                    extended = !extended;
                }

                Console.SetCursorPosition(0, 7);
                PrinterObject.PrintTypes(input, extended);
                
                Console.SetCursorPosition(0, 5);
                Console.Write(">>> ");

                input = Console.ReadLine();
            }
        }
    }
}
