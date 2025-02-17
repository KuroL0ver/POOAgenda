namespace POOAgenda
{
    internal class Contacto
    {
        //Almacena el nombre del contacto
        private string _nombre;
        //Almacena el telefono del contacto
        private string _telefono;

        //Es una propiedad que permite acceder al nombre del contacto
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
        //También es propiedad, pero permite acceder al telefono del contacto
        public string Telefono
        {
            //Get obtiene un valor
            get
            {
                return _telefono;
            }
            //Set asigna un valor
            set
            {
                _telefono = value;
            }
        }

        //Es constructor, porque tiene el mismo nombre de la clase
        public Contacto(string nombre, string telefono)
        {
            _nombre = nombre;
            _telefono = telefono;
        }
    }
}
