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
            this.btnRandom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.tabPoints = new System.Windows.Forms.TabPage();
            this.gridPoints = new System.Windows.Forms.DataGridView();
            this.tabRectangles = new System.Windows.Forms.TabPage();
            this.gridRectangles = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.tabPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.tabRectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRectangles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 12);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabGraph);
            this.tabControl1.Controls.Add(this.tabPoints);
            this.tabControl1.Controls.Add(this.tabRectangles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 524);
            this.tabControl1.TabIndex = 2;
            // 
            // tabGraph
            // 
            this.tabGraph.AutoScroll = true;
            this.tabGraph.Controls.Add(this.picCanvas);
            this.tabGraph.Location = new System.Drawing.Point(4, 25);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(519, 495);
            this.tabGraph.TabIndex = 0;
            this.tabGraph.Text = "Gráfica";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // tabPoints
            // 
            this.tabPoints.Controls.Add(this.gridPoints);
            this.tabPoints.Location = new System.Drawing.Point(4, 25);
            this.tabPoints.Name = "tabPoints";
            this.tabPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoints.Size = new System.Drawing.Size(519, 495);
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
            this.gridPoints.Size = new System.Drawing.Size(513, 489);
            this.gridPoints.TabIndex = 0;
            // 
            // tabRectangles
            // 
            this.tabRectangles.Controls.Add(this.gridRectangles);
            this.tabRectangles.Location = new System.Drawing.Point(4, 25);
            this.tabRectangles.Name = "tabRectangles";
            this.tabRectangles.Size = new System.Drawing.Size(519, 495);
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
            this.gridRectangles.Size = new System.Drawing.Size(519, 495);
            this.gridRectangles.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(93, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(174, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 571);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRandom);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 47, 0, 0);
            this.Text = "Rectángulos";
            this.tabControl1.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabGraph.PerformLayout();
            this.tabPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.tabRectangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRectangles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabPoints;
        private System.Windows.Forms.TabPage tabRectangles;
        private System.Windows.Forms.DataGridView gridPoints;
        private System.Windows.Forms.DataGridView gridRectangles;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnExport;
    }
}