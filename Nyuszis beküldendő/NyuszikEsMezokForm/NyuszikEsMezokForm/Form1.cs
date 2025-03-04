using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nyuszik_és_mezők;

namespace NyuszikEsMezokForm
{
    public partial class Form1 : Form
    {
        public static Elohely elohely;
        public Form1()
        {
            InitializeComponent();
            DefaSettings();
        }

        private void DefaSettings()
        {
            Tabla.ScrollBars = ScrollBars.None;
            Tabla.ColumnHeadersVisible = false;
            Tabla.RowHeadersVisible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }
        private void ElohelyMegjelenit()
        {
            for (int i = 0; i < Tabla.Columns.Count; i++)
            {
                for (int j = 0; j < Tabla.Rows.Count; j++)
                {
                    if (elohely.mat[i, j].nyusziE == true)
                    {
                        Tabla.Rows[j].Cells[i].Value = "X";
                    }
                }
            }
        }
        private void ElohelyGeneralas(int sor, int oszlop)
        {
            elohely = Adatlekeres.General(sor, oszlop, 50);
            ElohelyMegjelenit();
        }
        private void TablaMeret()
        {
            foreach (DataGridViewColumn cols in Tabla.Columns)
            {
                cols.Width = Tabla.Width / Tabla.Columns.Count * ((Zoom.Value / 10) + 1);
            }
            foreach (DataGridViewRow rows in Tabla.Rows)
            {
                rows.Height = Tabla.Height / Tabla.Rows.Count * ((Zoom.Value / 10) + 1);
            }
            Tabla.DefaultCellStyle.Font = new Font("Arial", Tabla.Columns[0].Width/2);
            Tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Tabla.ReadOnly = true;
            Tabla.AllowUserToResizeColumns = false;
            Tabla.AllowUserToResizeRows = false;
        }

        void Generalas()
        {
            Tabla.Columns.Clear();
            Tabla.Rows.Clear();

            int sor = (int)Sor.Value;
            int oszlop = (int)Oszlop.Value;

            for (int i = 0; i < oszlop; i++)
            {
                Tabla.Columns.Add("col","Oszlop");
            }
            for (int j = 0; j < sor-1; j++)
            {
                Tabla.Rows.Add();
            }

            TablaMeret();
            ElohelyGeneralas(sor, oszlop);
        }

        private void Zoom_Scroll(object sender, ScrollEventArgs e)
        {
            if(Zoom.Value == 0)
            {
                Tabla.ScrollBars = ScrollBars.None;
            }
            else
            {
                Tabla.ScrollBars = ScrollBars.Both;
            }
            TablaMeret();
        }

        private void General_Click(object sender, EventArgs e)
        {
            Generalas();
        }

        private void KovLep_Click(object sender, EventArgs e)
        {
            elohely = Futtathato.KovLepes(elohely.n, elohely.m);
            elohely = Futtathato.Update(elohely.n, elohely.m);
            ElohelyMegjelenit();
        }
    }
}
