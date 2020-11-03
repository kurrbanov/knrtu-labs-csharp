using System;
using System.Collections.Generic;

namespace laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4};
            Set s1 = new Set(a);
            Set s2 = new Set();

            Set s3 = s1 + s2;
            s3.ShowSet();
            Set s4 = s1 * s2;
            s4.ShowSet();
            Set s5 = s1 / s2;
            s5.ShowSet();

            if (s1 > s2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.WriteLine(s1[1]);
        }
    }

    public class Set
    {
        public int n;
        int[] arr;

        public Set()
        {
            Console.WriteLine("Введите количество элементов в множестве: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Значение не может быть отрицательным");
                return;
            }

            arr = Fill();
        }

        public Set(int[] a)
        {
            n = a.Length;
            arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = a[i];
        }


        public int[] Fill()
        {
            int[] a = new int[n];
            Dictionary<int, bool> d = new Dictionary<int, bool>();

            Console.WriteLine("Введите элементы множества: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

                while (d.ContainsKey(a[i]))
                {
                    Console.WriteLine("Введите другой элемент: ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                d[a[i]] = true;
            }

            Array.Sort(a);
            return a;
        }

        public int indexOf(int Value)
        {
            int l = 0, r = n;

            while (r - l > 1)
            {
                int m = (l + r) / 2;
                if (arr[m] <= Value) l = m;
                else r = m;
            }

            if (arr[l] == Value) return l;
            return -1;
        }

        public void ShowSet()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }

        public void Add(int NewElement)
        {
            if (indexOf(NewElement) == -1)
            {
                Array.Resize(ref arr, n + 1);
                arr[n] = NewElement;
                n++;
            }
        }

        public static Set operator ++(Set set1)
        {
            for (int i = 0; i < set1.n; i++)
            {
                set1.arr[i]++;
            }

            return set1;
        }

        public static Set operator +(Set set1, Set set2)
        {
            int[] a = new int[set1.arr.Length];
            int k = set1.arr.Length;

            for (int i = 0; i < set1.arr.Length; i++)
            {
                a[i] = set1.arr[i];
            }

            for (int i = 0; i < set2.arr.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < set1.arr.Length; j++)
                {
                    if (set1.arr[j] == set2.arr[i])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    Array.Resize(ref a, k + 1);
                    a[k] = set2.arr[i];
                    k++;
                }
            }
            
            var ans = new Set(a);
            return ans;
        }

        public static Set operator *(Set set1, Set set2)
        {
            int count = 0;
            int[] res = new int[0];
            
            for (int i = 0; i < set1.arr.Length; i++)
            {
                for (int j = 0; j < set2.arr.Length; j++)
                    if (set1.arr[i] == set2.arr[j])
                    {
                        Array.Resize(ref res, count + 1);
                        res[count] = set1.arr[i];
                        count++;
                        break;
                    }
            }
            
            var ans = new Set(res);
            return ans;
        }

        public static Set operator /(Set set1, Set set2)
        {
            int count = 0;
            int[] res = new int[0];
            
            for (int i = 0; i < set1.arr.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < set2.arr.Length; j++)
                    if (set1.arr[i] == set2.arr[j])
                    {
                        flag = true;
                        break;
                    }

                if (!flag)
                {
                    Array.Resize(ref res, count + 1);
                    res[count] = set1.arr[i];
                    count++;
                }
            }

            var ans = new Set(res);
            return ans;            
        }

        public static bool operator <(Set set1, Set set2)
        {
            return set1.arr.Length < set2.arr.Length;
        }

        public static bool operator >(Set set1, Set set2)
        {
            return set1.arr.Length > set2.arr.Length;
        }

        public int this[int index]
        {
            get { return arr[index]; }
        }
    }
}