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
    }
}