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
    
    public partial class FrmIngresar : Form
    {
        LiquidacionCuotaModeradora liquidacion;
        public FrmIngresar()
        {
            InitializeComponent();
        }

        private void FrmIngresar_Load(object sender, EventArgs e)
        {

        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            LiquidacionCuotaModeradora cuotaModeradora = MapearLiquidacion();
            cuotaModeradora.CalcularTarifa();
            string mesanje = service.Guardar(cuotaModeradora);
            MessageBox.Show(mesanje, "MENSAJE GUARDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private LiquidacionCuotaModeradora MapearLiquidacion()
        {
            if (CmbTipoAfiliacion.Text.Equals("Contributivo"))
            {
                liquidacion = new Contributivo();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {
                liquidacion = new Subsidiado();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            return null;
        }
        public void Limpiar()
        {
            TxtNumeroLiquidacion.Text = "";
            DtpFechaLiquidacion.Text = "";
            TxtIdentificacion.Text = "";
            CmbTipoAfiliacion.Text = "";
            TxtSalarioDevengado.Text = "";
            TxtValorHospitalizacion.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
            string identificacion = TxtIdentificacion.Text;
            if (identificacion != "")
            {
                LiquidacionCuotaModeradora Liquidacion = liquidacionCuotaModeradoraService.BuscarID(identificacion);

                if (Liquidacion != null)
                {
                    TxtIdentificacion.Text = Liquidacion.Identificacion;
                    TxtNumeroLiquidacion.Text = Liquidacion.NumeroLiquidacion;
                    DtpFechaLiquidacion.Text = Liquidacion.FechaLiquidacion.ToString();
                    CmbTipoAfiliacion.Text = Liquidacion.TipoAfiliacion;
                    TxtSalarioDevengado.Text = Liquidacion.SalarioDevengado.ToString();
                    TxtValorHospitalizacion.Text = Liquidacion.ValorServicioHospitalizacion.ToString();

                }
                else
                {

                    MessageBox.Show($"LA PERSONA CON LA IDENTIFICACIÓN:  {identificacion} NO SE ENCUENTRA REGISTRADA");
                    Limpiar();

                }

            }
            else
            {
                MessageBox.Show("DIGITE IDENTIFICACIÓN");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO", "MENSAJE DE ELIMINACIÓN", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
                string identificacion = TxtIdentificacion.Text;
                string mensaje2 = liquidacionCuotaModeradoraService.Eliminar(identificacion);
                MessageBox.Show(mensaje2);
                Limpiar();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }  
}
