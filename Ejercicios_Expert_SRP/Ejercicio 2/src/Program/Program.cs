using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");

        }
    }
}

/*
No cumple con el expert porque el libro no es responsable de saber 
en que sector se encuentra, no hay forma de verificar si los datos 
de un libro no se encuentran repetidos en otro sector. 
No hay un control de eso. Para eso debería haber otra clase llamada 
Biblioteca, por ejemplo, que controla si puede o no ingresarse un 
nuevo libro. La biblioteca conoce la sección de cada libro, 
y almacena un nuevo dato.
*/