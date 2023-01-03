using System;
using System.Collections;


namespace SortArrayEg
{
    public class RectangularComparerOptions
    {
        // maintain a reference to the 2-dimensional array being sorted
        public int[,] sortArray;

        // constructor initializes the sortArray reference
        public RectangularComparerOptions(int[,] theArray)
        {
            sortArray = theArray;
        }
       class SortByFirstColumnHelper : IComparer
        {
            RectangularComparerOptions r_;

            public SortByFirstColumnHelper()
            {
            }

            public SortByFirstColumnHelper(RectangularComparerOptions r1)
            {
                r_=r1;
            }
           
            public int Compare(object x, object y)
            {
                // x and y are integer row numbers into the sortArray
                int i1 = (int)x;
                int i2 = (int)y;
                // compare the items in the sortArray
                return (r_.sortArray[i1, 0].CompareTo(r_.sortArray[i2, 0]));
            }
        }
        class SortBySecondColumnHelper : IComparer
        {
            RectangularComparerOptions r_;

            public SortBySecondColumnHelper()
            {
            }

            public SortBySecondColumnHelper(RectangularComparerOptions r1)
            {
                r_ = r1;
            }

            public int Compare(object x, object y)
            {
                // x and y are integer row numbers into the sortArray
                int i1 = (int)x;
                int i2 = (int)y;
                // compare the items in the sortArray
                return (r_.sortArray[i1, 1].CompareTo(r_.sortArray[i2, 1]));
            }
        }
        
        public IComparer SortByFirstColumn(int[,] a)
        {
            return (IComparer)new SortByFirstColumnHelper(this);
        }
        public IComparer SortBySecondColumn(int[,] a)
        {
            return (IComparer)new SortBySecondColumnHelper(this);
        }
       

    }
}
