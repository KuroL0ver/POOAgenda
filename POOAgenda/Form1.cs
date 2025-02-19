namespace POOAgenda
{
    //herencia :o
    public partial class Form1 : Form
    {
        //Instancia y Campo de Agenda :3
        private Agenda _agenda;
        public Form1()
        {
            InitializeComponent();
            _agenda = new Agenda();
            DgvContactos.AutoGenerateColumns = false;
        }


        //Método de void
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtNombre.Text + "-" + TxtTelefono.Text);
        }





        private void Telefono(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Era para eliminar lo que escribes para luego restaurarlo.
            DgvContactos.DataSource = null;


            //Es para que busque el nombre y teléfono
            string nombre = TxtNombre.Text;
            string telefono = TxtTelefono.Text;
            string email = TxtEmail.Text;

            //Campo
            //Contacto nuevoContacto = new Contacto(nombre,telefono);
            ContactoConEmail nuevoContactoConEmail = new ContactoConEmail(nombre, telefono, email);


            //Es para agregar los contactos y es encapsulamiento
            //_agenda.Agregar(nuevoContacto);
            _agenda.Agregar(nuevoContactoConEmail);

            //Arreglo
            Contacto[] contactos = _agenda.ObtenerContactos();


            DgvContactos.DataSource = contactos;
        }

        private void DgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}