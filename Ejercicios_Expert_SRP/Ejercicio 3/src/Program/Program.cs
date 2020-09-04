/*
Cumple con respecto al Expert porque el responsable de hacer
las citas es el metodo createAppointment que a su vez
valida los campos de las citas
Tambien cumple con el SRP porque no se necesita validar los campos
de manera individual. hay un metodo que soluciona la validacion de
los datos, que es el createAppoinment. 
*/

using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
