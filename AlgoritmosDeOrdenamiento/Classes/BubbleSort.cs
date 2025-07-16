using AlgoritmosDeOrdenamiento.Interfaces;
/// <summary>
/// Escenario:
/// Una profesora desea ordenar las calificaciones finales de sus 10 estudiantes para visualizarlas de menor a mayor antes de cargarlas al sistema.
/// - - Datos de entrada (arreglo de enteros): - - 
/// { 85, 70, 90, 75, 60, 95, 88, 76, 100, 65}
/// </summary>

namespace AlgoritmosDeOrdenamiento.Classes
{
    /// <summary>
    /// Clase que implementa el algoritmo de ordenamiento Bubble Sort.
    /// Hereda de la interfaz IBase,por lo cual obliga a implementar a:
    /// CargarDatos() y OrdenarDatos().
    /// </summary>
    public class BubbleSort : IBase
    {
        /// <summary>
        /// Arreglo que contendra los datos a ordenar.
        /// </summary>
        public int[] data;

        /// <summary>
        /// Constructor:
        /// Inicializa el arreglo 'data' con longitud 0 para evitar null.
        /// </summary>
        public BubbleSort()
        {
            data = new int[0];
        }

        /// <summary>
        /// Carga en 'data' las calificaciones finales de los 10 estudiantes.
        /// </summary>
        public void CargarDatos()
        {
            data = new int[] { 85, 70, 90, 75, 60, 95, 88, 76, 100, 65 };
        }

        /// <summary>
        /// Ordena el arreglo 'data' con Bubble Sort
        /// y muestra el estado del arreglo tras cada pasada.
        /// </summary>
        public void OrdenarDatos()
        {
            Console.WriteLine("---Ordenando con Bubble Sort---\n");

            // Recorre el arreglo tantas veces como elementos tenga (n‑1 pasadas).
            for (int i = 0; i < data.Length - 1; i++)
            {
                // Recorre los pares hasta el elemento ya ordenado al final.
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    // Si el elemento actual es mayor que el siguiente, los intercambia.
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }

                // Muestra como queda el arreglo tras cada pasada.
                Console.Write($"Pasada #{i + 1}: ");
                Console.WriteLine(string.Join(", ", data)); // '.Join' permite mostrar todos los elementos de forma legible y en una sola linea
            }
        }
    }
}
