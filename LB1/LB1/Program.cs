namespace LB1
{
    class Program
    {
        private static int Converter()
        {
            int inputValue = -1;

            while (!Int32.TryParse(Console.ReadLine(), out inputValue))
            {
                Console.WriteLine("Please enter valid value!");
            }

            return inputValue;
        }

        private static void Fill(ref int[] array)
        {
            Console.WriteLine("Please fill the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Converter();
            }
        }

        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private async static Task<int[]> Sort(int[] array)
        {
            Console.Write("Sort");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            await Task.Run(() => SortAsync(ref array));

            return array;
        }

        private static int[] SortAsync(ref int[] arrayToSort)
        {
            Array.Sort(arrayToSort);
            Console.WriteLine("\nSorting done");

            return arrayToSort;
        }

        async static Task Main()
        {
            Console.WriteLine("Enter size of array: ");
            int arraySize = Converter();

            var arrayBeforeSort = new int[arraySize];
            Fill(ref arrayBeforeSort);

            Console.WriteLine("\nYour array: ");
            Print(arrayBeforeSort);

            Console.WriteLine("\nSorting: ");
            await Sort(arrayBeforeSort);
            Print(arrayBeforeSort);
        }
    }
}