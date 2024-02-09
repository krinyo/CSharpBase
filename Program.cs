using Microsoft.EntityFrameworkCore;
using System.Text;

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

    #region DELEGATES AND EVENTS*
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

    #region LINQ EXAMPLES
    //using System.Linq;
    public class LinqExamples
    {

        // LINQ Query
        public void LinqQuery(int[] numbers)
        {
            // LINQ query that sorts the numbers in ascending order
            var sortedNumbers = from number in numbers
                                orderby number
                                select number;

            // Output the sorted numbers
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }

        // LINQ Method Syntax
        public void LinqMethodSyntax(int[] numbers)
        {
            // Use LINQ method syntax to sort the numbers in ascending order
            var sortedNumbers = numbers.OrderBy(number => number);

            // Output the sorted numbers
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
        /*
        // 'Where' filters the collection based on a condition
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        // 'Select' projects each element of a sequence into a new form
        var squares = numbers.Select(n => n * n);

        // 'OrderBy' sorts the elements of a sequence in ascending order
        var orderedNumbers = numbers.OrderBy(n => n);

        // 'OrderByDescending' sorts the elements of a sequence in descending order
        var orderedNumbersDesc = numbers.OrderByDescending(n => n);

        // 'First' returns the first element of a sequence
        var firstNumber = numbers.First();

        // 'FirstOrDefault' returns the first element of a sequence, or a default value if no element is found
        var firstOrDefaultNumber = numbers.FirstOrDefault();

        // 'Single' returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence
        var singleNumber = numbers.Single(n => n == 5);

        // 'SingleOrDefault' returns the only element of a sequence, or a default value if no element is found. This method throws an exception if there is more than one element in the sequence
        var singleOrDefaultNumber = numbers.SingleOrDefault(n => n == 5);

        // 'Count' returns the number of elements in a sequence
        var count = numbers.Count();

        // 'Any' checks if any elements in a sequence satisfy a condition
        var hasEvenNumbers = numbers.Any(n => n % 2 == 0);

        // 'All' checks if all elements in a sequence satisfy a condition
        var allEvenNumbers = numbers.All(n => n % 2 == 0);

        // 'Contains' checks if a sequence contains a specified element
        var containsFive = numbers.Contains(5);

        // 'Aggregate' applies a function to each element of a sequence and returns the final result
        var product = numbers.Aggregate((a, b) => a * b);

        // 'Sum' calculates the sum of a sequence of numeric values
        var sum = numbers.Sum();

        // 'Average' calculates the average of a sequence of numeric values
        var average = numbers.Average();

        // 'Max' returns the maximum value in a sequence of numeric values
        var max = numbers.Max();

        // 'Min' returns the minimum value in a sequence of numeric values
        var min = numbers.Min();

        // 'GroupBy' groups the elements of a sequence according to a specified key selector function
        var wordGroups = words.GroupBy(w => w.First());
        */
    }
    #endregion

    #region ASYNC PROGRAMMING*
    public class AsyncProgramming
    {
        // Asynchronous method to get the content from a URL
        public async Task<string> FetchDataFromUrlAsync(string url)
        {
            // HttpClient is used to send HTTP requests and receive HTTP responses
            using (HttpClient client = new HttpClient())
            {
                // Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation
                string result = await client.GetStringAsync(url);

                return result;
            }
        }

        public async Task RunAsync()
        {
            try
            {
                // Call the FetchDataFromUrlAsync method asynchronously and wait for the result
                string result = await FetchDataFromUrlAsync("https://example.com");

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                // Handle any exceptions that occurred during the execution of the FetchDataFromUrlAsync method
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
    #endregion *

    #region ORM Entity Framework
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Другие свойства...
    }
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connectionstring");
        }
        public static void GetUsers()
        {
            using (var context = new MyDbContext())
            {
                // LINQ запрос для получения всех пользователей
                var users = context.Users.ToList();

                foreach (var user in users)
                {
                    Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
                }
            }
        }
    }

    #endregion

    #region NETWORK(basebase)
    /*
         public static void Main()
    {
        TcpListener server = null;
        try
        {
            // Set the TcpListener on port 13000.
            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(localAddr, port);

            // Start listening for client requests.
            server.Start();

            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;

            // Enter the listening loop.
            while(true)
            {
                Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                TcpClient client = server.AcceptTcpClient();            
                Console.WriteLine("Connected!");

                data = null;

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                int i;

                // Loop to receive all the data sent by the client.
                while((i = stream.Read(bytes, 0, bytes.Length))!=0)
                {   
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", data);

                    // Process the data sent by the client.
                    data = data.ToUpper();

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    // Send back a response.
                    stream.Write(msg, 0, msg.Length);
                    Console.WriteLine("Sent: {0}", data);            
                }

                // Shutdown and end connection
                client.Close();
            }
        }
        catch(SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
           // Stop listening for new clients.
           server.Stop();
        }

        Console.WriteLine("\nHit enter to continue...");
        Console.Read();
    }  
     */
    #endregion

    #region RabbitMQ(example of networking)*
    /*
    public static void Main()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "hello",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            string message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: "hello",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine(" [x] Sent {0}", message);
        }
    }*/
    #endregion

    #region Tasks of multithreading and parallelism.
    /*
        using System;
        using System.Threading.Tasks;

        class Program
        {
            static void Main()
            {
                // Создание и запуск двух задач, которые выполняются параллельно
                Task task1 = Task.Run(() => DoWork(1));
                Task task2 = Task.Run(() => DoWork(2));

                // Ожидание завершения обеих задач
                Task.WaitAll(task1, task2);
            }

            static void DoWork(int taskNumber)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Task {taskNumber} is working");
                    Task.Delay(1000).Wait(); // Имитация работы
                }
            }
        }

    */
    #endregion
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
