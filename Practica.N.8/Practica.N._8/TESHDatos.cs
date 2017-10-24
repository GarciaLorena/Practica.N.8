using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Practica.N._8
{
    [Table("Mis Datos")]
   public class TESHDatos
    {
        string matricula;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;
        [PrimaryKey, Unique, MaxLength(8)]
        public string Id
        {
            get { return matricula; }
            set { matricula = value; }
        }

        [Column("Nombre"), MaxLength(20)]
        public string Dato1
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [Column("Apellidos"), MaxLength(30)]
        public string Dato2
        {
            get { return apellido; }
            set { apellido = value; }
        }

        [Column("Direccion"), MaxLength(40)]
        public string Dato3
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [Column("Telefono"), MaxLength(10)]
        public string Dato4
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [Column("Carrera"), MaxLength(30)]
        public string Dato5
        {
            get { return carrera; }
            set { carrera = value; }
        }
        [Column("Semestre"), MaxLength(20)]
        public string Dato6
        {
            get { return semestre; }
            set { semestre = value; }
        }

        [Column("Correo"), MaxLength(20)]
        public string Dato7
        {
            get { return correo; }
            set { correo = value; }
        }

        [Column("GitHub"), MaxLength(20)]
        public string Dato8
        {
            get { return github; }
            set { github = value; }
        }

       
    }
}
