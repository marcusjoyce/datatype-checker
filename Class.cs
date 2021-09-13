using System;

namespace Datatype
{
    class PrinterClass
    {
        public void Print(bool parsed, bool bestFit, string datatype)
        {
            if (bestFit && parsed)
            {
                Console.Write("+");
            } else {
                Console.Write(" ");
            }
            if (parsed)
            {
                Console.Write("+ ");
            } else {
                Console.Write("- ");
            }
            Console.WriteLine(datatype);
        }


        public void PrintTypes(string input, bool extended)
        {
            bool success;
            bool foundBestFit = false;

            if (extended)
            {
                success = byte.TryParse(input, out _);
                Print(success, !foundBestFit, "Unsigned Byte");
                if (success) { foundBestFit = true; }

                success = SByte.TryParse(input, out _);
                Print(success, !foundBestFit, "Signed Byte");
                if (success) { foundBestFit = true; }

                success = UInt16.TryParse(input, out _);
                Print(success, !foundBestFit, "Unsigned Short");
                if (success) { foundBestFit = true; }

                success = Int16.TryParse(input, out _);
                Print(success, !foundBestFit, "Short");
                if (success) { foundBestFit = true; }

                success = UInt32.TryParse(input, out _);
                Print(success, !foundBestFit, "Unsigned Integer");
                if (success) { foundBestFit = true; }
            }

            success = Int32.TryParse(input, out _);
            Print(success, !foundBestFit, "Integer");
            if (success) { foundBestFit = true; }

            if (extended)
            {
                success = UInt64.TryParse(input, out _);
                Print(success, !foundBestFit, "Unsigned Long");
                if (success) { foundBestFit = true; }

                success = Int64.TryParse(input, out _);
                Print(success, !foundBestFit, "Long");
                if (success) { foundBestFit = true; }
            }

            success = float.TryParse(input.Replace(".", ","), out _);
            Print(success, !foundBestFit, "Float");
            if (success) { foundBestFit = true; }

            if (extended)
            {
                success = double.TryParse(input.Replace(".", ","), out _);
                Print(success, !foundBestFit, "Double");
                if (success) { foundBestFit = true; }

                success = decimal.TryParse(input.Replace(".", ","), out _);
                Print(success, !foundBestFit, "Decimal");
                if (success) { foundBestFit = true; }

                success = char.TryParse(input, out _);
                Print(success, !foundBestFit, "Character");
                if (success) { foundBestFit = true; }
            }

            success = bool.TryParse(input, out _);
            Print(success, !foundBestFit, "Boolean");
            if (success) { foundBestFit = true; }

            Print(true, !foundBestFit, "String");
        }
    }
}
