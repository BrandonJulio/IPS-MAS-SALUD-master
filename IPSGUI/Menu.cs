using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSGUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void INGRESAR_Click(object sender, EventArgs e)
        {
            FrmIngresar frmIngresar = new FrmIngresar();
            frmIngresar.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsulta frmConsulta = new FrmConsulta();
            frmConsulta.Show();
           
        }
    }
}
