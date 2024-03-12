//Task - 1
//Ədədlərdən ibarət array qəbul edən method yazın.
//Array sort metoduna uyğun CustomSort(int[] arr) metodunu yazın.

int[] nums = { 15, 3, 9, 11, 2, 17, 10, 33 };

Arr(nums);
static void Arr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int x = array[i];
                array[i] = array[j];
                array[j] = x;
            }
        }
    }
    Console.WriteLine("{0}", string.Join(", ", array));
}

// Task - 2
// Stringlerden ibaret array-i və char qəbul edən metod yazın.
// Arrayin hansi index-də bu qəbul edilən char varsa, o string-ləri ekranda yazdirin


string[] sozler = { "BMV", "KIA", "Mercedes" };

soz(sozler, 'm');
static void soz(string[] sozler, char herf)
{
    for (int i = 0; i < sozler.Length; i++)
    {
        for (int j = 0; j < sozler[i].Length; j++)
        {
            if (sozler[i].ToLower()[j] == herf)
            {
                Console.WriteLine(sozler[i]);
                break;
            }
        }
    }
}


// Task - 3
// Ədədlərdən ibarət array qəbul edən method yazın.
// Array reverse metoduna uyğun CustomReverse(int[] arr) metodunu yazın.



int[] ededler = { 5, 17, 33, 99, 11 };

CustomReverse(ededler);
static void CustomReverse(int[] arr)
{
    for (int i = arr.Length - 1; i > -1; i--)
    {
        Console.WriteLine(arr[i]);
    }
}

