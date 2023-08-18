using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArreglo
{
    public partial class Form1 : Form
    {
        string[] DiasSemana = new string[7];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btListar_Click(object sender, EventArgs e)
        {
            // string[] DiasSemana = new string[7];
            // string[] DiasSemana = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            //string[] DiasSemana = new string[7];

            //DiasSemana[0] = "lunes";
            //DiasSemana[1] = "martes";
            //DiasSemana[2] = "miercoles";
            //DiasSemana[3] = "jueves";
            //DiasSemana[4] = "viernes";
            //DiasSemana[5] = "sabado";
            //DiasSemana[6] = "domingo";

            lblSalida.Text = "";
            foreach (string dia in DiasSemana)
            {
                lblSalida.Text = lblSalida.Text + dia + "\r\n";
            }

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            DiasSemana[i] = txtDia.Text;

            i = i + 1;
        }
    }
}
