
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace Practica_2.Class
{
    public class calcular
    {
        public void Practica_2()

        {
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal producto = 0;
            decimal division = 0;
            decimal diferencia = 0;

            Console.WriteLine("Digite el Num1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el Num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            if (num1 > num2) ;
            suma = (num1 + num2);
            diferencia = (num1 - num2);

            {
                Console.WriteLine($"La suma es: {suma}");
                Console.WriteLine($"La Diferencia es: {diferencia}");
            }


            if (num2 < num1) ;
            division = (num2 / num1);
            producto = (num2 * num1);

            {
                Console.WriteLine($"La division es: {division}");
                Console.WriteLine($"El producto es: {producto}");
            }
        }
    }
}
