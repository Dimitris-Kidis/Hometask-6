// # Hometask #6

// 1. Create two functions with one-dimensional array ✅
// 2. Create two functions with multi-dimensional array ✅
// 3. Create two functions for modifying string ✅
// 4. Create two functions using StringBuilder
// 5. Create a program using SPLIT / JOIN methods ✅


using System;

public class App
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ArraysAndStrings.RevertString("THE PLANET EARTH"));


        Console.WriteLine(ArraysAndStrings.GetTheThirdWord("THE PLANET EARTH"));


        Console.WriteLine(ArraysAndStrings.ChangeTwoWords("THE PLANET EARTH IS THE BEST", 2));


        int[,] arr = ArraysAndStrings.ConcatenateTwoIntArrays(new int[3] { 5, 3, 2 }, new int[3] { 4, 5, 6 });
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("The sum of a two-dimensional array: " + ArraysAndStrings.GetSumOfMultidimensionalArray(arr));
        
    }
}

class ArraysAndStrings
{
    public static string RevertString (string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static string GetTheThirdWord (string str)
    {
        string[] words = str.Split(' ');
        return words[2];
    }

    public static string ChangeTwoWords (string str, int i)
    {
        string[] words = str.Split(' ');
        string tmp = words[i];
        words[i] = words[i+1];
        words[i+1] = tmp;
        return string.Join(" ", words);
    }

    public static int[,] ConcatenateTwoIntArrays(int[] arr1, int[] arr2)
    {
        int[,] arr = new int[2, arr2.Length];
        for(int i = 0; i < arr1.Length; i++)
        {
            arr[0, i] = arr1[i];
            arr[1, i] = arr2[i];
        }
        return arr;
    }

    public static int GetSumOfMultidimensionalArray (int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }

        return sum;
    }
}