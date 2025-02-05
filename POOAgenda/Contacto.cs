namespace POOAgenda
{
    internal class Contacto
    {
        private string _nombre;
        private string _telefono;


        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }

        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public Contacto(string nombre, string telefono)
        {
            _nombre = nombre;
            _telefono = telefono;
        }
    }
}
