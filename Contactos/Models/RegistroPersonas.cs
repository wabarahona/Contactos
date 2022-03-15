using System;
using SQLite;
namespace Contactos.Models
{
    public class RegistroPersonas
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(70)]
        public string Nombre { get; set; }
        [MaxLength(70)]
        public string Apellido { get; set; }
        //[MaxLength(3)]
        public string Edad { get; set; }
        //public string Pais { get; set; }
        //public string Nota { get; set; }
        public double Longitud { get; set; }
        public double Latitud { get; set; }


    }
}
