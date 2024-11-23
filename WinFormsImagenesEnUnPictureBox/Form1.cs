namespace WinFormsImagenesEnUnPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonImagen1_Click(object sender, EventArgs e)
        {
            pictureBoxImagenes.Image = WinFormsImagenesEnUnPictureBox.Properties.Resources.Imagen_1;
        }

        private void buttonImagen2_Click(object sender, EventArgs e)
        {
            pictureBoxImagenes.Image = WinFormsImagenesEnUnPictureBox.Properties.Resources.Imagen_2;
        }

        private void buttonImagen3_Click(object sender, EventArgs e)
        {
            pictureBoxImagenes.Image = WinFormsImagenesEnUnPictureBox.Properties.Resources.Imagen_3;
        }

        private void buttonImagen4_Click(object sender, EventArgs e)
        {
            pictureBoxImagenes.Image = WinFormsImagenesEnUnPictureBox.Properties.Resources.Imagen_4;
        }
    }
}
