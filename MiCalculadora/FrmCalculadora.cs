using Entidades;
namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperando = null;
        private Numeracion segundoOperando = null;
        private Numeracion resultado = null;
        private Operacion calculadora;
        private char operador = '+';
        private bool actualizando = false;
        private Esistema sistema = Esistema.Decimal;
        
        public FrmCalculadora()
        {
            InitializeComponent();
            this.cmbOperacion.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            this.calculadora = new Operacion(this.primerOperando,this.segundoOperando);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.actualizando = true;
            this.SetResultado();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.primerOperando = null;
            this.segundoOperando = null;
            this.operador = '+';
            this.rdbBinario.Checked = false;
            this.rdbDecimal.Checked = true;
            this.txtPrimerOperador.Text = null;
            this.txtSegundoOperador.Text = null;
            this.cmbOperacion.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            this.actualizando = false;
        }


        private void SetResultado()
        {
            if (this.actualizando)
            {

                this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
                this.resultado = calculadora.Operar(this.operador);
                this.lblResultado.Text = this.resultado.ConvertirA(this.sistema);

            }
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(this.txtPrimerOperador.Text);
            this.SetResultado();
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(this.txtSegundoOperador.Text);
            this.SetResultado();
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.operador = char.Parse(this.cmbOperacion.SelectedItem.ToString());
            this.SetResultado();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = Esistema.Decimal;
            this.SetResultado();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = Esistema.Binario;
            this.SetResultado();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la calculadora?", "cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}