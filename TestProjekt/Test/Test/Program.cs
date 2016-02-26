using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("< table >");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    sb.AppendLine("     <tr bgcolor=\"#CCCCCC\">"); 
                }
                else
                {
                    sb.AppendLine("     </tr>");
                }
                sb.AppendLine(string.Format("         <td>Row{0}</td>", i));
                for (int j = 0; j < 9; j++)
                {
                    sb.AppendLine("         <td>xxxxx<td>"); 
                }
                sb.AppendLine("     </tr>");
            }
            sb.AppendLine("< /table >");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
