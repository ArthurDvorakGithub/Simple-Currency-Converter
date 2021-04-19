using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double totalEuro = 350;
        double totalUsd = 500;
        double totalRub = 30000;
        double EuroToUsd = 1.1;
        double EuroToRub = 75;
        double UsdToRub = 63;
        double UsdToEuro = 0.9;
        double RubToUsd = 0.015;
        double RubToEuro = 0.014;
        double exchange;
        double refill;
        double cut;
        string currency;
        string operation;


        Console.WriteLine("Введите номер операции, которую планируюете совершить:");
        Console.WriteLine("Посмотреть баланс вашего счета - 1");
        Console.WriteLine("Снять деньги с вашего счета - 2");
        Console.WriteLine("Пополнить ваш счет - 3");
        Console.WriteLine("Сконвертировать ваш счет - 4");
        Console.WriteLine("Выйти из программы - 5");

        operation = Console.ReadLine();



        switch (operation)
        {
            case "1":

                Console.WriteLine("У Вас на счету " + totalEuro + " евро");
                Console.WriteLine("У Вас на счету " + totalUsd + " долларов ");
                Console.WriteLine("У Вас на счету " + totalRub + " рублей");
                Console.WriteLine("Нажмите любую клавишу чтобы выйти из программы");
                Console.ReadKey();
                Console.Clear();
                break;

            case "2":

                Console.Write("Введите колличество для снятия со счета:");
                cut = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите валюту:");
                Console.WriteLine("Usd");
                Console.WriteLine("Rub");
                Console.WriteLine("Euro");
                currency = Console.ReadLine().ToLower();

                if (currency == "usd" && totalUsd >= cut)
                {
                    totalUsd -= cut;
                    Console.Write("Заберите Ваши деньги. У Вас осталось " + totalUsd + " долларов.");
                }
                if (currency == "euro" && totalEuro >= cut)
                {
                    totalEuro -= cut;
                    Console.Write("Заберите Ваши деньги. У Вас осталось " + totalEuro + " евро.");
                }
                if (currency == "rub" && totalRub >= cut)
                {
                    totalRub -= cut;
                    Console.Write("Заберите Ваши деньги. У Вас осталось " + totalEuro + " рублей.");
                }
                if (totalRub < cut || totalEuro < cut || totalUsd < cut)
                {
                    Console.Write("У Вас недостаточно средств!");
                }
                Console.WriteLine("Нажмите любую клавишу чтобы выйти из программы");
                Console.ReadKey();

                break;

            case "3":

                Console.Write("Введите колличество на которое хотите пополнить:");
                refill = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите валюту:");
                Console.WriteLine("Usd");
                Console.WriteLine("Rub");
                Console.WriteLine("Euro");
                currency = Console.ReadLine().ToLower();

                if (currency == "usd")
                {
                    totalUsd += refill;
                    Console.Write("У Вас теперь на счету " + totalUsd + " долларов.");
                }
                if (currency == "euro")
                {
                    totalEuro += refill;
                    Console.Write("У Вас теперь на счету " + totalEuro + " евро.");
                }
                if (currency == "rub")
                {
                    totalRub += refill;
                    Console.Write("У Вас теперь на счету " + totalRub + " рублей.");
                }


                Console.WriteLine("Нажмите любую клавишу чтобы продолжить работу в программе");
                Console.ReadKey();

                break;

            case "4":

                Console.WriteLine("Kакую операцию Вы хотите выполнить?:");
                Console.WriteLine(" EuroToUsd");
                Console.WriteLine(" EuroToRub");
                Console.WriteLine(" UsdToRub");
                Console.WriteLine(" UsdToEuro");
                Console.WriteLine(" RubToUsd");
                Console.WriteLine(" RubToEuro");
                Console.Write("Введите название операции:");
                operation = Console.ReadLine().ToLower();

                Console.WriteLine("Введите какое кол-во Вы хотите сконвертировать:");
                exchange = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case "eurotousd":

                        if (exchange <= totalEuro)
                        {
                            totalEuro -= exchange;
                            exchange *= EuroToUsd;
                            totalUsd += exchange;
                            Console.WriteLine("У вас теперь" + totalEuro + " евро и" + totalUsd + "долларов");
                        }
                        if (exchange > totalEuro)
                        {
                            Console.WriteLine("У вас недостаточно средств.\nНажмите любую клавишу чтобы выйти из программы.");
                            Console.ReadKey();
                        }

                        break;

                    case "eurotorub":

                        if (exchange <= totalEuro)
                        {
                            totalEuro -= exchange;
                            exchange *= EuroToRub;
                            totalRub += exchange;
                            Console.WriteLine("У вас теперь" + totalEuro + " евро и" + totalRub + "рублей");
                        }
                        if (exchange > totalEuro)
                        {
                            Console.WriteLine("У вас недостаточно средств.\nНажмите любую клавишу чтобы выйти из программы.");
                            Console.ReadKey();
                        }

                        break;

                    case "usdtorub":

                        if (exchange <= totalUsd)
                        {
                            totalUsd -= exchange;
                            exchange *= UsdToRub;
                            totalRub += exchange;
                            Console.WriteLine("У вас теперь" + totalUsd + " долларов и" + totalRub + " рублей");
                        }
                        if (exchange > totalUsd)
                        {
                            Console.WriteLine("У вас недостаточно средств.\nНажмите любую клавишу чтобы выйти из программы.");
                            Console.ReadKey();
                        }

                        break;

                    case "usdtoeuro":

                        if (exchange <= totalUsd)
                        {
                            totalUsd -= exchange;
                            exchange *= UsdToEuro;
                            totalEuro += exchange;
                            Console.WriteLine("У вас теперь" + totalUsd + " долларов и" + totalEuro + " евро");
                        }
                        if (exchange > totalUsd)
                        {
                            Console.WriteLine("У вас недостаточно средств.\nНажмите любую клавишу чтобы выйти из программы.");
                            Console.ReadKey();
                        }

                        break;

                    case "rubtousd":

                        if (exchange <= totalRub)
                        {
                            totalRub -= exchange;
                            exchange *= RubToUsd;
                            totalUsd += exchange;
                            Console.WriteLine("У вас теперь" + totalRub + " рублей и" + totalUsd + " долларов");
                        }
                        if (exchange > totalRub)
                        {
                            Console.WriteLine("У вас недостаточно средств.\nНажмите любую клавишу чтобы выйти из программы.");
                            Console.ReadKey();
                        }

                        break;

                    case "rubtoeuro":

                        if (exchange <= totalRub)
                        {
                            totalRub -= exchange;
                            exchange *= RubToEuro;
                            totalEuro += exchange;
                            Console.WriteLine("У вас теперь" + totalRub + " рублей и" + totalEuro + "евро");
                        }
                        if (exchange > totalRub)
                        {
                            Console.WriteLine("У вас недостаточно средств.\nНажмите любую клавишу чтобы выйти из программы.");
                            Console.ReadKey();
                        }

                        break;

                    default:

                        Console.WriteLine("Вы неправильно ввели запрос\nНажмите любую клавишу чтобы выйти из программы.");
                        Console.ReadKey();

                        break;
                }

                break;

            case "5":

                Console.Write("Нажмите любую клавишу чтобы выйти из программы");
                Console.ReadKey();
                Console.Clear();

                break;

            default:

                Console.Write("Нажмите любую клавишу чтобы продолжить работу");
                Console.ReadKey();

                break;
        }

    }
}