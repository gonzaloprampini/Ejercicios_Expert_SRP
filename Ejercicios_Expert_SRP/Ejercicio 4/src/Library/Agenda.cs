using System;

namespace Ejercicios_Expert_SRP
{
    public class Agenda
    {
        /*tomo como atributos de la clase Agenda 
        a la clase Doctor y Paciente, y asimismo le 
        doy como atributos fecha y una id. 
        */

        public Agenda(DateTime fecha, int id, Doctor doctor, Paciente paciente)
        {
            Fecha=fecha;
            Id=id;
            Doctor=doctor;
            Paciente=paciente;
        }
        public DateTime Fecha{get;set;}
        public int Id{get;set;}
        public Doctor Doctor{get;set;}
        public Paciente Paciente{get;set;}      
    }
}