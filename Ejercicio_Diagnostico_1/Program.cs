namespace Ejercicios_diagnósticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de Fibonacci");
            //Escriba una función que imprima únicamente los números primos de la serie de Fibonacci hasta el n-ésimo término.

            int a = 0;
            int b = 1;
            int next;
            int n = 1000;

            for (int i = 0; i < n; i++) {
                if (EsPrimo(a))
                {
                    Console.WriteLine(a);
                }
                next = a + b;
                a = b;
                b = next;
            }
           
            int numP = 0;  
  
            bool EsPrimo (int num)
            {
                if (num < 2)
                {
                    return false;
                } 
                
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }                 
                }
                return true;
            }            
        }
    }
}
