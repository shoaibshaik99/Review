/*2)Build a console application that reverses the elements of a generic array.
 * Users should be able to input an array of any type (e.g., integers, strings)
 * and see the elements reversed and printed to the console.
 */
namespace ReverseArray
{
    public static class Reverse
    {
        public static void Do<T>(T[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i<len/2; i++)
            {
                T temp = arr[i];
                arr[i] = arr[len-1-i];
                arr[len - 1 - i] = temp;
            }
        }
    }
}
