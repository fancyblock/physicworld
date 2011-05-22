namespace WorldEditor
{
    partial class MapEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Map = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Map = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTileLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvaMap = new System.Windows.Forms.PictureBox();
            this.mapProperty = new System.Windows.Forms.GroupBox();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tileCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMapHeight = new System.Windows.Forms.TextBox();
            this.txtMapWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canvaTile = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTileKeyPoint = new System.Windows.Forms.TextBox();
            this.txtTileFileSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetTile = new System.Windows.Forms.Button();
            this.listTiles = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openTileLibDlg = new System.Windows.Forms.OpenFileDialog();
            this.openTileFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.loadMapDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveMapDlg = new System.Windows.Forms.SaveFileDialog();
            this.Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvaMap)).BeginInit();
            this.mapProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvaTile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Map,
            this.tileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(784, 24);
            this.Map.TabIndex = 0;
            this.Map.Text = "menuStrip1";
            // 
            // MenuItem_Map
            // 
            this.MenuItem_Map.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.loadMapToolStripMenuItem,
            this.saveMapToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.MenuItem_Map.Name = "MenuItem_Map";
            this.MenuItem_Map.Size = new System.Drawing.Size(43, 20);
            this.MenuItem_Map.Text = "Map";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newMapToolStripMenuItem.Text = "New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadMapToolStripMenuItem.Text = "Load Map";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveMapToolStripMenuItem.Text = "Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTileToolStripMenuItem,
            this.loadTileLibToolStripMenuItem,
            this.saveTilesToolStripMenuItem});
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.tileToolStripMenuItem.Text = "Tile";
            // 
            // newTileToolStripMenuItem
            // 
            this.newTileToolStripMenuItem.Name = "newTileToolStripMenuItem";
            this.newTileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newTileToolStripMenuItem.Text = "Add Tile";
            this.newTileToolStripMenuItem.Click += new System.EventHandler(this.newTileToolStripMenuItem_Click);
            // 
            // loadTileLibToolStripMenuItem
            // 
            this.loadTileLibToolStripMenuItem.Name = "loadTileLibToolStripMenuItem";
            this.loadTileLibToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadTileLibToolStripMenuItem.Text = "Load Tile Lib";
            this.loadTileLibToolStripMenuItem.Click += new System.EventHandler(this.loadTileLibToolStripMenuItem_Click);
            // 
            // saveTilesToolStripMenuItem
            // 
            this.saveTilesToolStripMenuItem.Name = "saveTilesToolStripMenuItem";
            this.saveTilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveTilesToolStripMenuItem.Text = "Save Tiles";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // canvaMap
            // 
            this.canvaMap.BackColor = System.Drawing.Color.Black;
            this.canvaMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvaMap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.canvaMap.ErrorImage = null;
            this.canvaMap.InitialImage = null;
            this.canvaMap.Location = new System.Drawing.Point(292, 27);
            this.canvaMap.Name = "canvaMap";
            this.canvaMap.Size = new System.Drawing.Size(480, 320);
            this.canvaMap.TabIndex = 1;
            this.canvaMap.TabStop = false;
            // 
            // mapProperty
            // 
            this.mapProperty.Controls.Add(this.btnClearMap);
            this.mapProperty.Controls.Add(this.btnPreview);
            this.mapProperty.Controls.Add(this.tileCount);
            this.mapProperty.Controls.Add(this.label3);
            this.mapProperty.Controls.Add(this.txtMapHeight);
            this.mapProperty.Controls.Add(this.txtMapWidth);
            this.mapProperty.Controls.Add(this.label2);
            this.mapProperty.Controls.Add(this.label1);
            this.mapProperty.Location = new System.Drawing.Point(8, 35);
            this.mapProperty.Name = "mapProperty";
            this.mapProperty.Size = new System.Drawing.Size(276, 312);
            this.mapProperty.TabIndex = 2;
            this.mapProperty.TabStop = false;
            this.mapProperty.Text = "Map Options";
            // 
            // btnClearMap
            // 
            this.btnClearMap.Enabled = false;
            this.btnClearMap.Location = new System.Drawing.Point(100, 270);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(75, 36);
            this.btnClearMap.TabIndex = 7;
            this.btnClearMap.Text = "Clear";
            this.btnClearMap.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(182, 270);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 36);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // tileCount
            // 
            this.tileCount.Enabled = false;
            this.tileCount.Location = new System.Drawing.Point(100, 86);
            this.tileCount.Name = "tileCount";
            this.tileCount.Size = new System.Drawing.Size(157, 21);
            this.tileCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tile Count";
            // 
            // txtMapHeight
            // 
            this.txtMapHeight.Enabled = false;
            this.txtMapHeight.Location = new System.Drawing.Point(100, 56);
            this.txtMapHeight.Name = "txtMapHeight";
            this.txtMapHeight.Size = new System.Drawing.Size(157, 21);
            this.txtMapHeight.TabIndex = 3;
            // 
            // txtMapWidth
            // 
            this.txtMapWidth.Enabled = false;
            this.txtMapWidth.Location = new System.Drawing.Point(100, 30);
            this.txtMapWidth.Name = "txtMapWidth";
            this.txtMapWidth.Size = new System.Drawing.Size(157, 21);
            this.txtMapWidth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // canvaTile
            // 
            this.canvaTile.BackColor = System.Drawing.Color.DimGray;
            this.canvaTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvaTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.canvaTile.ErrorImage = null;
            this.canvaTile.InitialImage = null;
            this.canvaTile.Location = new System.Drawing.Point(8, 363);
            this.canvaTile.Name = "canvaTile";
            this.canvaTile.Size = new System.Drawing.Size(256, 256);
            this.canvaTile.TabIndex = 3;
            this.canvaTile.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTileKeyPoint);
            this.groupBox1.Controls.Add(this.txtTileFileSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnResetTile);
            this.groupBox1.Location = new System.Drawing.Point(8, 625);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tile";
            // 
            // txtTileKeyPoint
            // 
            this.txtTileKeyPoint.Enabled = false;
            this.txtTileKeyPoint.Location = new System.Drawing.Point(79, 52);
            this.txtTileKeyPoint.Name = "txtTileKeyPoint";
            this.txtTileKeyPoint.Size = new System.Drawing.Size(108, 21);
            this.txtTileKeyPoint.TabIndex = 13;
            // 
            // txtTileFileSize
            // 
            this.txtTileFileSize.Enabled = false;
            this.txtTileFileSize.Location = new System.Drawing.Point(79, 26);
            this.txtTileFileSize.Name = "txtTileFileSize";
            this.txtTileFileSize.Size = new System.Drawing.Size(108, 21);
            this.txtTileFileSize.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "KeyPoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "FileSize";
            // 
            // btnResetTile
            // 
            this.btnResetTile.Enabled = false;
            this.btnResetTile.Location = new System.Drawing.Point(199, 17);
            this.btnResetTile.Name = "btnResetTile";
            this.btnResetTile.Size = new System.Drawing.Size(50, 61);
            this.btnResetTile.TabIndex = 9;
            this.btnResetTile.Text = "Reset";
            this.btnResetTile.UseVisualStyleBackColor = true;
            // 
            // listTiles
            // 
            this.listTiles.FormattingEnabled = true;
            this.listTiles.ItemHeight = 12;
            this.listTiles.Location = new System.Drawing.Point(270, 383);
            this.listTiles.Name = "listTiles";
            this.listTiles.Size = new System.Drawing.Size(133, 328);
            this.listTiles.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiles";
            // 
            // openTileLibDlg
            // 
            this.openTileLibDlg.FileName = "Ope Tile Lib";
            // 
            // openTileFileDlg
            // 
            this.openTileFileDlg.DefaultExt = "*.png";
            this.openTileFileDlg.Filter = "*.png|*.png";
            this.openTileFileDlg.Title = "Ope Tile File";
            // 
            // loadMapDlg
            // 
            this.loadMapDlg.FileName = "Load Map";
            // 
            // MapEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 722);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listTiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvaTile);
            this.Controls.Add(this.mapProperty);
            this.Controls.Add(this.canvaMap);
            this.Controls.Add(this.Map);
            this.MainMenuStrip = this.Map;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 760);
            this.MinimumSize = new System.Drawing.Size(800, 760);
            this.Name = "MapEditor";
            this.Text = "MapEditor";
            this.Map.ResumeLayout(false);
            this.Map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvaMap)).EndInit();
            this.mapProperty.ResumeLayout(false);
            this.mapProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvaTile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Map;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Map;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox canvaMap;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTileToolStripMenuItem;
        private System.Windows.Forms.GroupBox mapProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMapHeight;
        private System.Windows.Forms.TextBox txtMapWidth;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox tileCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearMap;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ToolStripMenuItem loadTileLibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTilesToolStripMenuItem;
        private System.Windows.Forms.PictureBox canvaTile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetTile;
        private System.Windows.Forms.TextBox txtTileKeyPoint;
        private System.Windows.Forms.TextBox txtTileFileSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listTiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openTileLibDlg;
        private System.Windows.Forms.OpenFileDialog openTileFileDlg;
        private System.Windows.Forms.OpenFileDialog loadMapDlg;
        private System.Windows.Forms.SaveFileDialog saveMapDlg;
    }
}

