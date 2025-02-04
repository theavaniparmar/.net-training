using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPexample
{
    //advanced printer 
    interface Print { void Print(string text); }
    interface Scan { void Scan(string text); }
    interface Fax { void Fax(string text); }

    public class BasePrinter : Print
    {
        public void Print(string t)
        {

            Console.WriteLine($"\nprinting...{t}");
        }
    }
    public class AdvancedPrinter : Print, Scan, Fax
    {
        public void Print(string t) { Console.WriteLine($"\nprinting...{t}"); }
        public void Scan(string t) { Console.WriteLine($"\nscanning...{t}"); }
        public void Fax(string t) { Console.WriteLine($"\nFax the Document.....{t}"); }


    }
    public class ScanningDevice : Scan
    {
        public void Scan(string t) { Console.WriteLine($"\nscanning...{t}"); }
    }

    public class FaxDevice : Fax
    {
        public void Fax(string t) { Console.WriteLine($"fax the document...{t}"); }
        class Program
        {
            static void Main(string[] args)
            {
                BasePrinter basePrinter = new BasePrinter();
                Console.WriteLine("Base printer task:");
                basePrinter.Print("Avani");

                AdvancedPrinter advancedPrinter = new AdvancedPrinter();
                Console.WriteLine("\n\nAdvanced  printer task:");
                advancedPrinter.Print("doc1");
                advancedPrinter.Scan("copy");
                advancedPrinter.Fax("email");

                ScanningDevice scanningDevice = new ScanningDevice();
                Console.WriteLine("\n\nscanning device task:");
                scanningDevice.Scan("copy2");

                FaxDevice faxDevice = new FaxDevice();
                Console.WriteLine("\n\nFax machine task:");
                faxDevice.Fax("email or message");

                Console.ReadKey();



            }
        }
    }
}
