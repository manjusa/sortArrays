using SortArrayEg;
using System.Linq;
//Sort 1D int array
/*int[] singleDimensionalArr = new int[] { 2, 1, 55, 11, 4, 7, 8 };
SortArray.Sort1DIntArray(singleDimensionalArr);
PrintOutputFor1DArray(singleDimensionalArr);

//Sort 1D string array
string[] singleDimensionalStringArr = new string[] { "Carrot", "Apple", "Grapes", "Banana", "Avocado", "Grapefruit", "Beetroot" };
SortArray.Sort1DStringArray(singleDimensionalStringArr);
PrintOutputFor1DArray(singleDimensionalStringArr);

//2dArray- Jagged Array - can reference any item as an array by itself
//here replacing 0th element of a array and replacing it with another int
//array
int[][] a = new int[][] {
                        new int[]{27,25,99},
                        new int[]{33,12,22},
                        new int[]{13,11,19},
                        new int[]{33,12,21}
                         };

int[] aa = new int[3] { 10, 12, 13 };
a[0] = aa;
Console.Write("item in array replaced:");
PrintOutputFor2DArray(a);//prints  { 10, 12, 13 },{33,12,22},{13,11,19},{33,12,21}

a = new int[][] {
                        new int[]{27,25,99},
                        new int[]{33,12,22},
                        new int[]{13,11,19},
                        new int[]{33,12,21}
                         };
//Sort Jagged array by first/second/or first non matching column
Console.WriteLine("before sorting by FIRST");
PrintOutputFor2DArray(a);
SortArray.SortJaggedArray(a, "FIRST");
Console.WriteLine("output for sort by FIRST column");
PrintOutputFor2DArray(a);
Console.WriteLine("-----RESET-----");
Console.WriteLine("before sorting by SECOND");
a = new int[][] {
                        new int[]{27,25,99},
                        new int[]{33,12,22},
                        new int[]{13,11,19},
                        new int[]{33,12,21}
                         };
PrintOutputFor2DArray(a);
SortArray.SortJaggedArray(a, "SECOND");
Console.WriteLine("output for sort by SECOND column");
PrintOutputFor2DArray(a);
Console.WriteLine("----RESET------");
Console.WriteLine("before sorting by FIRST NON MATCHING COLUMN");
a = new int[][] {
                        new int[]{27,25,99},
                        new int[]{33,12,22},
                        new int[]{13,11,19},
                        new int[]{33,12,21}
                         };
PrintOutputFor2DArray(a);
SortArray.SortJaggedArray(a, "FIRST-NON-MATCHING");
Console.WriteLine("output for sort by FIRST-NON-MATCHING column");
PrintOutputFor2DArray(a);*/

//Rectangular array
/*int[,] a1 = new int[,] { { 12, 01 }, { 10, 13 }, { 19, 27 }, { 13, 11 } };
int[] idTrackingArray = new int[] { 0, 1, 2, 3 };
a1 = SortArray.SortMultiDimensionalArray(a1, idTrackingArray,"FIRST");
PrintOutputFor2DRectangularArray(idTrackingArray, a1);
Console.WriteLine("output for sort by FIRST column");
PrintOutputFor2DRectangularArray(idTrackingArray, a1);
Console.WriteLine("-----RESET-----");

a1 = new int[,] { { 12, 01 }, { 10, 13 }, { 19, 27 }, { 13, 11 } };//reset
PrintOutputFor2DRectangularArray(idTrackingArray, a1);
a1 = SortArray.SortMultiDimensionalArray(a1, idTrackingArray, "SECOND");
Console.WriteLine("output for sort by SECOND column");
PrintOutputFor2DRectangularArray(idTrackingArray, a1);
Console.WriteLine("-----RESET----");*/


//CONVERT rectangular array to jagged array
/*
int[,] a2 = new int[,] { { 10, 13, 22 }, { 12, 01, 11 }, { 13, 11, 56 }, { 19, 27, 61 }, { 11, 22, 33 }, { 99, 27, 51 } };
Console.WriteLine("original rectangular array");
int[] idTrackingArray1 = new int[] { 0, 1, 2, 3 ,4, 5};
PrintOutputFor2DRectangularArray(idTrackingArray1, a2);
int[][] convertedToJaggedArray = SortArray.ConvertMultiDimensionalArrayToJaggedArray(a2);
Console.WriteLine("output of convert from rectangular array to jagged array");
PrintOutputFor2DArray(convertedToJaggedArray);*/


static void PrintOutputFor2DRectangularArray(int[] tagArray, int[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); i++)
    {
        for (int j = 0; j < a1.GetLength(1); j++)
        {

            int s = a1[tagArray[i], j];
            Console.Write(s + " ");
        }
        Console.Write("\n");
    }
}


static void PrintOutputFor1DArray<T>(T[] sortedSingleDimensionalArr)
{
    for (var i = 0; i < sortedSingleDimensionalArr.Length; i++)
    {
        Console.WriteLine(sortedSingleDimensionalArr[i]);
    }
}


//Print output for jagged array
static void PrintOutputFor2DArray<T>(T[][] twoDimensionalArr)
{
    for (var i = 0; i < twoDimensionalArr.Length; i++)
    {
        var j = twoDimensionalArr[i].Length;
        for (var k = 0; k < j; k++)
        {
            Console.Write(twoDimensionalArr[i][k]);
            Console.Write(" ");

        }
        Console.WriteLine("");
    }
}

