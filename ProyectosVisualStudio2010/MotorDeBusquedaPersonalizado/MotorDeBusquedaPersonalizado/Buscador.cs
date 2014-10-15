using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotorDeBusquedaPersonalizado
{
    public partial class Buscador : Form
    {
        MotorBusqueda mbQuery;
        
        public Buscador()
        {
            InitializeComponent();
            mbQuery = new MotorBusqueda();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvContent.View = View.Details;
            lvContent.GridLines = true;
            lvContent.FullRowSelect = true;            

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
           if(tbBuscar.Text != "")
                mbQuery.getQuery(tbBuscar.Text, lvContent);
        }

        private void lvContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = lvContent.SelectedItems[0].SubItems[1].Text.ToString();
            System.Diagnostics.Process.Start(s);
        }

        



    }
}
