using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MathTools
{
    class StateMathTools
    {

        public static ArrayList PowerSet(int[] NullValue, params object[] array)
        {
            ArrayList list = new ArrayList();
            int[] Counter = new int[array.Length];
            object[] temp;
            for (int i = 0; i < array.Length; i++) Counter[i] = i - 1;
            for (int i = 0; i < array.Length; i++)
            {
                temp = new object[i + 1];
                for (int j = 0; j < Combination(array.Length, i + 1); j++)
                {
                    if ((((j + 1) % array.Length) == 1) && (j != 0))
                        for (int r = 1; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int r = 0; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int n = 0; n < temp.Length; n++) temp[n] = array[Counter[n]];
                    list.Add(temp);
                    temp = null;
                }
            }
            list.Add(NullValue);
            return list;
        }

        public static ArrayList PowerSet(string[] NullValue, params string[] array)
        {
            ArrayList list = new ArrayList();
            int[] Counter = new int[array.Length];
            string[] temp;
            for (int i = 0; i < array.Length; i++) Counter[i] = i - 1;
            for (int i = 0; i < array.Length; i++)
            {
                temp = new string[i + 1];
                for (int j = 0; j < Combination(array.Length, i + 1); j++)
                {
                    if ((((j + 1) % array.Length) == 1) && (j != 0))
                        for (int r = 1; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int r = 0; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int n = 0; n < temp.Length; n++) temp[n] = array[Counter[n]];
                    list.Add(temp);
                }
            }
            list.Add(NullValue);
            return list;
        }

        public static ArrayList PowerSet<T>(int NullValue, params int[] array)
        {
            ArrayList list = new ArrayList();
            int[] Counter = new int[array.Length], temp;
            for (int i = 0; i < array.Length; i++) Counter[i] = i - 1;
            for (int i = 0; i < array.Length; i++)
            {
                temp = new int[i + 1];
                for (int j = 0; j < Combination(array.Length, i + 1); j++)
                {
                    if ((((j + 1) % array.Length) == 1) && (j != 0))
                        for (int r = 1; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int r = 0; r < Counter.Length; r++) Counter[r] = (Counter[r] <= (array.Length - 2)) ? Counter[r] += 1 : 0;
                    for (int n = 0; n < temp.Length; n++) temp[n] = array[Counter[n]];
                    list.Add(temp);
                }
            }
            list.Add(NullValue);
            return list;
        }

        public static List<object[]> Permutation(params object[] array) 
        {
            ArrayList list = new ArrayList(array);
            List<object[]> Out = new List<object[]>();
            object temp = new object();
            int n = 0, m = 1, r = 1;
            Out.Add(array);
            for (int i = 1; i < Factorial(array.Length); i++) 
            {
                temp = list[m];
                list.Remove(list[m]);
                list.Insert(n, temp);
                Out.Add(list.ToArray());
                if (m < (array.Length - 1)){m += 1;n += 1;}
                else {m = 1;n = 0;}
            }
            return Out;
        }

        public static List<string[]> Permutation(params string[] array)
        {
            ArrayList list = new ArrayList(array);
            List<string[]> Out = new List<string[]>();
            object temp = new object();
            int n = 0, m = 1, r = 1;
            Out.Add(array);
            for (int i = 1; i < Factorial(array.Length); i++)
            {
                temp = list[m];
                list.Remove(list[m]);
                list.Insert(n, temp);
                Out.Add((string[])list.ToArray(typeof(string[])));
                if (m < (array.Length - 1)) { m += 1; n += 1; }
                else { m = 1; n = 0; }
            }
            return Out;
        }

        public static List<int[]> Permutation(params int[] array)
        {
            ArrayList list = new ArrayList(array);
            List<int[]> Out = new List<int[]>();
            object temp = new object();
            int n = 0, m = 1, r = 1;
            Out.Add(array);
            for (int i = 1; i < Factorial(array.Length); i++)
            {
                temp = list[m];
                list.Remove(list[m]);
                list.Insert(n, temp);
                Out.Add((int[])list.ToArray(typeof(int[])));
                if (m < (array.Length - 1)) { m += 1; n += 1; }
                else { m = 1; n = 0; }
            }
            return Out;
        }

        public static T[,] ReverseMatrix<T>(T[,] t) 
        {
            T[,] t1 = new T[t.GetUpperBound(1) + 1, t.GetUpperBound(0) + 1];
            for (int i = 0; i <= t.GetUpperBound(1); i++)
                for (int j = 0; j <= t.GetUpperBound(0); j++) t1[i, j] = t[j, i];
            return t1;
        }

        public static int Combination(int n, int r) 
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        public static int Factorial(int n)
        {
            n = n == 0 ? 1 : n;
            for (int i = n - 1; i > 0; i--) n *= i;
            return n;
        }

    }
}
