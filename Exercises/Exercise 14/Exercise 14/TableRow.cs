using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class TableRow
    {
        private List<TableCell> _tableCellList;

        public int _Count
        {
            get
            {
                return _tableCellList.Count;
            }
        }

        public TableRow(TableCell tableCell)
        {
            _tableCellList = new List<TableCell>();
            _tableCellList.Add(tableCell);
        }
        public void AddCell(TableCell cell)
        {
            _tableCellList.Add(cell);
        }
        public string GetAllCells()
        {
            var allCells = string.Empty;
            foreach (var Cell in _tableCellList)
            {
                allCells += Cell.ToString();
            }
            return allCells;
        }

        public override string ToString()
        {
            return $"<tr>{GetAllCells()}</tr>";

        }

    }
}
