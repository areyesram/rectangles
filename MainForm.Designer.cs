namespace areyesram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnRandom = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMethod = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuMethod1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMethod2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMethod3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.tabPoints = new System.Windows.Forms.TabPage();
            this.gridPoints = new System.Windows.Forms.DataGridView();
            this.tabRectangles = new System.Windows.Forms.TabPage();
            this.gridRectangles = new System.Windows.Forms.DataGridView();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.tabPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.tabRectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRectangles)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 443);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(527, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(512, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnRandom,
            this.btnLoad,
            this.toolStripSeparator1,
            this.mnuMethod,
            this.btnFind,
            this.toolStripSeparator2,
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(527, 39);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "mnuSetup";
            // 
            // btnRandom
            // 
            this.btnRandom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRandom.Image = ((System.Drawing.Image)(resources.GetObject("btnRandom.Image")));
            this.btnRandom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(36, 36);
            this.btnRandom.Text = "Random";
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(36, 36);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 39);
            // 
            // mnuMethod
            // 
            this.mnuMethod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuMethod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMethod1,
            this.mnuMethod2,
            this.mnuMethod3});
            this.mnuMethod.Image = global::areyesram.Properties.Resources.m1;
            this.mnuMethod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMethod.Name = "mnuMethod";
            this.mnuMethod.ShowDropDownArrow = false;
            this.mnuMethod.Size = new System.Drawing.Size(36, 36);
            this.mnuMethod.Text = "toolStripDropDownButton1";
            this.mnuMethod.ToolTipText = "Método";
            // 
            // mnuMethod1
            // 
            this.mnuMethod1.Name = "mnuMethod1";
            this.mnuMethod1.Size = new System.Drawing.Size(152, 22);
            this.mnuMethod1.Tag = "1";
            this.mnuMethod1.Text = "Método 1";
            // 
            // mnuMethod2
            // 
            this.mnuMethod2.Name = "mnuMethod2";
            this.mnuMethod2.Size = new System.Drawing.Size(152, 22);
            this.mnuMethod2.Tag = "2";
            this.mnuMethod2.Text = "Método 2";
            // 
            // mnuMethod3
            // 
            this.mnuMethod3.Name = "mnuMethod3";
            this.mnuMethod3.Size = new System.Drawing.Size(152, 22);
            this.mnuMethod3.Tag = "3";
            this.mnuMethod3.Text = "Método 3";
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(36, 36);
            this.btnFind.Text = "toolStripButton1";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(20, 39);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(36, 36);
            this.btnExport.Text = "toolStripButton1";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabGraph);
            this.tabControl1.Controls.Add(this.tabPoints);
            this.tabControl1.Controls.Add(this.tabRectangles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 404);
            this.tabControl1.TabIndex = 8;
            // 
            // tabGraph
            // 
            this.tabGraph.AutoScroll = true;
            this.tabGraph.Controls.Add(this.picCanvas);
            this.tabGraph.Location = new System.Drawing.Point(4, 25);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(519, 375);
            this.tabGraph.TabIndex = 0;
            this.tabGraph.Text = "Gráfica";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(3, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(513, 489);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // tabPoints
            // 
            this.tabPoints.Controls.Add(this.gridPoints);
            this.tabPoints.Location = new System.Drawing.Point(4, 25);
            this.tabPoints.Name = "tabPoints";
            this.tabPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoints.Size = new System.Drawing.Size(519, 375);
            this.tabPoints.TabIndex = 1;
            this.tabPoints.Text = "Puntos";
            this.tabPoints.UseVisualStyleBackColor = true;
            // 
            // gridPoints
            // 
            this.gridPoints.BackgroundColor = System.Drawing.Color.White;
            this.gridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPoints.Location = new System.Drawing.Point(3, 3);
            this.gridPoints.Name = "gridPoints";
            this.gridPoints.ReadOnly = true;
            this.gridPoints.Size = new System.Drawing.Size(513, 369);
            this.gridPoints.TabIndex = 0;
            // 
            // tabRectangles
            // 
            this.tabRectangles.Controls.Add(this.gridRectangles);
            this.tabRectangles.Location = new System.Drawing.Point(4, 25);
            this.tabRectangles.Name = "tabRectangles";
            this.tabRectangles.Size = new System.Drawing.Size(519, 375);
            this.tabRectangles.TabIndex = 2;
            this.tabRectangles.Text = "Rectángulos";
            this.tabRectangles.UseVisualStyleBackColor = true;
            // 
            // gridRectangles
            // 
            this.gridRectangles.BackgroundColor = System.Drawing.Color.White;
            this.gridRectangles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRectangles.Location = new System.Drawing.Point(0, 0);
            this.gridRectangles.Name = "gridRectangles";
            this.gridRectangles.ReadOnly = true;
            this.gridRectangles.Size = new System.Drawing.Size(519, 375);
            this.gridRectangles.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 465);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "Rectángulos";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.tabPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.tabRectangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRectangles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRandom;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TabPage tabPoints;
        private System.Windows.Forms.DataGridView gridPoints;
        private System.Windows.Forms.TabPage tabRectangles;
        private System.Windows.Forms.DataGridView gridRectangles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton mnuMethod;
        private System.Windows.Forms.ToolStripMenuItem mnuMethod1;
        private System.Windows.Forms.ToolStripMenuItem mnuMethod2;
        private System.Windows.Forms.ToolStripMenuItem mnuMethod3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}