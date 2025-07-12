using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Payloads;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // 1. Create an array of doubles with the specified length to store the multiples.
        // 2. Loop from 1 to the specified length (inclusive).
        // 3. For each iteration i, calculate the multiple by multiplying the starting number by i.
        // 4. Store the calculated multiple in the array at index i-1.
        // 5. After the loop finishes, return the array of multiples.
        double[] multiples = new double[length];

        for (int i = 1; i <= length; i++) //Loop from 1 to the specified length
        {
            multiples[i - 1] = number * i; // calculate the multiple & Store the calculated multiple in the array at index i-1.
        }

        return multiples; // return the array of multiples.
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start

        // 1. Calculate the index at which the rotation split happens, which is data.Count - amount.
        int splitIndex = data.Count - amount;

        // 2. Use GetRange to extract the last 'amount' elements starting from the splitIndex.
        List<int> elementsToMove = data.GetRange(splitIndex, amount);

        // 3. Remove the last 'amount' elements from the original list using RemoveRange.
        data.RemoveRange(splitIndex, amount);

        // 4. Insert the extracted elements at the start of the list using InsertRange.
        data.InsertRange(0, elementsToMove);
    }
}
