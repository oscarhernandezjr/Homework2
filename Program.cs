namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start array with numbers provided
            int[] arrNum = { 1, 1, 2, 2, 3, 3, 5, 5, 7, 8, 8, 9, 9 };

            // Prints the unique number found via Binary Search
            Console.WriteLine("Number is " + FindUniqueElement(arrNum));
        }

        public static int FindUniqueElement(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // Mid is even so that we compare pairs correctly
                if (mid % 2 == 1)
                {
                    mid--;
                }

                // Compare the mid element with the next 
                if (arr[mid] == arr[mid + 1])
                {
                    // Element must be in the right half
                    left = mid + 2;
                }
                else
                {
                    // Element must be in the left half
                    right = mid;
                }
            }

            // Element is found when left equals right
            return arr[left];
        }
    }
}