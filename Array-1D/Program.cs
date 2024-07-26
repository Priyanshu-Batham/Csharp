class ArrayOneDimension {
    public static void Main()
    {
        printArr(rotateBySteps(takeInput(4), 2));
    }

    //1) takes input and returns an array
    static int[] takeInput(int length)
    {
        int[] arr = new int[length];
        Console.WriteLine("Enter " + (length) + " values");
        for (int i = 0; i < length; i++)
        {
            Console.Write("value " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        return arr;
    }

    //2) prints the elements of the given array
    static void printArr(int[] arr)
    {
        Console.Write("Array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
    }

    //3) returns the sum of all elements of array
    static int sumOfElements(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    //4) returns Min & Max value from the array
    static int[] maxMin(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i]) min = arr[i];
            if (max < arr[i]) max = arr[i];
        }

        return [min, max];
    }

    //5) returns a reversed array
    static int[] reverse(int[] arr)
    {
        int[] reversedArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversedArr[i] = arr[arr.Length - 1 - i];
        }
        return reversedArr;
    }

    //6) returns the frequency of element
    static int frequencyOfElement(int[] arr, int element)
    {
        int frequency = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == element) frequency++;
        }
        return frequency;
    }

    //7) returns second largest number
    static int secondLargest(int[] arr)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else
            {
                if (arr[i] > secondLargest) secondLargest = arr[i];
            }
        }

        return secondLargest;
    }

    //8) returns second smallest number
    static int secondSmallest(int[] arr)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = arr[i];
            }
            else
            {
                if (arr[i] < secondSmallest) secondSmallest = arr[i];
            }
        }

        return secondSmallest;
    }

    //9) returns an array of unique values, duplicates are swapped with 0
    static int[] replaceDuplicatesWithZeroes(int[] arr)
    {
        int[] uniques = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (!uniques.Contains(arr[i])) uniques[i] = arr[i];
        }
        return uniques;
    }

    //10) returns a rotated array by no of steps given
    static int[] rotateBySteps(int[] arr, int steps)
    {
        int[] temp = new int[arr.Length];
        int[] rotatedArray = new int[arr.Length];
        Array.Copy(arr, temp, arr.Length);

        while (steps-- != 0)
        {
            for(int i = 0; i< temp.Length; i++) rotatedArray[i] = temp[(i + 1) % arr.Length];
            
            Array.Copy(rotatedArray, temp, rotatedArray.Length);
        }

        return rotatedArray;
    }
}