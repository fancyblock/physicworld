using System;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class MapEditor : Form
    {
        //-------------------------------------------- enmu define -----------------------------------------------

        enum EditorState
        {
            eNoChange,
            eCreateMap
        };


        //-------------------------------------------- data member -----------------------------------------------

        private MapData.Map m_curMap = null;
        private MapData.TileLibs m_cutTileLib = null;

        private string m_mapFile = null;
        private string m_tileLibsFile = null;

        //------------------------------------------- public function --------------------------------------------

        /**
         * @desc    constructor
         */
        public MapEditor()
        {
            InitializeComponent();
        }

        //------------------------------------------- private function --------------------------------------------

        /**
         * @desc    update ui
         */
        private void updateUI( EditorState state = EditorState.eNoChange )
        {
            switch (state)
            {
                case EditorState.eCreateMap:
                    //[unfinished]
                    break;
                case EditorState.eNoChange:
                default:
                    break;
            }
        }

        //--------------------------------------------- menu operation --------------------------------------------

        /**
         * @desc    Create new map
         */
        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorldEditor.Dialog.NewMap dlg = new Dialog.NewMap();

            dlg.Show();

            int posX = this.Bounds.Left + 250;
            int posY = this.Bounds.Top + 200;

            dlg.SetDesktopLocation( posX , posY );

            dlg.FormClosing += new System.Windows.Forms.FormClosingEventHandler(_onCreateMapDlgClose);
        }

        /**
         * @desc    Load exist map file
         */
        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadMapDlg.ShowDialog(this);

            //[unfinished]
        }

        /**
         * @desc    Save the map
         */
        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[unfinished]
        }

        /**
         * @desc    Exit the tool
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * @desc    about dialog
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[unfinished]
        }

        /**
         * @desc    load tile libs
         */
        private void loadTileLibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTileLibDlg.ShowDialog(this);

            //[unfinished]
        }

        /**
         * @desc    add tile to tile lib
         */
        private void newTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( openTileFileDlg.ShowDialog(this) == DialogResult.Cancel )
            {
                return;
            }

            if (openTileFileDlg.CheckPathExists == true)
            {
                openTileImg(openTileFileDlg.FileName);
            }

        }

        //------------------------------------------- event callback -----------------------------------------------

        //open tile image
        private void openTileImg(string fileName)
        {
            //[unfinished]
        }

        //call back when close the dlg
        private void _onCreateMapDlgClose(object sender, EventArgs e)
        {
            WorldEditor.Dialog.NewMap dlg = (WorldEditor.Dialog.NewMap)sender;

            if (dlg.IsValidSize() == true)
            {
                this.m_curMap = new MapData.Map();
                this.m_curMap.CreateMap(dlg.MAP_WIDTH, dlg.MAP_HEIGHT);

                updateUI(EditorState.eCreateMap);
            }
        }

    }
}
