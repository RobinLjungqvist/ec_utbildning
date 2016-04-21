using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFromClassDiagram
{
    interface IPersonRegistry
    {
        void AddPerson(string num, string fName, string IName);
        bool HasPerson(string num);
        string FindPerson(string num);

        List<string> GetListWithNames();
    }
}
