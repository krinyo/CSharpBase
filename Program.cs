using System;

namespace CSharpBase 
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //VALUE TYPES
            sbyte num1 = -128;
            byte num2 = 255;

            short num3 = -32768;
            ushort num4 = 65535;

            int num5 = -2147483648;
            uint num6 = 4294967295;

            long num7 = -9223372036854775808;
            ulong num8 = 18446744073709551615;

            float num9 = 0.000001123F;
            double num10 = 0.000000000000001;

            char ch1 = 'A';

            bool b1 = false;

            /*
             *      decimal: Представляет десятичное число с высокой точностью, которое часто используется в финансовых вычислениях, где точность крайне важна1.
                    dynamic: Позволяет обходить статическую проверку типов во время компиляции1.
                    nint и nuint: Это типы, которые представляют целые числа, размер которых зависит от платформы (32 бита на 32-битных платформах и 64 бита на 64-битных платформах)1.
             */

            //REFERENCE TYPES
            string str1 = "BoY NExT DooR";

            
            Console.WriteLine("SBYTE:{0} BYTE:{1}\nSHORT:{2} USHORT:{3}\n" +
                "INT:{4} UINT:{5}\nLONG:{6} ULONG:{7}\nFLOAT:{8}\n" +
                "DOUBLE:{9}\nCHAR:{10}\nBOOL:{11}\nSTRING:{12}",
                num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, ch1, b1, str1);


            //COLLECTIONS

            int[] array = new int[5]; // Объявление массива из 5 элементов

            List<int> list = new List<int>(); // Объявление списка

            Dictionary<string, int> dictionary = new Dictionary<string, int>(); // Объявление словаря
            Stack<int> stack = new Stack<int>(); // Объявление стека
            Queue<int> queue = new Queue<int>(); // Объявление очереди
            HashSet<int> hashSet = new HashSet<int>(); // Объявление хэш-сета
            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "example", true); // Объявление кортежа


            Console.ReadLine();
        }
    }
}
