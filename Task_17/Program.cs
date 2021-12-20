using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                // Первый экземпляр
                Console.WriteLine("Первый экземпляр класса, номер счета - типа int, ввод данных пользователем, отсутствует обработка исключений");
                Account<int> account = new Account<int>();
                EnterNumber<int>(out int number1, out string number2);
                account.Number = number1;
                EnterBalance(out decimal balance);
                account.Balance = balance;
                EnterFullName(out string fullName);
                account.FullName = fullName;
                PrintData(account);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }

            {
                // Второй экземпляр
                Console.WriteLine("Второй экземпляр класса, номер счета - типа int, параметры счета задаются переданными в конструктор данными");
                Account<int> account = new Account<int> { Number = 4556, Balance = 6854652, FullName = "Петров Иван Васильевич" };
                PrintData(account);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine();

            }

            {
                // Третий экземпляр
                Console.WriteLine("Третий экземпляр класса, номер счета - типа string, ввод данных пользователем, отсутствует обработка исключений");
                Account<string> account = new Account<string>();
                EnterNumber<string>(out int number1, out string number2);
                account.Number = number2;
                EnterBalance(out decimal balance);
                account.Balance = balance;
                EnterFullName(out string fullName);
                account.FullName = fullName;
                PrintData(account);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }

            {
                // Четвертый экземпляр
                Console.WriteLine("Четвертый экземпляр класса, номер счета - типа string, параметры счета задаются переданными в конструктор данными");
                Account<string> account = new Account<string> ("B000454", 565781, "Васильев Иван Петрович");
                PrintData(account);
            }
            Console.ReadLine();
        }

        static void EnterNumber<T>(out int numberInt, out string numberString)
        {
            Console.Write("Введите номер счета: ");
            var type = typeof(T);
            int number1 = 0;
            string number2 = "";

            if (type == number1.GetType())
            {
                // отсутствует обработка исключений
                int number = Convert.ToInt32(Console.ReadLine());
                number1 = number;
            }
            else
            {
                if (type == number2.GetType())
                {
                    string number = Console.ReadLine();
                    number2 = number;
                }
            }
            numberInt = number1;
            numberString = number2;
        }

        static void EnterBalance(out decimal balance)
        {
            Console.Write("Введите баланс счета: ");
            // отсутствует обработка исключений
            balance = Convert.ToDecimal(Console.ReadLine());
        }

        static void EnterFullName(out string fullName)
        {
            Console.Write("Введите ФИО владельца: ");
            fullName = Console.ReadLine();
        }

        static void PrintData<T>(Account <T> account)
        {
            Console.WriteLine();
            Console.WriteLine("Данные счета:");
            Console.WriteLine("Номер счета - {0}", account.Number);
            Console.WriteLine("Баланс счета - {0}", account.Balance.ToString("C", new System.Globalization.CultureInfo("en-US")));
            Console.WriteLine("ФИО владельца счета - {0}", account.FullName);
        }
    }
    class Account<T>
    {
        private T number;
        private decimal balance;
        private string fullName;

        public T Number { get; set; }
        public decimal Balance { get; set; }
        public string FullName { get; set; }

        public Account(T number, decimal balance, string fullName)
        {
            Number = number;
            Balance = balance;
            FullName = fullName;
        }

        public Account() { }
    }
}
