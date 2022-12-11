using SortArrayEg;
using System.Linq;
//Sort 1D int array
int[] singleDimensionalArr = new int[] { 2, 1, 55, 11, 4, 7, 8 };
SortArray.Sort1DIntArray(singleDimensionalArr);
PrintOutputFor1DArray(singleDimensionalArr);

//Sort 1D string array
string[] singleDimensionalStringArr = new string[] { "Carrot", "Apple", "Grapes", "Banana", "Avocado", "Grapefruit", "Beetroot" };
SortArray.Sort1DStringArray(singleDimensionalStringArr);
PrintOutputFor1DArray(singleDimensionalStringArr);
//2dArray- Jagged Array
int[][] a = new int[][] {
                        new int[]{27,25,99},
                        new int[]{33,12,22},
                        new int[]{13,11,19},
                        new int[]{33,12,21}
                         };

int[] aa = new int[3] { 10, 12, 13 };
a[0] = aa;
Console.WriteLine(a);
//SortArray.SortJaggedArray(a);
//PrintOutputFor2DArray(a);
//rectangular array
int[,] a1 = new int[,] { { 12, 01 }, { 10, 13 }, { 19, 27 }, { 13, 11 } };
int[] idTrackingArray = new int[] { 0, 1, 2, 3 };
a1 = SortArray.SortMultiDimensionalArray(a1, idTrackingArray);
PrintOutputFor2DRectangularArray(idTrackingArray, a1);

//rectangular array to jagged array
/*
int[,] a2 = new int[,] { { 10, 13,22 }, { 12, 01,11 }, { 13, 11,56 }, { 19, 27,61 } , { 11, 22, 33 } , { 99, 27, 51 } };
int [][]convertedToJaggedArray=SortArray.ConvertMultiDimensionalArrayToJaggedArray(a2);
PrintOutputFor2DArray(convertedToJaggedArray);*/
//PrintOutputFor1DArray<int>(singleDimensionalArr);
//PrintOutputFor1DArray<string>(singleDimensionalStringArr);

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

