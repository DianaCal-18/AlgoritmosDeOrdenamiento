using AlgoritmosDeOrdenamiento.Interfaces;

namespace AlgoritmosDeOrdenamiento.Classes
{
    /// <summary>
    /// Implementa el algoritmo Insertion Sort
    /// Escenario: ordenar en tiempo real los tiempos de llegada de corredores.
    /// </summary>
    public class InsertionSort : IBase
    {
        /// <summary>
        /// Arreglo con los tiempos de llegada a ordenar.
        /// </summary>
        public int[] data;

        /// <summary>
        /// Constructor
        /// </summary>
        public InsertionSort()
        {
            data = new int[0];
        }

        /// <summary>
        /// Carga los tiempos de llegada en el arreglo 'data'.
        /// </summary>
        public void CargarDatos()
        {
            data = new int[] { 58, 54, 60, 52, 57, 56, 59 };
        }

        /// <summary>
        /// Ejecuta Insertion Sort y muestra el arreglo paso a paso:
        /// Recorre el arreglo desde el segundo elemento.
        /// Inserta cada valor en la posicion correcta
        /// de la parte ya ordenada a la izquierda.
        /// </summary>
        public void OrdenarDatos()
        {
            Console.WriteLine("***Ordenando con Insertion Sort\n***");

            // Empezamos en 1 porque el elemento 0 ya se considera ordenado.
            for (int i = 1; i < data.Length; i++)
            {
                int valor = data[i];  // valor que vamos a insertar
                int j = i - 1;        // Posicion de comparacion en la parte ordenada

                // Desplaza a la derecha los valores mayores que 'valor'
                while (j >= 0 && data[j] > valor)
                {
                    data[j + 1] = data[j]; // Mueve el elemento una posicion a la derecha
                    j--;                   // Retrocede para seguir comparando
                }

                // Coloca la 'valor' en su posicion correcta
                data[j + 1] = valor;

                // Muestra el arreglo parcial tras insertar la valor
                Console.Write($"Despues de insertar {valor}: ");
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(data[k] + (k < i ? ", " : "")); // Muestra solo la parte ya ordenada
                }
                Console.WriteLine();
            }

        }
    }
}
