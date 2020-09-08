
using System;
using Ejercicios_Expert_SRP;
using Library;

namespace Program
{
    class Program2
    {
        static void Main(string[] args)
        {
            Doctor doctor=new Doctor("Jorge","Medicina General",1);
            Paciente paciente=new Paciente("Roberto",1,"099",35);
            Agenda consulta=new Agenda(DateTime.Today,1,doctor,paciente);
            Console.WriteLine("el doctor es"+ doctor.Nombre);
            Console.WriteLine("el paciente es"+"nombre: "+paciente.Name+" telefono: "+ paciente.PhoneNumber);
            Console.WriteLine("la consulta es:"+"fecha:"+consulta.Fecha+"nombre paciente:"+consulta.Paciente+"id consulta:"+consulta.Id);
        }
    }
}
