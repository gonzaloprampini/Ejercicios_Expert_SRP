using System;

namespace Ejercicios_Expert_SRP
{
    public class Doctor
    {
        public Doctor(string nombre,string especialidad, int id)
        {
            Nombre=nombre;
            Especialidad=especialidad;
            Id=id; 
        }


        public string Nombre{get;set;}
        public string Especialidad{get;set;}

        public int Id{get;set;}

        }
}  