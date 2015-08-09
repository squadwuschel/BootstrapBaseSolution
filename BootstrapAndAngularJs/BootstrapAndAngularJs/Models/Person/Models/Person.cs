using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapAndAngularJs.Models.Person.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Erstellt { get; set; }   

        public string Passwort { get; set; }

        public bool IsAktiv { get; set; }   
    }
}