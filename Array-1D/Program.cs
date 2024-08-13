class ArrayOneDimension {
    public static void Main()
    {
        printArr(selectionSort(takeInput(4)));
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

    //11)
    static int[] squareMatrix(int[] arr)
    {
        for(int i = 0; i<arr.Length; i++)
        {
            arr[i] *= arr[i];
        }
        return arr;
    }

    //12)
    static bool isEvenArr(int[] arr)
    {
        foreach(int num in arr)
        {
            if(num % 2 != 0) return false;
        }
        return true;
    }

    //13)
    static bool isOddArr(int[] arr)
    {
        foreach(int num in arr)
        {
            if(num % 2 == 0) return false;
        }
        return true;
    }

    //14)
    static bool containsZero(int[] arr)
    {
        foreach(int num in arr)
        {
            if (num == 0) return true;
        }
        return false;
    }

    //15) Selection sort
    static int[] selectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length -1; i++)
        {
            for(int j = i+1; j<arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }

    //16) Bubble sort
    static int[] bubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        return arr;
    }

    //17)
    static int oddMinusEvenIndex(int[] arr)
    {
        int odd = 0, even = 0;
        for(int i = 0; i<arr.Length; i++)
        {
            if(i % 2 == 0)
            {
                even += arr[i];
            }
            else
            {
                odd += arr[i];  
            }
        }

        return odd - even;
    }

    //18)
    static int oddMinusEvenValues(int[] arr)
    {
        int odd = 0, even = 0;
        foreach(int num in arr)
        {
            if(num  % 2 == 0)
            {
                even += arr[num];
            }
            else
            {
                odd += arr[num];
            }
        }
        return odd - even;
    }

    //19)
    static int[] negativesToZero(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 0)
            {
                arr[i] = 0;
            }
        }
        return arr;
    }

    //20)
    int balancedIndex(int[] arr)
    {
        int leftSum = 0, rightSum = 0;
        int i = 0, j = arr.Length - 1;
        while(i < j)
        {
            if (leftSum <= rightSum)
            {
                leftSum += arr[i++];
            }
            else
            {
                rightSum += arr[j--];
            }
        }
        return i;
    }
}