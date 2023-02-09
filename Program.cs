    using System;
namespace appraboteprokt
{
        public class Phone
        {
            private int number;
            private string model = "";
            private int weight;
            public void printArgs()
            {
                Console.Write(number);
                Console.Write(model);
                Console.Write(weight);
            }
            public void sendMessage(params string[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            public int getNumber()
            {
                return number;
            }
            public void recieveCall(string name)
            {
                Console.WriteLine("\n Звонит ");
                Console.Write(name);
            }
            public void recieveCall(string name, int number)
            {
                Console.WriteLine("\n Звонит ");
                Console.Write(name);
                Console.Write(number);
            }
            public Phone(int k, string m, int b) : this(k, m)
            {
                weight = b;
            }
            public Phone(int k, string m)
            {
                number = k;
                model = m;
                weight = 0;
            }
            public Phone()
            {
                number = 0;
                model = "";
                weight = 0;
            }
        }
        public static class Globals
        {
            public static int averageTemp(Seasons season)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return 5;
                    case Seasons.summer:
                        return 14;
                    case Seasons.autumn:
                        return 10;
                    case Seasons.winter:
                        return -40;
                }
                return 0;
            }
            public static string returnString(Seasons season)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return "Весна - хорошее время года.";
                    case Seasons.summer:
                        return "Лето - люблю это время года.";
                    case Seasons.autumn:
                        return "Осень - время школы.";
                    case Seasons.winter:
                        return "Зима — это время снега и холода.";
                }
                return "";
            }
            public static string returnString(Seasons season, Seasons temperature)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return "Я люблю весну";
                    case Seasons.summer:
                        return "Я люблю лето";
                    case Seasons.autumn:
                        return "Я люблю осень";
                    case Seasons.winter:
                        return "Я люблю зиму";
                }
                return "";
            }
            public static string getDescription(Seasons season)
            {
                if (season == Seasons.summer)
                {
                    return "Тёплое время года";
                }
                return "Холодное время года";
            }
            static void Main(string[] args)
            {
                Phone firstPhone = new Phone();
                Phone secondPhone = new Phone();
                Phone otherPhone = new Phone();
                Console.WriteLine(firstPhone.getNumber());
                firstPhone.recieveCall("\nРодион ");
                firstPhone.sendMessage("89885410271", "89012546107");
                Console.WriteLine(secondPhone.getNumber());
                secondPhone.recieveCall("\nРодион ");
                secondPhone.sendMessage("44", "89004175832");
                Console.WriteLine(otherPhone.getNumber());
                otherPhone.recieveCall("\nРодион ");
                otherPhone.sendMessage("78014571203", "89005885014");
                firstPhone.printArgs();
                secondPhone.printArgs();
                otherPhone.printArgs();
                firstPhone.recieveCall("Родион ", 24702773);
                Person firstPerson = new Person();
                Person secondPerson = new Person(44, " Оля");
                firstPerson.move();
                firstPerson.talk();
                secondPerson.move();
                secondPerson.talk();
                Console.Write(getDescription(Seasons.spring));
                Console.Write(getDescription(Seasons.summer));
                Console.Write(getDescription(Seasons.autumn));
                Console.Write(getDescription(Seasons.winter));
                Console.Write(averageTemp(Seasons.spring));
                Console.Write(averageTemp(Seasons.summer));
                Console.Write(averageTemp(Seasons.autumn));
                Console.Write(averageTemp(Seasons.winter));
                Console.Write(returnString(Seasons.spring));
                Console.Write(returnString(Seasons.summer));
                Console.Write(returnString(Seasons.autumn));
                Console.Write(returnString(Seasons.winter));
            }
        }


        public class Person
        {
            private string fullName = "";
            private int age;
            public Person()
            {
                fullName = " Неопределённо";
                age = 0;
            }
            public Person(int l, string m)
            {
                fullName = m;
                age = l;
            }
            public void move()
            {
                Console.Write(fullName);
                Console.Write(" двигается");
            }
            public void talk()
            {
                Console.Write(fullName);
                Console.Write(" говорит ");
            }
        }
        public enum Seasons
        {
            spring = 0,
            summer = 1,
            autumn = 2,
            winter = 3,
            springTemperature = 5,
            summerTemperature = 14,
            autumnTemperature = 10,
            winterTemperature = -40,
        }

    }