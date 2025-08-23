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
            LlistaNumeros.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                LlistaNumeros.Items.Add(i.ToString());
            }
        }

        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            FiltrarNumeros("pares");
        }

        private void BNumerosImpares_Click(object sender, EventArgs e)
        {
            FiltrarNumeros("impares");
        }

        private void Numeros_Click(object sender, EventArgs e)
        {
            FiltrarNumeros("primos");
        }

        private void FiltrarNumeros(string tipo)
        {
            if (LlistaNumeros.Items.Count == 0)
            {
                MessageBox.Show("Primero genere números con 'Generar Función'", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> numerosFiltrados = new List<string>();

            foreach (var item in LlistaNumeros.Items)
            {
                if (int.TryParse(item.ToString(), out int numero))
                {
                    switch (tipo)
                    {
                        case "pares":
                            if (numero % 2 == 0)
                                numerosFiltrados.Add(numero.ToString());
                            break;

                        case "impares":
                            if (numero % 2 != 0)
                                numerosFiltrados.Add(numero.ToString());
                            break;

                        case "primos":
                            if (EsPrimo(numero))
                                numerosFiltrados.Add(numero.ToString());
                            break;
                    }
                }
            }

            // Mostrar resultados - CON VALIDACIÓN
            if (numerosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron números con el filtro aplicado",
                               "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Regenerar números originales o dejar vacío
                GenerarNumeros(Convert.ToInt32(tBDesde.Text), Convert.ToInt32(tBHasta.Text));
                return;
            }

            LlistaNumeros.Items.Clear();
            LlistaNumeros.Items.AddRange(numerosFiltrados.ToArray());
        }

        // Función para detectar números primos
        private bool EsPrimo(int numero)
        {
            // Casos especiales
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            // Optimización: solo verificar hasta la raíz cuadrada
            var limite = (int)Math.Sqrt(numero);

            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

    }
}
