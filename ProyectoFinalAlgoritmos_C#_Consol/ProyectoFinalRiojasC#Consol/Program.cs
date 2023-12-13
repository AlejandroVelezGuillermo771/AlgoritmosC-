using SortingAlgorithms;

int Opbciones;
Console.WriteLine("       Menu");
Console.WriteLine(" (1) BinaryTreeSort");
Console.WriteLine(" (2) BubbleSort");
Console.WriteLine(" (3) BucketSort");
Console.WriteLine(" (4) CocktailSort");
Console.WriteLine(" (5) CombSort");
Console.WriteLine(" (6) CountingSort");
Console.WriteLine(" (7) GnomeSort");
Console.WriteLine(" (8) Heapsort");
Console.WriteLine(" (9) InsertionSort");
Console.WriteLine(" (10) Pergesort");
Console.WriteLine(" (11) PigeonholeSort");
Console.WriteLine(" (12) Quicksort");
Console.WriteLine(" (13) RadixSort");
Console.WriteLine(" (14) SelectionSort");
Console.WriteLine(" (15) ShellSort");
Console.WriteLine(" (16) SmoothSort");
Console.WriteLine("Eligio La Opbcion:");
Opbciones = Convert.ToByte(Console.ReadLine());

switch (Opbciones)
{
    case 1:
        {
                BinaryTree binaryTree = new BinaryTree();

                Console.WriteLine("Ingrese números desordenados (ingrese 'fin' para terminar):");

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "fin")
                        break;

                    if (int.TryParse(input, out int number))
                    {
                        binaryTree.Insert(number);
                        Console.WriteLine("Árbol actual:");
                        binaryTree.InOrderTraversal();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                }

                Console.WriteLine("Números ordenados:");
                binaryTree.InOrderTraversal();
            
        } break;
        case 2:
        {
            Console.WriteLine("Ingrese números separados por comas:");
            string input = Console.ReadLine();

            // Parse the input string into an array of integers
            int[] numbers = input.Split(',').Select(int.Parse).ToArray();

            Console.WriteLine("Array original:");
            BubbleSort.DisplayArray(numbers);

            Console.WriteLine("\nOrdenando con Bubble Sort:");

            // Sort the array using Bubble Sort
            BubbleSort.Sort(numbers);

            Console.WriteLine("\nArray ordenado:");
            BubbleSort.DisplayArray(numbers);
        } break;
        case 3: 
        {
            List<int> numbers = GetInputNumbers();
            Console.WriteLine("Números desordenados: " + string.Join(", ", numbers));

            List<int> sortedNumbers = BucketSort.Sort(numbers);

            Console.WriteLine("Números ordenados: " + string.Join(", ", sortedNumbers));

            static List<int> GetInputNumbers()
            {
                Console.Write("Ingrese números desordenados separados por espacios: ");
                string input = Console.ReadLine();

                List<int> numbers = new List<int>();
                foreach (string num in input.Split(' '))
                {
                    if (int.TryParse(num, out int parsedNum))
                    {
                        numbers.Add(parsedNum);
                    }
                    else
                    {
                        Console.WriteLine($"'{num}' no es un número válido y será ignorado.");
                    }
                }

                return numbers;
            }
        } break;
        case 4:
        {
            Console.WriteLine("Ingrese números desordenados separados por espacios:");
            string input = Console.ReadLine();

            string[] stringArray = input.Split(' ');
            int[] array = Array.ConvertAll(stringArray, int.Parse);

            Console.WriteLine("Array desordenado:");
            PrintArray(array);

            CocktailSort.Sort(array);

            Console.WriteLine("Array ordenado:");
            PrintArray(array);

            static void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 5: 
        {
            Console.WriteLine("Ingrese números desordenados separados por espacios:");
            string input = Console.ReadLine();

            try
            {
                int[] unsortedArray = Array.ConvertAll(input.Split(' '), int.Parse);

                Console.WriteLine("Array desordenado:");
                PrintArray(unsortedArray);

                CombSort.Sort(unsortedArray);

                Console.WriteLine("Array ordenado:");
                PrintArray(unsortedArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese números válidos.");
            }
            static void PrintArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 6: 
        {
            Console.WriteLine("Ingrese los números desordenados separados por espacios:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            int[] unsortedArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int num))
                {
                    unsortedArray[i] = num;
                }
                else
                {
                    Console.WriteLine($"Error: '{inputArray[i]}' no es un número válido.");
                    return;
                }
            }

            Console.WriteLine("\nOrdenando con Counting Sort...");

            int[] sortedArray = CountingSort.Sort(unsortedArray);

            Console.WriteLine("Arreglo ordenado:");
            PrintArray(sortedArray);

            static void PrintArray(int[] array)
            {
                foreach (var num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 7: 
        {
            Console.WriteLine("Ingrese números separados por espacios:");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"El valor '{inputArray[i]}' no es un número válido. Se ignorará.");
                }
            }

            Console.WriteLine("Números ingresados: " + string.Join(", ", numbers));

            // Sort using Gnome Sort
            GnomeSort.Sort(numbers);

            Console.WriteLine("Números ordenados: " + string.Join(", ", numbers));
        } break;
        case 8: 
        {
            Console.WriteLine("Ingrese números desordenados separados por espacios:");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            Console.WriteLine("Números desordenados:");
            PrintArray(numbers);

            HeapSort.Sort(numbers);

            Console.WriteLine("Números ordenados con Heapsort:");
            PrintArray(numbers);

            static void PrintArray(int[] arr)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 9:
        {
            Console.WriteLine("Ingrese números separados por espacios:");

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] arr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int num))
                {
                    arr[i] = num;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    return;
                }
            }

            Console.WriteLine("Array desordenado:");
            PrintArray(arr);

            InsertionSort.Sort(arr);

            Console.WriteLine("Array ordenado:");
            PrintArray(arr);

            static void PrintArray(int[] arr)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 10: 
        {
            Console.WriteLine("Ingrese números separados por espacios:");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            int[] array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int num))
                {
                    array[i] = num;
                }
                else
                {
                    Console.WriteLine($"'{numbers[i]}' no es un número válido. Se ignorará.");
                }
            }

            Console.WriteLine("Array desordenado:");
            PrintArray(array);

            MergeSort.Sort(array);

            Console.WriteLine("Array ordenado:");
            PrintArray(array);

            static void PrintArray(int[] array)
            {
                foreach (var num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 11: 
        {
            Console.WriteLine("Pigeonhole Sort");
            Console.Write("Ingrese la cantidad de números a ordenar: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Ingrese los números:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPasos de ordenamiento:");

            DisplayArray(arr, "Original Array");

            PigeonholeSort.Sort(arr);

            DisplayArray(arr, "Sorted Array");

            Console.ReadLine();
            static void DisplayArray(int[] arr, string message)
            {
                Console.Write($"{message}: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 12: 
        {
            Console.WriteLine("Ingrese números separados por espacios:");
            string input = Console.ReadLine();

            // Parse the input string into an array of integers
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            // Display unsorted array
            Console.WriteLine("Array desordenado:");
            DisplayArray(numbers);

            // Sort the array using Quicksort
            Quicksort.Sort(numbers);

            // Display sorted array
            Console.WriteLine("Array ordenado:");
            DisplayArray(numbers);

            static void DisplayArray(int[] array)
            {
                foreach (var num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        } break;
        case 13: 
        {
            Console.WriteLine("Ingrese números separados por comas:");
            string input = Console.ReadLine();
            int[] unsortedArray = Array.ConvertAll(input.Split(','), int.Parse);

            Console.WriteLine("Array desordenado:");
            RadixSort.PrintArray(unsortedArray);

            Console.WriteLine("\nOrdenando con Radix Sort:");
            RadixSort.Sort(unsortedArray);

            Console.WriteLine("\nArray ordenado:");
            RadixSort.PrintArray(unsortedArray);
        } break;
        case 14: 
        {
            Console.WriteLine("Ingrese números separados por espacios:");

            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine("Array ingresado: " + string.Join(", ", numbers));

            SelectionSort.Sort(numbers);

            Console.WriteLine("Array ordenado: " + string.Join(", ", numbers));

            Console.ReadLine(); // Para que la consola no se cierre inmediatamente
        } break;
        case 15: 
        {
            Console.WriteLine("Ingrese números separados por espacios:");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            int[] array = Array.ConvertAll(numbers, int.Parse);

            Console.WriteLine("Array desordenado:");
            DisplayArray(array);

            ShellSort.Sort(array);

            Console.WriteLine("Array ordenado con Shellsort:");
            DisplayArray(array);

            Console.ReadLine();

            static void DisplayArray(int[] arr)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        } break;
        case 16: 
        {
            SmoothSort smoothSort = new SmoothSort();

            Console.WriteLine("Ingrese los números para agregarlos al montón de SmoothSort. Ingrese 'ordenar' para ordenar el montón.");

            while (true)
            {
                Console.Write("Ingrese un número (o 'ordenar' para ordenar):");
                string input = Console.ReadLine();

                if (input.ToLower() == "Ordenado")
                {
                    smoothSort.Sort();
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    smoothSort.AddNumber(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'sort'.");
                }
            }
        } break;
}
Console.ReadKey();