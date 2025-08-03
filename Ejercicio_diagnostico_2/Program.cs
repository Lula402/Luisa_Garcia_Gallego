namespace Ejercicio_diagnostico_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HH:MM:SS");
            // Escriba una función que reciba una cantidad entera de segundos y retorne un string que muestre esa cantidad en formato HH:MM:SS. NO utilizar la clase DateTime.

            /* 1 minuto = 60 segundos
            1 hora = 60 minutos = 3600 segundos */

            int segundos = 3661;
            int minutos;
            int horas;
            int segsFinales;
            int a;
            string resultado = tiempo(segundos);
            Console.WriteLine(resultado);


            tiempo(segundos);

            string tiempo (int segundos)
            {
                horas = segundos / 3600;
                a = segundos % 3600;
                minutos = a / 60;
                segsFinales = a % 60;

                // Para segundos = 3661

                return $"{horas:D2}:{minutos:D2}:{segsFinales:D2}";

            }
        }
    }
}
