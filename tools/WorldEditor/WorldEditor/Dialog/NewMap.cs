using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldEditor.Dialog
{
    public partial class NewMap : Form
    {
        private int m_sizeWid = 0;
        private int m_sizeHei = 0;

        public NewMap()
        {
            InitializeComponent();
        }

        /**
         * desc 
         */
        public int MAP_WIDTH
        {
            get
            {
                return m_sizeWid;
            }
            set
            {
                m_sizeWid = value;
            }
        }

        /**
         * @desc
         */
        public int MAP_HEIGHT
        {
            get
            {
                return m_sizeHei;
            }
            set
            {
                m_sizeHei = value;
            }
        }

        /**
         * @desc    judge if the input value is valid
         */
        public bool IsValidSize()
        {
            if (m_sizeWid > 0 && m_sizeHei > 0)
            {
                return true;
            }

            return false;
        }

        /**
         * @desc    create a new map
         */
        private void btnOk_Click(object sender, EventArgs e)
        {
            if( this.txtMapHeight.Text == "" || this.txtMapWidth.Text == "" )
            {
                return;
            }

            int hei = int.Parse( this.txtMapHeight.Text );
            int wid = int.Parse( this.txtMapWidth.Text );

            if (hei > 0 && wid > 0)
            {
                m_sizeWid = wid;
                m_sizeHei = hei;

                this.Close();
            }

            this.txtInfo.Text = "Invalide Size";
        }

        //---------------------------------- only allow number be type to the inputbox ------------------------------------

        private string m_tmpWid;
        private string m_tmpHei;

        private void txtMapWidth_TextChanged(object sender, EventArgs e)
        {
            int tmp;

            if (int.TryParse(this.txtMapWidth.Text, out tmp) == false)
            {
                txtMapWidth.Text = m_tmpWid;
                txtMapWidth.SelectionStart = txtMapWidth.Text.Length;
            }

            m_tmpWid = txtMapWidth.Text;

        }

        private void txtMapHeight_TextChanged(object sender, EventArgs e)
        {
            int tmp;

            if (int.TryParse(this.txtMapHeight.Text, out tmp) == false)
            {
                txtMapHeight.Text = m_tmpHei;
                txtMapHeight.SelectionStart = txtMapHeight.Text.Length;
            }

            m_tmpHei = txtMapHeight.Text;
        }
    }
}
