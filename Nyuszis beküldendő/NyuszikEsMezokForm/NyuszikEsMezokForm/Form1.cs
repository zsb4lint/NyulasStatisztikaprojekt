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
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                for (int j = 0; j < Tabla.Columns.Count; j++)
                {
                    if (elohely.mat[i+1, j+1].nyusziE == true)
                    {
                        Tabla.Rows[i].Cells[j].Value = "X";
                    }
                    else
                    {
                        Tabla.Rows[i].Cells[j].Value = "";
                    }
                }
            }
        }
        private void ElohelyGeneralas(int sor, int oszlop)
        {
            int a = Esely.Value;
            
            elohely = Adatlekeres.General(sor, oszlop, a);
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
            Console.WriteLine();
        }
        
        private void KovLep_Click(object sender, EventArgs e)
        {
            Elohely.UpdateEloh(elohely);
            elohely.SzuletikE(elohely);
            elohely.MeghalE(elohely);
            Futtathato.UpdateSzulHal(elohely);
            ElohelyMegjelenit();
        }


        private void Esely_Scroll(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(Esely.Value);
        }
    }
}
