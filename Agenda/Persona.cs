using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Persona
    {
        string Nombre;
        string Apellido;
        string Direccion;
        int Telefono;

        public Persona()
        {
            Nombre="";
            Apellido="";
            Direccion="";
            Telefono=0;
        }

        public string nombre
        {
            get {return Nombre;}
            set {Nombre = value;}
        }

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public int telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
    }
}
