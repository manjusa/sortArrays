using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayEg
{
    public class SortArray
    {
        public static int[] Sort1DIntArray(int[]a)
        {
            Array.Sort(a);
            return a;

        }
        public static string[] Sort1DStringArray(string[] a)
        {
            Array.Sort(a);
            return a;
        }
        
        public static int[][] SortJaggedArray(int[][] a)
        {
            CustomSortComparerOptions cs = new CustomSortComparerOptions();
            Array.Sort(a, CustomSortComparerOptions.SortByFirstNotEqualColumn());
            return a;
        }
        public static int[,] SortMultiDimensionalArray(int[,] a,int[] trackerArray)
        {            
            RectangularComparerOptions rs = new RectangularComparerOptions(a);
            Array.Sort(trackerArray, rs.SortBySecondColumn(a));
            return a;
        }
        public static int [][] ConvertMultiDimensionalArrayToJaggedArray(int[,] a)
        {
            int[][] myJaggedArray = new int[a.GetUpperBound(0) + 1][];
            for (int i = 0; i < myJaggedArray.Length; i++)
                myJaggedArray[i] = Enumerable.Range(0, a.GetUpperBound(1) + 1).Select(k => a[i, k]).ToArray();
            return myJaggedArray;
        }

    }
}
