namespace Ejercicio_de_clase
{

    public class Program
    {
        static void Main(string[] args)
        {
            DataStructureTester tester = new DataStructureTester();

            List<int> miLista = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                tester.AddElementToList(miLista, i);
            }

            Console.WriteLine("Lista actual:");
            tester.IterateCollection(miLista);
           
            while (true) {
                Console.WriteLine("¿Qué número deseas eliminar?");
                int numeroAEliminar = Convert.ToInt32(Console.ReadLine());

                miLista.Remove(numeroAEliminar);

                Console.WriteLine("Lista actualizada:");
                tester.IterateCollection(miLista);

                Console.WriteLine("Desea eliminar otro número?");
                string respuesta = Console.ReadLine();

                if (respuesta != "si" & respuesta != "SI" & respuesta != "Si")
                {
                    break;
                } else
                {
                    
                }
            }
        }
    }

    public class DataStructureTester
        {
            public int GetCollectionSize(int[] arr)
            {
                return arr.Length;
            }
            public int GetCollectionSize(List<int> list)
            {
                if (list == null)
                {
                    list = new List<int>();
                }

                return list.Count;
            }
            public void IterateCollection(List<int> list)
            {
                foreach (int item in list) 
                {
                    Console.WriteLine(item);
                }
            }
            public void IterateCollection()
            {
                string[] arreglo = { "papu1", "papu2", "papu3", "papu4", "papu5" };

                foreach (string item in arreglo)
                {
                    Console.WriteLine(item);
                }
            }
            public void AddElementToList(List<int> list, int newElement) => list.Add(newElement);
        }
}
