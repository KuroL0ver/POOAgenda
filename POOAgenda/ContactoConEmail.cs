namespace POOAgenda
{
    //Herencia por los dos puntos
    class ContactoConEmail : Contacto
    {
        public ContactoConEmail(string nombre, string telefono, string email)
              : base(nombre, telefono, email)
        {
            Email = email;
        }
    }
}
