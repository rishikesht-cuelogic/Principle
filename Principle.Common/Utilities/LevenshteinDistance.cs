using System;

namespace Principle.Common.Utilities
{
    /// <summary>
    /// Contains approximate string matching
    /// </summary>
    static class LevenshteinDistance
    {
        /// <summary>
        /// Compute the distance between two strings.
        /// </summary>
        /// <param name="source">source string</param>
        /// <param name="target">target string</param>
        /// <returns></returns>
        public static int Compute(string source, string target)
        {
            /// Step 1
            /// 1. Set sourceLength to be the length of source.
            /// 2. Set targetLength to be the length of target.
            /// 3. If sourceLength = 0, return targetLength and exit.
            /// 4. If targetLength = 0, return sourceLength and exit.
            /// 5. Construct a matrix containing 0…targetLength rows and 0...sourceLength columns.
            int sourceLength = source.Length;
            int targetLength = target.Length;
            int[,] matrix = new int[sourceLength + 1, targetLength + 1];

            if (sourceLength == 0)
            {
                return targetLength;
            }

            if (targetLength == 0)
            {
                return sourceLength;
            }

            /// Step 2
            /// 1.	Initialize the first row to 0…sourceLength.
            /// 2.	Initialize the first column to 0...targetLength.
            for (int indexSource = 0; indexSource <= sourceLength; matrix[indexSource, 0] = indexSource++)
            {
            }

            for (int indexTarget = 0; indexTarget <= targetLength; matrix[0, indexTarget] = indexTarget++)
            {
            }

            /// Step 3
            /// Examine each character of source (i from 1 to sourceLength).
            for (int indexSource = 1; indexSource <= sourceLength; indexSource++)
            {
                /// Step 4
                /// Examine each character of target (j from 1 to targetLength).
                for (int indexTarget = 1; indexTarget <= targetLength; indexTarget++)
                {
                    /// Step 5
                    /// Compute cost
                    /// 1. If source[i] equals target[j], the cost is 0.
                    /// 2. If source[i] doesn't equal target[j], the cost is 1.
                    int cost = (target[indexTarget - 1] == source[indexSource - 1]) ? 0 : 1;

                    /// Step 6
                    /// Set cell matrix [I, j] of the matrix equal to the minimum of:
                    /// 1. The cell immediately above plus 1: matrix[i -1, j] + 1.
                    /// 2. The cell immediately to the left plus 1: matrix[i, j-1] + 1.
                    /// 3. The cell diagonally above and to the left plus the cost: matrix[i-1, j-1] + cost.
                    matrix[indexSource, indexTarget] = Math.Min(
                                    Math.Min(matrix[indexSource - 1, indexTarget] + 1,
                                                matrix[indexSource, indexTarget - 1] + 1),
                                    matrix[indexSource - 1, indexTarget - 1] + cost);
                }
            }
            /// Step 7
            /// After the iteration steps 6th step complete, the distance is found in cell matrix [sourceLength, sourceLength].
            return matrix[sourceLength, targetLength];
        }
    }
}
