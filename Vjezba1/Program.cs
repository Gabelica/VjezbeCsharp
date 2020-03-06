using System;
using System.Globalization;

namespace vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Zadatak1();
            result = Zadatak2();
            result = Zadatak3();
            Console.Read();

        }

        static int Zadatak1()
        {
            int a, b;
            Console.WriteLine("Unesi prvi broj: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Unesi drugi broj: ");
            int.TryParse(Console.ReadLine(), out b);
            var result = a / b;

            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu Currency jednako je {2}", a, b, result.ToString("C", CultureInfo.CurrentCulture)));
            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu Integer jednako je {2}", a, b, Convert.ToInt32(result)));
            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu Scientific jednako je {0:#.###e+00}", a, b, result));
            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu Fixed-point jednako je {2}", a, b, result.ToString("F", CultureInfo.InvariantCulture)));
            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu General jednako je {2}", a, b, result.ToString("G", CultureInfo.InvariantCulture)));
            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu Number jednako je {2}", a, b, result.ToString("N", CultureInfo.InvariantCulture)));
            Console.WriteLine(String.Format("{0} podjeljen sa {1} u formatu Hexadecimal jednako je {2}", a, b, result.ToString("X", CultureInfo.InvariantCulture)));
            return 0;
        }
        static int Zadatak2()
        {
            int a;
            long b = long.MaxValue;
            try
            {
                a = checked(Convert.ToInt32(b));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Dogodio se overflow");
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Bilo koji drugi");
            }
            return 0;
        }
        static int Zadatak3()
        {
            BankAccounts AccountList = new BankAccounts();
            for (var i = 0; i < 5; i++)
            {
                AccountList.Add(new BankAccount());
            }
            var exit = "";
            while (exit != "q")
            {
                ShowMenu();
                var input = Console.ReadLine();
                int choice;
                int.TryParse(input, out choice);
                switch (choice)
                {
                    case 1:
                        AccountList.Add(AddNewAccount());
                        break;
                    case 2:
                        AccountList.Add(new BankAccount());
                        break;
                    case 3:
                        AccountList.ShowAll();
                        break;
                    default:
                        Console.WriteLine("Hvala na koristenju");
                        exit = "q";
                        break;
                }
            }
            return 0;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - Unesi racun rucno , 2 - Unesi racun automatski");
            Console.WriteLine("3 - Prikazi sve racune , q - Izlaz");
            Console.WriteLine("=====================================================");
        }

        public static BankAccount AddNewAccount()
        {
            string AccNum;
            double AccBalance;
            Account AccType;
            Console.WriteLine("Unesi broj racuna: ");
            AccNum = Console.ReadLine();
            Console.WriteLine("Unesi stanje racuna: ");
            var Balance = Console.ReadLine();
            try
            {
                AccBalance = double.Parse(Balance);
                Console.WriteLine("Tip racuna: ");
                var type = Console.ReadLine();
                AccType = (Account)int.Parse(type);
            }
            catch
            {
                return new BankAccount();
            }
            return new BankAccount(AccNum, AccBalance, AccType);
        }
    }
}
