using System;
using Ourcompany;
using MyArray;
/* 3. Implement a routine to print an integer array allowing the options to provide a label and print the array inline or multi-line.
    - Inline: all elements of the array in a single line, separated by commna "," and inside open/close brackets: e.g [1,2,3,4,5]
    - Multi: each element in a new line after the index, the index should be inside brackets.
*/

public class ArrayQuestion03
{
    public static void Main(string[] args)
    {
        int[] firstArray = CopyArray.ReadIntArray("FristArray", 5);
        CopyArray.PrintArray(firstArray, "Inline", true);
        CopyArray.PrintArray(firstArray, "Multiline", false);
    }
}