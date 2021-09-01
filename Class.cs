using System;
using System.Globalization;

namespace Datatype
{
    class PrinterClass
    {
        public void PrintTypes(string input, bool extended)
        {
            // change standard decimal seperator to "." instead of ","
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";

            try { Int32.Parse(input); Console.WriteLine(" + Integer"); } catch (System.FormatException) { Console.WriteLine(" - Integer"); } catch (System.OverflowException) { Console.WriteLine(" - Integer"); }
            try { input.ToString(); Console.WriteLine(" + String"); } catch (System.FormatException) { Console.WriteLine(" - String"); }
            try { bool.Parse(input); Console.WriteLine(" + Boolean"); } catch (System.FormatException) { Console.WriteLine(" - Boolean"); }
            try { float.Parse(input, NumberStyles.Any, ci); Console.WriteLine(" + Float"); } catch (System.FormatException) { Console.WriteLine(" - Float"); } catch (System.OverflowException) { Console.WriteLine(" - Float"); }

            if (extended)
            {
                try { char.Parse(input); Console.WriteLine(" + Character"); } catch (System.FormatException) { Console.WriteLine(" - Character"); }
                try { double.Parse(input, NumberStyles.Any, ci); Console.WriteLine(" + Double"); } catch (System.FormatException) { Console.WriteLine(" - Double"); } catch (System.OverflowException) { Console.WriteLine(" - Double"); }
                try { decimal.Parse(input, NumberStyles.Any, ci); Console.WriteLine(" + Decimal"); } catch (System.FormatException) { Console.WriteLine(" - Decimal"); } catch (System.OverflowException) { Console.WriteLine(" - Decimal"); }
                try { Int64.Parse(input); Console.WriteLine(" + Long"); } catch (System.FormatException) { Console.WriteLine(" - Long"); } catch (System.OverflowException) { Console.WriteLine(" - Long"); }
                try { Int16.Parse(input); Console.WriteLine(" + Short"); } catch (System.FormatException) { Console.WriteLine(" - Short"); } catch (System.OverflowException) { Console.WriteLine(" - Short"); }
                try { UInt32.Parse(input); Console.WriteLine(" + Unsigned Integer"); } catch (System.FormatException) { Console.WriteLine(" - Unsigned Integer"); } catch (System.OverflowException) { Console.WriteLine(" - Unsigned Integer"); }
                try { UInt64.Parse(input); Console.WriteLine(" + Unsigned Long"); } catch (System.FormatException) { Console.WriteLine(" - Unsigned Long"); } catch (System.OverflowException) { Console.WriteLine(" - Unsigned Long"); }
                try { UInt16.Parse(input); Console.WriteLine(" + Unsigned Short"); } catch (System.FormatException) { Console.WriteLine(" - Unsigned Short"); } catch (System.OverflowException) { Console.WriteLine(" - Unsigned Short"); }
                try { byte.Parse(input); Console.WriteLine(" + Unsigned Byte"); } catch (System.FormatException) { Console.WriteLine(" - Unsigned Byte"); } catch (System.OverflowException) { Console.WriteLine(" - Unsigned Byte"); }
                try { SByte.Parse(input); Console.WriteLine(" + Signed Byte"); } catch (System.FormatException) { Console.WriteLine(" - Signed Byte"); } catch (System.OverflowException) { Console.WriteLine(" - Signed Byte"); }
            }
        }
    }
}
