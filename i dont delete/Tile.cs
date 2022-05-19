using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_dont_delete
{
    public class Tile
    {
        public Tile(int number, int row, int col)
        {
            Number = number;
            Row = row;
            Col = col;
        }

        public int Number { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
