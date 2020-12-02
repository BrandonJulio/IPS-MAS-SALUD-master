using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace IPSGUI
{
    public partial class FrmConsulta : Form
    {
        //LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
        public FrmConsulta()
        {
            InitializeComponent();
            LlenarTabla();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Regresar?", "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Menu menu = new Menu();
            menu.Show();
            this.Close();
            } 
        }
        private void LlenarTabla()
        {
            DgvLiquidacion.DataSource = null;
            //DgvLiquidacion.DataSource = LiquidacionCuotaModeradoraService.ConsultarTodos();
        }
        private void CargarContributivo()
        {
            DgvLiquidacion.DataSource = null;
            //DgvLiquidacion.DataSource = LiquidacionCuotaModeradoraService.ListarContributivo().ToList();
            //TxtContributivo.Text = service.TotalizarContributivo().ToString();
            TxtSubsidiado.Text = "";
            LimpiarTxt();


        }
        private void CargarSubsidiado()
        {
            DgvLiquidacion.DataSource = null;
            //DgvLiquidacion.DataSource = LiquidacionCuotaModeradoraService.ListarSubsidiado().ToList();
            //TxtSubsidiado.Text = service.TotalizarSubsidiado().ToString();
            TxtContributivo.Text = "";
            LimpiarTxt();
        }
        private void CargarTodos()
        {
            LlenarTabla();
            //TxtTotal.Text = service.TotalizarTodos().ToString();
            //TxtContributivo.Text = service.TotalizarContributivo().ToString();
            //TxtSubsidiado.Text = service.TotalizarSubsidiado().ToString();

        }
        private void LimpiarTxt()
        {
            TxtTotal.Text = "";

        }
        private void PrepararDatos()
        {
            if (CmbTipoAfiliacion.Text.Equals("Todos"))
            {
                CargarTodos();
            }

            if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {
                CargarSubsidiado();

            }
            if (CmbTipoAfiliacion.Text.Equals("Contributivo"))
            {
                CargarContributivo();
            }
        }

        private void DgvLiquidacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbTipoAfiliacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepararDatos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtContributivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtSubsidiado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
