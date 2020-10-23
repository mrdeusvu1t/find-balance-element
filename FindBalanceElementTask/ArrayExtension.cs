using System;

namespace FindBalanceElementTask
{
    /// <summary>
    /// Class for operations with arrays.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds an index of element in an integer array for which the sum of the elements
        /// on the left and the sum of the elements on the right are equal.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>The index of the balance element, if it exists, and null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static int? FindBalanceElement(int[] array)
        {
            if(array is null)
            {
                throw new ArgumentNullException("error");
            }

            if(array.Length == 0)
            {
                throw new ArgumentException("error");
            }
            
            if (array.Length < 3)
            {
                return null;
            }

            for (int i = 1; i < array.Length; i++)
            {
                long sumLeft = 0;
                long sumRight = 0;
                
                var n = 0;
                do
                {
                    sumLeft += array[n];
                    n++;
                } while (n < i);

                var m = i + 1;
                while (m < array.Length)
                {
                    sumRight += array[m];
                    m++;
                }

                if (sumLeft == sumRight)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
