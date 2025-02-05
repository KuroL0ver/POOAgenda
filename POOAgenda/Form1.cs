namespace POOAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacto primerContacto = new Contacto("Haniel","6621680497");
            MessageBox.Show($"El teléfono de {primerContacto.Nombre} es: {primerContacto.Telefono}");
        }
    }
}