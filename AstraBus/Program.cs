using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraBus
{
    class Program
    {
       
             public Random rand = new Random();
        static void Main(string[] args)
        {
            Bus bus = new Bus
            {
                kidsCityBus = 40,
                kidsExpressBus = 90,
                seniorCityBus = 90,
                seniorExpressBus = 180
            };


            Card firstCard = new Card
            {

                Name = "Айтеке",
                BalanceCard = 0,
                TypeCard = "Детский",
                TypeBus = "Express"
            };

            Card secondCard = new Card
            {
                Name = "Толеби",
                BalanceCard = 200,
                TypeCard = "Взрослый",
                TypeBus = "Express"
            };

            Card thirdCard = new Card
            {
                Name = "Казыбек",
                BalanceCard = 100,
                TypeCard = "Взрослый",
                TypeBus = "Городской"
            };
            /////////////////////////////////////////////////////////////////
            Console.WriteLine("First Card - " + firstCard.Name + ", " + firstCard.BalanceCard + "тг, " + firstCard.TypeBus + ", " + firstCard.TypeCard);
            if (firstCard.TypeCard == "Детский" && firstCard.TypeBus == "Express")
            {
                firstCard.BalanceCard = firstCard.BalanceCard - bus.kidsExpressBus;
                if (firstCard.BalanceCard > 0)
                {
                    Console.WriteLine("Валидация прошла успешно");
                    Console.WriteLine("Остаток = " + firstCard.BalanceCard);
                }
                else if (firstCard.BalanceCard < 0)
                {
                    Console.WriteLine("Недостаточно средств, оплатите наличными");
                }
            }

            Console.WriteLine("");
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("Second Card - " + secondCard.Name + ", " + secondCard.BalanceCard + "тг, " + secondCard.TypeBus + ", " + secondCard.TypeCard);

            secondCard.BalanceCard = secondCard.BalanceCard - bus.seniorCityBus;

            if (secondCard.TypeCard == "Взрослый" && secondCard.TypeBus == "Express")
            {
                secondCard.BalanceCard = secondCard.BalanceCard - bus.seniorCityBus;
                if (secondCard.BalanceCard > 0)
                {
                    Console.WriteLine("Валидация прошла успешно");
                    Console.WriteLine("Остаток = " + secondCard.BalanceCard);
                }
                else if (secondCard.BalanceCard < 0)
                {
                    Console.WriteLine("Недостаточно средств, оплатите наличными");
                }


            }
            Console.WriteLine("");
            /////////////////////////////////////////////////////////////0
            Console.WriteLine("Third Card - " + thirdCard.Name + ", " + thirdCard.BalanceCard + "тг, " + thirdCard.TypeBus + ", " + thirdCard.TypeCard);
            if (thirdCard.TypeCard == "Взрослый" && thirdCard.TypeBus == "Городской")
            {
                thirdCard.BalanceCard = thirdCard.BalanceCard - bus.seniorCityBus;
                if (thirdCard.BalanceCard > 0)
                {
                    Console.WriteLine("Валидация прошла успешно");
                    Console.WriteLine("Остаток = " + thirdCard.BalanceCard);
                }
                else if (thirdCard.BalanceCard < 0)
                {
                    Console.WriteLine("Недостаточно средств, оплатите наличными");
                }
            }
            Console.WriteLine("");




            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите ваш ИИН: ");
            string IIN = Console.ReadLine();

            Console.Write("Введите пополняемую сумму: ");
            int balanceCard = int.Parse(Console.ReadLine());

            Console.WriteLine("");


            Console.WriteLine("Мы определим ваш тариф");
            string typeCard = "";


            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 15)
            {
                typeCard = "Детский";
                Console.WriteLine("Ваш тариф: " + typeCard);

            }

            else if (age > 15)
            {
                typeCard = "Взрослый";
                Console.WriteLine("Ваш тариф: " + typeCard);

            }

            Console.WriteLine("");
            Random rand = new Random();
            string numberCard = Convert.ToString(rand.Next(10000000, 99999999));


            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Имя        : " + name);
            Console.WriteLine("Фамилия    : " + surname);
            Console.WriteLine("Возраст    : " + age);
            Console.WriteLine("ИИН        : " + IIN);
            Console.WriteLine("Баланс     : " + balanceCard);
            Console.WriteLine("Тариф      : " + typeCard);
            Console.WriteLine("Номер карты: " + numberCard);

            Console.WriteLine("----------------------------------------");




            if (typeCard == "Детский")
            {
                Console.WriteLine("Ознакомтесь со стоимостью проезда по вашему тарифу ");
                Console.WriteLine("Цены по тарифу - " + typeCard);
                Console.WriteLine("Городские маршруты: " + bus.kidsCityBus);
                Console.WriteLine("Express   маршруты: " + bus.kidsExpressBus);
                Console.WriteLine("----------------------------------------");
            }

            if (typeCard == "Взрослый")
            {
                Console.WriteLine("Ознакомтесь со стоимостью проезда по вашему тарифу ");
                Console.WriteLine("Цены по тарифу - " + typeCard);
                Console.WriteLine("Городские маршруты: " + bus.seniorCityBus);
                Console.WriteLine("Express   маршруты: " + bus.seniorExpressBus);
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("Выберите маршут на котором вы хотите проехаться: ");
            Console.WriteLine("1 - Городской маршрут");
            Console.WriteLine("2 - Express   маршрут");
            int busnum = int.Parse(Console.ReadLine());


            if (busnum == 1 && typeCard == "Детский")
            {
                balanceCard = balanceCard - bus.kidsCityBus;
                Console.WriteLine("Валидация прошла успешно");
                Console.WriteLine("Остаток баланса: " + balanceCard);
            }

            if (busnum == 2 && typeCard == "Детский")
            {
                balanceCard = balanceCard - bus.kidsCityBus;
                Console.WriteLine("Валидация прошла успешно");
                Console.WriteLine("Остаток баланса: " + balanceCard);
            }

            if (busnum == 1 && typeCard == "Взрослый")
            {
                balanceCard = balanceCard - bus.seniorCityBus;
                Console.WriteLine("Валидация прошла успешно");
                Console.WriteLine("Остаток баланса: " + balanceCard);
            }

            if (busnum == 2 && typeCard == "Взрослый")
            {
                balanceCard = balanceCard - bus.seniorExpressBus;
                Console.WriteLine("Валидация прошла успешно");
                Console.WriteLine("Остаток баланса: " + balanceCard);
            }

            Console.ReadKey();
        }
    }
}
