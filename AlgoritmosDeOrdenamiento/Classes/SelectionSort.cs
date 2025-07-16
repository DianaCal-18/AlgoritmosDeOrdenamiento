using AlgoritmosDeOrdenamiento.Interfaces;
/// <summary>
/// Escenario:
/// Un pequeño negocio tiene una lista de productos con sus precios. El dueño desea organizar los productos en orden ascendente de precio para etiquetarlos.
/// - - Datos de entrada (precios en pesos dominicanos): - - 
/// {250, 120, 75, 300, 100, 180, 90, 220}
/// </summary>

namespace AlgoritmosDeOrdenamiento.Classes
{
    /// <summary>
    /// Clase que implementa el algoritmo Selection Sort 
    /// Hereda de la interfaz IBase, que obliga a implementar a:
    /// CargarDatos() 
    /// OrdenarDatos() 
    /// </summary>
    public class SelectionSort : IBase
    {
        /// <summary>
        /// Arreglo con los datos a ordenar 
        /// </summary>
        public int[] data;

        /// <summary>
        /// Constructor 
        /// Inicializa el arreglo 'data' con longitud 0 para evitar null.
        /// </summary>
        public SelectionSort()
        {
            data = new int[0];
        }

        /// <summary>
        /// Carga los precios en el arreglo 'data'.
        /// </summary>
        public void CargarDatos()
        {
            data = new int[] { 250, 120, 75, 300, 100, 180, 90, 220 };
        }

        /// <summary>
        /// Ejecuta el algoritmo Selection Sort y muestra el proceso:
        /// 1. Busca el menor elemento en la parte no ordenada.
        /// 2. Lo intercambia con la primera posicin de esa parte.
        /// </summary>
        public void OrdenarDatos()
        {
            Console.WriteLine("---Ordenando con Selection Sort---\n");

            // Recorre el arreglo tantas veces como elementos tenga.
            for (int i = 0; i < data.Length - 1; i++)
            {
                int min = i; // Suponemos que el minimo esta en la posicion i.

                // Buscaa un valor mas pequeño en el resto del arreglo
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[min])
                    {
                        min = j; // Nuevo índice del mínimo encontrado.
                    }
                }

                // Muestra cual fue el indice del minimo en esta iteracióo.
                Console.WriteLine($"Indice de minimo pasada  #{i + 1}: {min}");

                // Intercambia el minimo encontrado con la posicion i
                int temp = data[i];
                data[i] = data[min];
                data[min] = temp;
            }

            // Muestra el arreglo completamente ordenado al final.
            Console.WriteLine("Resultado final: " + string.Join(", ", data));
        }
    }
}
