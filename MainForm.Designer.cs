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
            this.btnGo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tabPoints = new System.Windows.Forms.TabPage();
            this.gridPoints = new System.Windows.Forms.DataGridView();
            this.tabRectangles = new System.Windows.Forms.TabPage();
            this.gridRectangles = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.tabPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.tabRectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRectangles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabGraph);
            this.tabControl1.Controls.Add(this.tabPoints);
            this.tabControl1.Controls.Add(this.tabRectangles);
            this.tabControl1.Location = new System.Drawing.Point(3, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 518);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.pnlCanvas);
            this.tabGraph.Location = new System.Drawing.Point(4, 25);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(504, 489);
            this.tabGraph.TabIndex = 0;
            this.tabGraph.Text = "Gráfica";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Location = new System.Drawing.Point(4, 2);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(500, 500);
            this.pnlCanvas.TabIndex = 1;
            // 
            // tabPoints
            // 
            this.tabPoints.Controls.Add(this.gridPoints);
            this.tabPoints.Location = new System.Drawing.Point(4, 25);
            this.tabPoints.Name = "tabPoints";
            this.tabPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoints.Size = new System.Drawing.Size(504, 475);
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
            this.gridPoints.Size = new System.Drawing.Size(498, 469);
            this.gridPoints.TabIndex = 0;
            // 
            // tabRectangles
            // 
            this.tabRectangles.Controls.Add(this.gridRectangles);
            this.tabRectangles.Location = new System.Drawing.Point(4, 25);
            this.tabRectangles.Name = "tabRectangles";
            this.tabRectangles.Size = new System.Drawing.Size(504, 475);
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
            this.gridRectangles.Size = new System.Drawing.Size(504, 475);
            this.gridRectangles.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGo);
            this.Name = "MainForm";
            this.Text = "Rectángulos";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.tabControl1.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.tabRectangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRectangles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TabPage tabPoints;
        private System.Windows.Forms.TabPage tabRectangles;
        private System.Windows.Forms.DataGridView gridPoints;
        private System.Windows.Forms.DataGridView gridRectangles;
    }
}