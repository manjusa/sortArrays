using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayEg
{
   public class CustomSortComparerOptions
    {
        private class SortByFirstNotEqualColumnHelper : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                int[] a1 = (int[])x;
                int[] a2 = (int[])y;
                for (var i = 0; i < a1.Length; i++)
                {
                    for (var j = i; i < a2.Length; j++)
                    {
                        if (a1[i] != (a2[j]))
                        {
                            return (a1[i].CompareTo(a2[j]));

                        }
                        else
                        {
                            break;
                        }

                    }

                }
                return -1;
            }
        }
        private class SortBySecondColumnHelper : IComparer
        {
            int IComparer.Compare(object? x, object? y)
            {
                int[] a1 = (int[])x;
                int[] a2 = (int[])y;
                return (a1[1].CompareTo(a2[1]));
            }
        }
        private class SortByFirstColumnHelper : IComparer
        {
            int IComparer.Compare(object? x, object? y)
            {
                int[] a1 = (int[])x;
                int[] a2 = (int[])y;
                return (a1[0].CompareTo(a2[0]));
            }
        }
        public static IComparer SortBySecondColumn()
        {

            return (IComparer)new SortBySecondColumnHelper();
        }
        public static IComparer SortByFirstColumn()
        {

            return (IComparer)new SortByFirstColumnHelper();
        }
        public static IComparer SortByFirstNotEqualColumn()
        {

            return (IComparer)new SortByFirstNotEqualColumnHelper();
        }

        
    }    

}
