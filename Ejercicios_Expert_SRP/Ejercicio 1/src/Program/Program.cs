using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5);
            Kiosco k = new Kiosco();
            if (k.PuedeComprar(a, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}

/*
La clase Kiosco cumple con el patrón Expert, ya que el método ConvertirPesos es responsable de convertir el dinero en una moneda determinada 
La clase alfajor cumple el patrón Expert porque es responsable de los datos del alfajor. 
La clase alfajor no cumple con el patrón SRP porque cada clase no puede tener más de un motivo de cambio. Precio y masa no permite un cambio en el futuro. Si en un futuro, por ejemplo, el precio final es precioDulce + precioMasa + 10%, debería cambiar en todos lados donde fue programada esta funcionalidad. No esta sujeto a una responsabilidad. Para que cumpla con la condición de cambio en el futuro debería tener un método precioFinal en la clase Alfajor. 
*/
