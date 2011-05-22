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
    class MapTile
    {
        //enum flag
        static public int FLAG_FREE = 1;
        static public int FLAG_ON_MAP = 2;
        static public int FLAG_DEL = 3;

        //id of this tile
        private int m_id;

        //flag of this tile
        private int m_flag;

        //type of the tile
        private string m_type = "";

        /**
         * @desc    constructor
         */
        public MapTile()
        {
            m_id = -1;
            m_flag = FLAG_FREE;
        }

        //access this id
        public int ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        //access the flage
        public int FLAG
        {
            get
            {
                return m_flag;
            }
            set
            {
                m_flag = value;
            }
        }

        //access the type
        public string TYPE
        {
            get
            {
                return m_type;
            }
        }

    }
}
