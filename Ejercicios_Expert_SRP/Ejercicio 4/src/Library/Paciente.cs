using System;

namespace Ejercicios_Expert_SRP
{
    public class Paciente
    {
        public Paciente(string name,int id,string phoneNumber,int edad)
        {
            Name=name;
            Id=id;
            PhoneNumber=phoneNumber;
            Edad=edad;
        }
        public string Name{get;set;}
        public int Id{get;set;}
        public string PhoneNumber{get;set;}
        public int Edad{get;set;}
    }
}