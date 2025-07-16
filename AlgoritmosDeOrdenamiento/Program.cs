using AlgoritmosDeOrdenamiento.Classes;
using AlgoritmosDeOrdenamiento.Interfaces;

int opcion;
do
{
    Console.Clear();
    Console.WriteLine("=== MENU PRACTICA DE ALGORITMOS DE ORDENAMIENTO ===\n");
    Console.WriteLine("Ejercicio 1 – Bubble Sort: Ordenar calificaciones finales");
    Console.WriteLine("Ejercicio 2 – Selection Sort: Ordenar inventario por precio");
    Console.WriteLine("Ejercicio 3 – Insertion Sort: Ordenar lista de llegadas");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opcion: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Programa1();
                break;
            case 2:
                Programa2();
                break;
            case 3:
                    Programa3();
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion no valida. Favor intentarlo nuevamente");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no valida. Debes ingresar un numero dentro de las opciones.");
    }

    if (opcion != 0)
    {
        Console.WriteLine("\nPresiona una tecla para continuar...");
        Console.ReadKey();
    }

} while (opcion != 0);


static void Programa1()
{
    BubbleSort bubbleSort = new BubbleSort();

    bubbleSort.CargarDatos();
    bubbleSort.OrdenarDatos();

}
static void Programa2()
{
    SelectionSort selectionSort = new SelectionSort();
    selectionSort.CargarDatos();
    selectionSort.OrdenarDatos();
}

static void Programa3()
{
    InsertionSort insertionSort = new InsertionSort();
    insertionSort.CargarDatos();
    insertionSort.OrdenarDatos();
}