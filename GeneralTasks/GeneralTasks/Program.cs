// See https://aka.ms/new-console-template for more information
using System.Text;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

static void DisplaySubstring(int[] arr)
{
    
    for (int SubsLength = 1; SubsLength <= arr.Length; SubsLength++)
    {
        for (int start = 0; start <= arr.Length-SubsLength; start++)
        {
            List<int> list = new List<int>(); 
            int end  = start + SubsLength -1;
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}

static void FindOccurence(int[] arr, int t, int k)
{
    int MinLength = int.MaxValue;
    int counter = 0;
    int FirstOccurence = -1;
    int SecondOccurence = -0;
    int LastOccurence = -1;
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] == t)
        {
            counter++;
        if (counter == 1)
            {
                FirstOccurence = i;
            }
        else if (counter == 2)
            {
                SecondOccurence = i;
                if (k == 2)
                {
                    LastOccurence = i;
                }
            }
        else if (counter == k)
            {
                LastOccurence = i;
            }
        }
        //Console.WriteLine("{0},{1},{2}", FirstOccurence, SecondOccurence, LastOccurence);
        if (counter == k)
        {
            MinLength = Math.Min(MinLength, LastOccurence-FirstOccurence+1);
            i = SecondOccurence;
            LastOccurence = SecondOccurence = - 1;
            counter = 0;
        }
        else
        {
            i++;
        }       
    }
    if (MinLength != int.MaxValue)
    {
        Console.WriteLine(MinLength);
    }
    else
    {
        Console.WriteLine("No such Occurence.");
    }



}

int[] l = {2,1,5,3,13,5,6,5,2,4,7,2,3,9,8,4,1,2,5};

//FindOccurence(l, 5, 2);

static void DuplicateZeros(int[] arr)
{
    int count = 0;
    List<int> arr2 = new List<int>();
    foreach (int num in arr)
    {
        if (num == 0)
        {
            arr2.Add(num);
            arr2.Add(num);
        }
        else
        {
            arr2.Add(num);
        }
    }
    int[] arr3 = arr2.ToArray();
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = arr3[i];
    }

}


static int RemoveElement(int[] nums, int val)
{
    int k = 0;
    int length = nums.Length;
    for (int i = 0; i< length; i++)
    {
        if (nums[i]==val)
        {
            length--;
            for (int j = i; j< length; j++)
            {
                nums[j] = nums[j+1];
            }
            i--;
            k++;
        }
    }
    return (nums.Length-k);
}

