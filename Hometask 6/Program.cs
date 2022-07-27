// # Hometask #6

// 1. Create two functions with one-dimensional array ✅
// 2. Create two functions with multi-dimensional array ✅
// 3. Create two functions for modifying string ✅
// 4. Create two functions using StringBuilder ✅
// 5. Create a program using SPLIT / JOIN methods ✅


using System;
using System.Text;
using System.Text.RegularExpressions;

public class App
{
    public static void Main(string[] args)
    {
        string testString = "The planet Earth is the best";
        
        ArraysAndStrings.Init();
        
        Console.WriteLine(ArraysAndStrings.RevertString(testString));


        Console.WriteLine(ArraysAndStrings.GetTheThirdWord(testString));


        Console.WriteLine(ArraysAndStrings.ChangeTwoWords(testString, 2));


        int[,] arr = ArraysAndStrings.ConcatenateTwoIntArrays(new int[3] { 5, 3, 2 }, new int[3] { 4, 5, 6 });
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("The sum of a two-dimensional array: " + ArraysAndStrings.GetSumOfMultidimensionalArray(arr) + "\n");
        
        string mystring = null;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter your input: ");
        Console.ForegroundColor = ConsoleColor.White;
        mystring = Console.ReadLine();
        ArraysAndStrings.CheckEmail(mystring);
        
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
    
    public static void Init() 
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello ");
        sb.AppendLine("World!");
        sb.AppendLine("Hello C#");
        sb.Insert(11, "!!!!!!!");
        sb.Remove(12, 7);
        Console.WriteLine(sb);
    }
    
    public static bool CheckEmail (string email) 
    {
        StringBuilder sb = new StringBuilder("Your email (" + email + ") is ");
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email);
        if (match.Success) {
            sb.Append("correct!");
            Console.WriteLine(sb);
            return true;
        } else {
            sb.Append("incorrect!");
            sb.AppendLine("Try once again...");
            Console.WriteLine(sb);
            return false;
        }
    }
}
