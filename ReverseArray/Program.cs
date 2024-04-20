namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };

            //intArr.Reverse();

            Console.Write("Initial Array: ");
            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Reverse.Do(intArr);

            Console.Write("After reversing: ");
            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.Write("Initial Array: ");
            foreach (char i in charArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Reverse.Do(charArr);

            Console.Write("After reversing: ");
            foreach (char i in charArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }


}
