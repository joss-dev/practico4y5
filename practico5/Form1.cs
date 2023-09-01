using System.Windows.Forms;

namespace practico5
{
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TFoto.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indiceFila = DataGridPersonas.Rows.Add();
                DataGridPersonas.Rows[indiceFila].Cells["Apellido"].Value = TApellido.Text;
                DataGridPersonas.Rows[indiceFila].Cells["Nombre"].Value = TNombre.Text;
                DataGridPersonas.Rows[indiceFila].Cells["Fecha Nacimiento"].Value = DFecha.Text;
                string sexo;
                if (RHombre.Checked)
                {
                    sexo = "Hombre";
                }
                else (RMujer.Checked)           
                {
                    sexo = "Mujer";
                }
                DataGridPersonas.Rows[indiceFila].Cells["Sexo"].Value = sexo;
                // Obtener el valor del saldo del cliente
                decimal saldo = Convert.ToDecimal(DataGridPersonas.Rows[indiceFila].Cells["Saldo"].Value);
                // Cambiar el color de fondo de la fila si el saldo es menor a 50
                if (saldo < 50)
                {
                    DataGridPersonas.Rows[indiceFila].DefaultCellStyle.BackColor = Color.Red;
                }
                DataGridPersonas.Rows[indiceFila].Cells["Saldo"].Value = TSaldo.Text;
                DataGridPersonas.Rows[indiceFila].Cells["Foto"].Value = pictureBox2.Text;
                DataGridPersonas.Rows[indiceFila].Cells["Ruta"].Value = TFoto.Text;
            }
        }

        private void DataGridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna del botón "Eliminar"
            if (e.ColumnIndex == DataGridPersonas.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila
                DataGridPersonas.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string rutaFoto = openFile.FileName;
                TFoto.Text = rutaFoto;

            }
        }

        private void mayusculaNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text) && char.IsLower(textBox.Text[0]))
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final del texto
            }
        }

        private void mayusculaApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text) && char.IsLower(textBox.Text[0]))
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final del texto
            }
        }

        private void validacionSaldo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validacionNombre(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }

        private void validacionApellido(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }

        
    }
}