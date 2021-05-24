using System;

namespace BaseCamp_.NET
{
    class Program
    {

        public void task1() // задача
        {
            int[] result = new int[3];

            int[] class_1a = { 10, 14, 4 };
            int[] class_1b = { 8, 12, 5 };
            int[] class_1v = { 12, 7, 8 };
            int[][] classes = { class_1a, class_1b, class_1v };

            for(int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    result[j] += classes[i][j];
                }
            }

            Console.WriteLine("result: " + result[0] + ' ' + result[1] + ' ' + result[2]);

            float[] percent_A_grade = { (float)class_1a[0] / (class_1a[0] + class_1a[1] + class_1a[2]) * 100, (float)class_1b[0] / (class_1b[0] + class_1b[1] + class_1b[2]) * 100, (float)class_1v[0] / (class_1v[0] + class_1v[1] + class_1v[2]) * 100 };
            float[] percent_B_grade = { (float)class_1a[1] / (class_1a[0] + class_1a[1] + class_1a[2]) * 100, (float)class_1b[1] / (class_1b[0] + class_1b[1] + class_1b[2]) * 100, (float)class_1v[1] / (class_1v[0] + class_1v[1] + class_1v[2]) * 100 };
            float[] percent_C_grade = { (float)class_1a[2] / (class_1a[0] + class_1a[1] + class_1a[2]) * 100, (float)class_1b[2] / (class_1b[0] + class_1b[1] + class_1b[2]) * 100, (float)class_1v[2] / (class_1v[0] + class_1v[1] + class_1v[2]) * 100 };

            Console.WriteLine("percentage by one class:\n\nclass A:\nA grade: " + percent_A_grade[0] + "\nB grade: " + percent_B_grade[0] + "\nC grade: " + percent_C_grade[0]);
            Console.WriteLine("\n\nclass B:\nA grade: " + percent_A_grade[1] + "\nB grade: " + percent_B_grade[1] + "\nC grade: " + percent_C_grade[1]);
            Console.WriteLine("\n\nclass C:\nA grade: " + percent_A_grade[2] + "\nB grade: " + percent_B_grade[2] + "\nC grade: " + percent_C_grade[2]);

            Console.WriteLine("\npercentage by ALL class:\n\nA grade: " + (((float)result[0] / (result[0] + result[1] + result[2])) * 100) + "\nB grade: " + (((float)result[1] / (result[0] + result[1] + result[2])) * 100) + "\nC grade: " + (((float)result[2] / (result[0] + result[1] + result[2])) * 100));
        }

        public bool task2(int a) // чётное или нечётное
        {
            bool result = true;

            if (a % 2 != 0) 
            {
                result = false;
            }

            return result;
        }

        public int task3(int[] arr) // найти элемент посередине трёх
        {
            int result = arr[0];
            int min_elem = arr[0];
            int max_elem = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min_elem)
                {
                    min_elem = arr[i];
                }
                if(arr[i] > max_elem)
                {
                    max_elem = arr[i];
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != min_elem && arr[i] != max_elem)
                {
                    result = arr[i];
                }
            }
            
            return result;
        }

        public void task4(int[] arr) // уникальные элементы
        {
            int j;
            int m;
            int index_result = 0;
            int index_not_unique = 0;
            int arr_length = 0;
            int[] result = new int[arr.Length];
            int[] not_unique = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                j = i + 1;
                for (; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        not_unique[index_not_unique] = arr[i];
                        index_not_unique++;
                        break;
                    }
                }
                if(j == arr.Length)
                {
                    for(m = 0; m < not_unique.Length; m++)
                    {
                        if(arr[i] == not_unique[m])
                        {
                            break;
                        }
                    }
                    if(m == not_unique.Length)
                    {
                        result[index_result] = arr[i];
                        index_result++;
                    }
                }
            }
            for(int i = 0; i < result.Length; i++)
            {
                if(result[i] == 0 && result[i + 1] == 0)
                {
                    break;
                }
                else
                {
                    arr_length++;
                }
            }
            int[] new_result = new int[arr_length];
            Array.Copy(result, 0, new_result, 0, arr_length);
            foreach(int i in new_result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void task5(int[][] arr) // транспонация матрицы
        {
            int[][] result = new int[arr[0].Length][];
            for(int i = 0; i < arr[i].Length; i++)
            {
                result[i] = new int[] { 0, 0, 0, 0 };
            }

            for(int i = 0; i < arr[i].Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    result[i][j] = arr[j][i];
                }
            }
            for (int i = 0; i < arr[i].Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void task6(double num, int quantity_of_numbers) 
        {
            String str_num = num.ToString();
            int index_of_point = str_num.IndexOf('.');
            str_num = str_num.Substring(0, index_of_point + quantity_of_numbers + 1);
            Console.WriteLine(str_num);
        }

        public void task7(double x)
        {
            double y1;
            double y2;

            y1 = 100 * Math.Tan(x) * Math.Sqrt(x) / x;
            y2 = 2 * Math.Sin(x) - 4;
            Console.WriteLine("y1: " + y1 + "\ny2: " + y2);
        }

        public void task8(String str) 
        {
            String str_copy = str;
            int firstIndexOfChar, secondIndexOfChar;

            firstIndexOfChar = str_copy.IndexOf('-');
            str_copy = str_copy.Remove(firstIndexOfChar, 1);
            secondIndexOfChar = str_copy.IndexOf('-');
            str = str.Substring(firstIndexOfChar + 1, secondIndexOfChar - 1);
            Console.WriteLine(str);
        }

        public void task9(String str, String word) // 6, 15
        {
            int index1 = 0;
            int index2 = 0;
            int[] start_end_array = new int[2];
            while(index1 < str.Length)
            {
                if(word[index2] == str[index1])
                {
                    start_end_array[0] = index1;
                    for(int i = 0; i < word.Length-1; i++)
                    {
                        if(word[index2] == str[index1])
                        {
                            index1++;
                            index2++;
                        }
                        else
                        {
                            index2 = 0;
                            while(str[index1] != ' ')
                            {
                                index1++;
                            }
                            break;
                        }
                    }
                    if(index2 == word.Length-1)
                    {
                        start_end_array[1] = index1;
                        break;
                    }
                }
                index1++;
            }
            Console.WriteLine(start_end_array[0] + ", " + start_end_array[1]);
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] arr1 = { 4, 46, 23 };
            int[] arr2 = { 4, 6, 7, 7, 7, 8, 14, 16, 19, 19, 43, 48, 56, 67, 68, 68 };
            int[][] arr3 = new int[][] { new int[]{ 1, 3, 5 }, new int[]{ 2, 4, 6 }, new int[]{ 10, 20, 30 }, new int[]{ 100, 150, 200 } };
            String str = "I-just-wanna-relax";
            String str2 = "Don't exaggerate your feelings";
            String word = "your";

            pr.task1();
            Console.WriteLine(pr.task2(5));
            Console.WriteLine(pr.task3(arr1));
            Console.WriteLine("-----------------------------");
            pr.task4(arr2);
            Console.WriteLine("-----------------------------");
            pr.task5(arr3);
            pr.task6(146.9375747463, 6);
            pr.task7(0.436);
            pr.task8(str);
            pr.task9(str2, word);

            Console.ReadKey();
        }
    }
}
