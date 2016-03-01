using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var TBC = new TableCell("Hallå ja!");
            var messageNamn = new TableCell("Mitt namn är Robin.");
            var messageSkola = new TableCell("Jag går på EC utbildning i helsingborg");

            var TBR = new TableRow(TBC);
            TBR.AddCell(messageNamn);
            TBR.AddCell(messageSkola);

            var TBR1 = new TableRow(TBC);
            var TBR2 = new TableRow(TBC);
            var TBR3 = new TableRow(TBC);
            var Tab = new Table(TBR);
            Tab.AddRow(TBR1);
            Tab.AddRow(TBR2);
            Tab.AddRow(TBR3);
            var message = Tab.ToString();
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
