using System;

namespace CSharpBase
{
    #region TYPES
    public class Types
    {
        //VALUE TYPES
        static sbyte num1 = -128;
        static byte num2 = 255;

        static short num3 = -32768;
        static ushort num4 = 65535;

        static int num5 = -2147483648;
        static uint num6 = 4294967295;

        static long num7 = -9223372036854775808;
        static ulong num8 = 18446744073709551615;

        static float num9 = 0.000001123F;
        static double num10 = 0.000000000000001;

        static char ch1 = 'A';

        static bool b1 = false;

        /*
         *      decimal: Представляет десятичное число с высокой точностью, которое часто используется в финансовых вычислениях, где точность крайне важна1.
                dynamic: Позволяет обходить статическую проверку типов во время компиляции1.
                nint и nuint: Это типы, которые представляют целые числа, размер которых зависит от платформы (32 бита на 32-битных платформах и 64 бита на 64-битных платформах)1.
         */
        //REFERENCE TYPES
        static string str1 = "BoY NExT DooR";

        public static void ShowTypes()
        {
            Console.WriteLine("SBYTE:{0} BYTE:{1}\nSHORT:{2} USHORT:{3}\n" +
                                "INT:{4} UINT:{5}\nLONG:{6} ULONG:{7}\nFLOAT:{8}\n" +
                                "DOUBLE:{9}\nCHAR:{10}\nBOOL:{11}\nSTRING:{12}",
                                num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, ch1, b1, str1);

        }

    }
    #endregion

    #region COLLECTIONS
    public class Collections
    {
        //COLLECTIONS

        //Array static
        int[] arrayy = new int[5] { 1, 2, 3, 4, 5 };
        public void ArrayMethods()
        {
            // Добавление элемента в массив
            arrayy[0] = 6;

            // Получение длины массива
            int length = arrayy.Length;
        }

        //List dynamic
        List<int> listt = new List<int>() { 1, 2, 3 };
        public void ListMethods()
        {
            // Добавление элемента в список
            listt.Add(4);

            // Удаление элемента из списка
            listt.Remove(1);

            // Получение количества элементов в списке
            int count = listt.Count;
        }

        //Dictionary dynamic
        Dictionary<string, int> dictionaryy = new Dictionary<string, int>() { { "one", 1 }, { "two", 2 }, { "three", 3 } };
        public void DictionaryMethods()
        {
            // Добавление элемента в словарь
            dictionaryy.Add("four", 4);

            // Удаление элемента из словаря
            dictionaryy.Remove("one");

            // Получение количества элементов в словаре
            int count = dictionaryy.Count;
        }

        //Stack dynamic
        Stack<int> stackk = new Stack<int>();
        public void StackMethods()
        {
            // Добавление элемента в стек
            stackk.Push(1);

            // Удаление элемента из стека
            int poppedElement = stackk.Pop();

            // Получение количества элементов в стеке
            int count = stackk.Count;
        }

        //Queue dynamic
        Queue<int> queuee = new Queue<int>();
        public void QueueMethods()
        {
            // Добавление элемента в очередь
            queuee.Enqueue(1);

            // Удаление элемента из очереди
            int dequeuedElement = queuee.Dequeue();

            // Получение количества элементов в очереди
            int count = queuee.Count;
        }

        //HashSet dynamic faster search operations
        //HashSet<string> names = new HashSet<string>() { "Alice", "Bob", "Charlie" };
        //bool containsAlice = names.Contains("Alice"); // Быстрый поиск
        HashSet<int> hashSett = new HashSet<int>();
        public void HashSetMethods()
        {
            // Добавление элемента в хэш-сет
            hashSett.Add(1);

            // Удаление элемента из хэш-сета
            hashSett.Remove(1);

            // Получение количества элементов в хэш-сете
            int count = hashSett.Count;
        }

        //Tuple static
        Tuple<int, string, bool> tuplee = new Tuple<int, string, bool>(1, "example", true);
        public void TupleMethods()
        {
            // Создание кортежа
            Tuple<int, string, bool> tuplee = new Tuple<int, string, bool>(1, "example", true);

            // Получение элементов кортежа
            int item1 = tuplee.Item1;
            string item2 = tuplee.Item2;
            bool item3 = tuplee.Item3;
        }
    }
    #endregion

    #region CYCLES AND CONDITIONS
    public class CyclesAndConditionals
    {
        // Conditionals
        public void ConditionalStatements(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("x is positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("x is negative");
            }
            else
            {
                Console.WriteLine("x is zero");
            }

            // switch
            switch (x)
            {
                case 1:
                    Console.WriteLine("x is one");
                    break;
                case 2:
                    Console.WriteLine("x is two");
                    break;
                default:
                    Console.WriteLine("x is neither one nor two");
                    break;
            }
        }

        // for cycle break continue
        public void ForLoop(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 2)
                {
                    continue; // skip iteration
                }

                Console.WriteLine(i);

                if (i == 4)
                {
                    break; // stops cycle
                }
            }
        }

        // while
        public void WhileLoop(int n)
        {
            while (n > 0)
            {
                Console.WriteLine(n);
                n--;
            }
        }

        // do-while
        public void DoWhileLoop(int n)
        {
            do
            {
                Console.WriteLine(n);
                n--;
            } while (n > 0);
        }

        // foreach
        public void ForeachLoop(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
    #endregion

    #region EXCEPTIONS HANDLING
    public class ExceptionHandling
    {
        // Try-Catch-Finally
        public void TryCatchFinallyExample()
        {
            try
            {
                // Code that could throw an exception
                int x = 0;
                int y = 5 / x;
            }
            catch (DivideByZeroException ex)
            {
                // Code to handle the exception
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                // Code to be executed regardless of whether an exception was thrown
                Console.WriteLine("This code block is always executed");
            }
        }

        // Throwing an exception
        public void ThrowExceptionExample()
        {
            throw new InvalidOperationException("This is an example of throwing an exception");
        }

        // Rethrowing an exception
        public void RethrowExceptionExample()
        {
            try
            {
                // Code that could throw an exception
                int x = 0;
                int y = 5 / x;
            }
            catch (DivideByZeroException ex)
            {
                // Rethrow the exception
                throw;
            }
        }
    }
    #endregion


    #region DELEGATES AND EVENTS
    public class DelegatesAndEvents
    {
        // Делегат - это тип, который безопасно инкапсулирует метод
        public delegate void MyDelegate(string message);

        // Событие - это способ, которым объект может уведомлять другие объекты, когда что-то происходит
        public event MyDelegate MyEvent;

        public void InvokeDelegate()
        {
            MyDelegate del = new MyDelegate(Handler);
            del("Hello from delegate");
        }

        public void InvokeEvent()
        {
            MyEvent += Handler;
            MyEvent("Hello from event");
        }

        private void Handler(string message)
        {
            Console.WriteLine(message);
        }
    }

    //Event and delegate example

    public class LightController
    {
        // Свойство для отслеживания состояния света
        public bool IsLightOn { get; private set; }

        public delegate void LightStateHandler(object sender, EventArgs e);
        public event LightStateHandler? LightState;

        public void OnChangeLight(EventArgs e)
        {
            // Переключение состояния света
            IsLightOn = !IsLightOn;
            LightState?.Invoke(this, e);
        }

        public void InitiationMethod()
        {
            while (true)
            {
                Thread.Sleep(3600000); // Пауза на 1 час
                OnChangeLight(EventArgs.Empty);
            }
        }
    }

    public class UserInterface
    {
        public void Subscribe(LightController lc)
        {
            lc.LightState += new LightController.LightStateHandler(OnLightState);
        }

        private void OnLightState(object sender, EventArgs e)
        {
            // Доступ к состоянию света через отправителя
            LightController lc = (LightController)sender;
            string lightState = lc.IsLightOn ? "включен" : "выключен";

            Console.WriteLine($"Состояние света в пользовательском интерфейсе изменилось на {lightState}");
        }
    }

    #endregion

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.ReadLine();
        }
    }

}

