
//Arrayde tek indeksde duran ededlerin hasilini tapin.
#region ArrayTask-1
//int[] numArr = new int[] { 19, 16, 5, 6, 8, 9 };
//int multiply = 1;

//for (int i = 0; i < numArr.Length; i++)
//{
//    if (i % 2 == 1)
//    {
//        multiply *= numArr[i];
//    }

//}
//Console.WriteLine($"Output: {multiply}");
#endregion
//1 soz verilir. Bu sozu tersine ceviren alqoritm yazin. (mes: Ters => sreT)
#region ArrayTask-2
//string word = "jvhhvvgutyHJGFGHFjkn";

//for (int i = 1; i < word.Length + 1; i++)
//{
//    //Console.Write(word[^i]);
//    var rev = word[^i];
//    Console.Write(rev);
//}
#endregion
//Verilmis arrayde ededlerin ededi ortasini tapin.
#region ArrayTask-3
//int[] numArr = new int[] { 19, 16, 5, 6, 8, 9 };
//double sum = 0;
//for (int i = 0; i < numArr.Length; i++)
//{
//    sum += numArr[i];
//}
//double avg = sum / numArr.Length;

//Console.WriteLine($"Output: {avg}");
#endregion

//Arrayin sorting ve searching
#region Bubble Sort
//int[] numArr = new int[] { 19, 16, 15, 6, 8, 9, 12, 21, 24 };
//int temp;

//for (int i = 0; i < numArr.Length; i++)
//{
//    for (int j = 0; j < numArr.Length - 1; j++)
//    {
//        if (numArr[j] > numArr[j + 1])
//        {
//            temp = numArr[j + 1];
//            numArr[j + 1] = numArr[j];
//            numArr[j] = temp;
//        }
//    }
//}
//for (int i = 0; i < numArr.Length; i++)
//{
//    Console.WriteLine(numArr[i]);
//}
#endregion

#region linear Search
//int number = 15;
//for (int i = 0; i < numArr.Length; i++)
//{
//    if (number == numArr[i])
//    {
//        Console.WriteLine($"element arrayde {i}ci indexde yerlesir");

//    }
//    else
//    {
//        Console.WriteLine("eded tapilmadi");
//    }
//}
#endregion

#region Binary Search
//int[] numArr = new int[] { 3, 4, 5, 7, 8, 9, 10, 11 };
//int number = 121;
//int min = 0;
//int max = numArr.Length - 1;

//while (min < max)
//{
//    int midPoint = (max + min) / 2;

//    if (numArr[midPoint] == number)
//    {
//        Console.WriteLine("verilmis eded tapildi");
//        break;
//    }
//    else if (numArr[midPoint] < number)
//    {
//        min = midPoint + 1;
//    }
//    else if (numArr[midPoint] > number)
//    {
//        max = midPoint - 1;
//    }
//}
//Console.WriteLine("verilmis eded tapilmadi");
#endregion

#region Interpolation Search
int[] numArr = new int[] { 3, 4, 5, 7, 8, 9, 10, 11 };
int target = 7;
int max = numArr.Length - 1;
int min = 0;
int pos;
while (min <= max)
{
    pos = (min + (max - min) / (numArr[max] - numArr[min]) * (target - numArr[min]));
    if (numArr[pos] == target)
    {
        Console.WriteLine($"Verilmis eded tapildi! {pos} index yerlesir");
        break;
    }
    else if (numArr[pos] > target)
    {
        max = pos - 1;
    }
    else
    {
        min = pos + 1;
    }
}
#endregion











