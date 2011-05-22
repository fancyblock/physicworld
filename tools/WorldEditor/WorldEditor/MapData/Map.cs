using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldEditor.MapData
{
    /**
     * @desc    
     * @author  Hejiabin
     * @date    2011.05.15
     */
    class Map
    {
        //const define
        static public uint MAX_TILES = 200;

        //quantity of tiles in this map
        private int m_tileCount;

        //store all the tiles
        private MapTile []m_tiles;

        //map size
        private int m_mapWidth;
        private int m_mapHeight;

        /**
         * @desc    constructor
         */
        public Map()
        {
            m_tileCount = 0;
            m_tiles = new MapTile[MAX_TILES];

            m_mapWidth = 0;
            m_mapHeight = 0;
        }

        /**
         * @desc    create the map
         */
        public void CreateMap(int wid, int hei)
        {
            m_mapWidth = wid;
            m_mapHeight = hei;
        }

        /**
         * @desc    get map size
         */
        public int MAP_WID
        {
            get
            {
                return m_mapWidth;
            }
        }
        public int MAP_HEI
        {
            get
            {
                return m_mapHeight;
            }
        }

        /**
         * @desc    add a tile to the map
         */
        public bool AddTile(MapTile tile)
        {
            if (m_tiles.Length > MAX_TILES)
            {
                return false;
            }

            m_tiles[m_tileCount] = tile;
            tile.ID = m_tileCount;
            m_tileCount++;

            return true;
        }

        /**
         * @desc    delete a tile from the map
         */
        public bool DeleteTile(int id)
        {
            MapTile tile = m_tiles[id];

            if (tile == null)
            {
                return false;
            }

            tile.FLAG = MapTile.FLAG_DEL;

            spaceArrangement();

            return true;
        }

        /**
         * @desc    arrange space
         */
        private void spaceArrangement()
        {
            //[unfinished]
        }
    }
}
