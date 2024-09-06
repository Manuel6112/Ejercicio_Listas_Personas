using System;
namespace ConsoleApp1
{
    public class cls_personas
    {
        private string nombreStr;
        private string idStr;
        private int edadInt;
        private string contactoStr;

        public cls_personas(string name, string id, int age, string contact)
        {
            this.nombreStr = name;
            this.idStr = id;
            this.edadInt = age;
            this.contactoStr = contact;
        }
        //setter, para actualizar atributos, no hay que espcificar
        public void setNombre(string name) { this.nombreStr = name; }
        public void setEdad(int age) { this.edadInt = age; }
        public void setContacto(string contact) { this.contactoStr = contact; }

        //getter, para devolver información almacenada, hay que especificar

        public string getNombreStr() { return this.nombreStr; }
        public int getEdadInt() { return this.edadInt; }
        public string getContactoStr() { return this.contactoStr; }
        public string getIdStr() { return this.idStr; }
    }
}
