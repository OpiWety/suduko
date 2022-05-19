using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace i_dont_delete
{
    public class House
    {
        public House(List<Tile> tiles)
        {
            Tiles = tiles;
            
        }

        public void AddTile(Tile tile)
        {
            foreach (var t in Tiles)
            {
                if (tile.Number == t.Number)
                    return;

            }
            Tiles.Add(tile);
        }
        public List<Tile> Tiles { get; set; }
        
    }
}
