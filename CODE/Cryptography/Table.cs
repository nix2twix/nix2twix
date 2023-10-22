using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class Table
    {
        private int rowCount;
        private int columnCount;
        private List<byte[]> sourceTable;
        public Table(int rows, int columns)
        {
            sourceTable = new List<byte[]>(rows);
            for (int i = 0; i < rows; i++)
            {
                sourceTable.Add(new byte[columns]);
            }
        }

        public int RowCount
        {
            get
            {
                return rowCount;
            }
            set 
            { 
                rowCount = value; 
            }
        }

        public int ColumnCount
        {
            get
            {
                return columnCount;
            }
            set
            {
                columnCount = value;
            }
        }

        public List<byte[]> SourceTable
        {
            get 
            { 
                return sourceTable; 
            }
            set 
            { 
                sourceTable = value; 
            }
        }
    }
}
