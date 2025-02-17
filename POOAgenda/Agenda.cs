namespace POOAgenda
{
    //Clase es Agenda, que tiene un arreglo de contactos
    internal class Agenda
    {
        //Los que son "_tal" son campos
        //Contacto es un arreglo gracias a []
        private Contacto[] _contactos;  //Es arreglo :b
        private int _tope;


        //Constructor
        public Agenda()
        {
            _contactos = new Contacto[50];
            _tope = 0;
        }

        //Método de void
        public void Agregar(Contacto contacto)
        {
            _contactos[_tope] = contacto;
            _tope += 1;

        }
        // Retorna un tipo de datos, mientras que el método no
        public Contacto[] ObtenerContactos()
        {
            return _contactos;
        }
    }
}
