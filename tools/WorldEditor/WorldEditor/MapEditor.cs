using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class MapEditor : Form
    {
        public MapEditor()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /**
         * @desc    Create new map
         */
        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorldEditor.Dialog.NewMap dlg = new Dialog.NewMap();

            dlg.Show();
            
            //[unfinished]
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /**
         * @desc    Exit the tool
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
