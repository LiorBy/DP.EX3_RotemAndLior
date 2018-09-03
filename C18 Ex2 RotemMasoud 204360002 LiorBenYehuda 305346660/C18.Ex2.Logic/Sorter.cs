using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C18.Ex2.Logic
{
    public class Sorter
    {
        /// use a delegate to a method as the strategy:
        public Func<User, User, bool> ComparerMethod { get; set; }

        public Sorter(Func<User, User, bool> i_ComparerMethod)
        {
            ComparerMethod = i_ComparerMethod;
        }

        public void Sort(User[] i_Array)
        {
            for (int g = i_Array.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Array.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (ComparerMethod.Invoke(i_Array[j] , i_Array[j + g]))
                        {
                            doSwap(ref i_Array[j], ref i_Array[j + g]);
                        }
                    }
                }
            }
        }

        private void doSwap<T>(ref T io_Num1, ref T io_Num2)
        {
            T temp = io_Num1;
            io_Num1 = io_Num2;
            io_Num2 = temp;
        }

    }
}
