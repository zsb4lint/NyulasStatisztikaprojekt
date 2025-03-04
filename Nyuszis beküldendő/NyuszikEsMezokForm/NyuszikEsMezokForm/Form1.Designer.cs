namespace NyuszikEsMezokForm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox = new System.Windows.Forms.ListBox();
            this.KovLep = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Sor = new System.Windows.Forms.NumericUpDown();
            this.Oszlop = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Zoom = new System.Windows.Forms.HScrollBar();
            this.General = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oszlop)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(12, 12);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 24;
            this.Tabla.Size = new System.Drawing.Size(335, 318);
            this.Tabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nyuszik és mezők";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nyuszi Grafikon";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(369, 223);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(416, 215);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "Grafikon";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(668, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 196);
            this.listBox.TabIndex = 4;
            // 
            // KovLep
            // 
            this.KovLep.Location = new System.Drawing.Point(371, 71);
            this.KovLep.Name = "KovLep";
            this.KovLep.Size = new System.Drawing.Size(97, 31);
            this.KovLep.TabIndex = 5;
            this.KovLep.Text = "Kövi Lépés";
            this.KovLep.UseVisualStyleBackColor = true;
            this.KovLep.Click += new System.EventHandler(this.KovLep_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Indítás";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sor és Oszlop";
            // 
            // Sor
            // 
            this.Sor.Location = new System.Drawing.Point(507, 34);
            this.Sor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sor.Name = "Sor";
            this.Sor.Size = new System.Drawing.Size(120, 22);
            this.Sor.TabIndex = 8;
            this.Sor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Oszlop
            // 
            this.Oszlop.Location = new System.Drawing.Point(507, 64);
            this.Oszlop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Oszlop.Name = "Oszlop";
            this.Oszlop.Size = new System.Drawing.Size(120, 22);
            this.Oszlop.TabIndex = 9;
            this.Oszlop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "FájlBe";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 31);
            this.button4.TabIndex = 11;
            this.button4.Text = "FájlKi";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(12, 333);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(335, 17);
            this.Zoom.TabIndex = 12;
            this.Zoom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Zoom_Scroll);
            // 
            // General
            // 
            this.General.Location = new System.Drawing.Point(371, 34);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(97, 31);
            this.General.TabIndex = 13;
            this.General.Text = "Generálás";
            this.General.UseVisualStyleBackColor = true;
            this.General.Click += new System.EventHandler(this.General_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Oszlop);
            this.Controls.Add(this.Sor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KovLep);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oszlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button KovLep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Sor;
        private System.Windows.Forms.NumericUpDown Oszlop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.HScrollBar Zoom;
        private System.Windows.Forms.Button General;
    }
}

