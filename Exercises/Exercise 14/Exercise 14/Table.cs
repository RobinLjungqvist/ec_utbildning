using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Table
    {
        List<TableRow> _trList;

        public Table(TableRow tableRow)
        {
            _trList = new List<TableRow>();
            _trList.Add(tableRow);
        }
        public Table()
        {
            _trList = new List<TableRow>();
        }
        public void AddRow(TableRow tableRow)
        {
            _trList.Add(tableRow);

            var highestNrOfCells = 0;
            foreach (var row in _trList)
            {
                if(row._Count > highestNrOfCells)
                {
                    highestNrOfCells = row._Count;
                }
            }

            foreach (var row in _trList)
            {
                while(row._Count < highestNrOfCells)
                {
                    var emptyCell = new TableCell("");
                    row.AddCell(emptyCell);
                }
            }

        }
        private string getTableRows()
        {
            var allRows = string.Empty;
            foreach (var row in _trList)
            {
                allRows += row.ToString();
            }
            return allRows;
        }

        public override string ToString()
        {
            return $"<table>{getTableRows()}</table>";
        }
    }
}
