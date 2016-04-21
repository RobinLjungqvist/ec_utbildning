using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class TableCell
    {
        public string _Content { get; set; }

        public TableCell(string Content)
        {
            this._Content = Content;
        }
        public override string ToString()
        {
            return string.Format($"<td>{_Content}</td>");

        }
    }
}
