namespace practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void tBDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(e);
        }
        private void tBHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(e);
        }
        
        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int desde = Convert.ToInt32(tBDesde.Text);
            int hasta = Convert.ToInt32(tBHasta.Text);

            if (!ValidarRango(desde, hasta)) return;

            GenerarNumeros(desde, hasta);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tBDesde.Text) ||
                string.IsNullOrWhiteSpace(tBHasta.Text))
            {
                MessageBox.Show("Debe completar ambos campos", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarRango(int desde, int hasta)
        {
            if (desde > hasta)
            {
                MessageBox.Show("'Desde' debe ser menor o igual que 'Hasta'", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void GenerarNumeros(int desde, int hasta)
        {
            LlisaNumeros.Items.Clear();

         
            for (int i = desde; i <= hasta; i++)
            {
                LlisaNumeros.Items.Add(i.ToString());
            }
        }

        private void tBHasta_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
