using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public static class Menu
    {
        delegate void Delwtf();
        public static void mainPanel()
        {
            Console.WriteLine("1. Войти в аккаунт");
            Console.WriteLine("2. Зарегистрироваться");
            Console.WriteLine("3. Выход");

            var choise = Int32.Parse(Console.ReadLine());


            switch (choise)
            {
                case 1:
                    authorization();
                    break;
                case 2:
                    registration();
                    break;
                case 3:
                    break;
            }
        }

        public static void authorization()
        {
            Console.Write("Введите логин: ");
            var login = Console.ReadLine().Trim();
            Console.Write("Введите пароль: ");
            var password = Console.ReadLine().Trim();

            var Users = WorkWithUsers.ReadXml();

            var currentUser = Users.User.Where(x => x.Login == login).Where(x => x.Password == password).FirstOrDefault();

            if(currentUser != null)
                switch (currentUser.Type)
                {
                    case "owner":
                        owner();
                        break;
                    case "user":
                        user(currentUser.Login);
                        break;
                    default:
                        Console.WriteLine("Пользователя не существует, либо неправильно введён логин и/или пароль.");
                        mainPanel();
                        break;
                }
            else
            {
                Console.WriteLine("Пользователя не существует, либо неправильно введён логин и/или пароль.");
                mainPanel();
            }
        }

        public static void registration()
        {
            Console.Write("Введите логин: ");
            var login = Console.ReadLine().Trim();
            Console.Write("Введите пароль: ");
            var password = Console.ReadLine().Trim();
            Console.Write("Выберите тип использования: \n1. Собственник \n2. Арендующий\n");
            var choise = Int32.Parse(Console.ReadLine());
            var userType = choise == 1 ? "owner" : "user";

            var user = new User
            {
                Login = login,
                Password = password,
                Type = userType
            };

            WorkWithUsers.WriteToXml(user);
            Console.WriteLine("Учётная запись успешно зарегистрировалась!\n");
            mainPanel();
        }

        public static void owner()
        {
            ownerPanel();

            var choise = Int32.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    addFlat();
                    break;
                case 2:
                    removeFlat();
                    break;
                case 3:
                    getStatistic();
                    break;
                case 4:
                    mainPanel();
                    break;
                case 5:
                    break;
            }
        }

        public static void ownerPanel()
        {
            Console.WriteLine("1. Добавить квартиру");
            Console.WriteLine("2. Удалить квартиру");
            Console.WriteLine("3. Просмотреть статистику просмотров квартир");
            Console.WriteLine("4. Вернуться в меню авторизации");
            Console.WriteLine("5. Выход");
        }

        public static void user(string userName)
        {
            userPanel();

            var choise = Int32.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    showFlatList(userName);
                    break;
                case 2:
                    showFlatsOrderByNumberRooms(userName);
                    break;
                case 3:
                    showFlatsOrderByViews(userName);
                    break;
                case 4:
                    showFlatsOrderByRegion(userName);
                    break;
                case 5:
                    mainPanel();
                    break;
                case 6:
                    break;
            }
        }

        public static void userPanel()
        {
            Console.WriteLine("1. Просмотреть доступные квартиры");
            Console.WriteLine("2. Поиск квартир по количеству комнат (по возрастанию)");
            Console.WriteLine("3. Поиск квартир по количеству просмотров(по популярности)");
            Console.WriteLine("4. Поиск квартир по регионам");
            Console.WriteLine("5. Вернуться в меню авторизации");
            Console.WriteLine("6. Выход");
        }

        public static void showFlatList(string userName)
        {
            var flats = WorkWithFlat.getFlatList();

            for (int i = 0; i < flats.Count; i++)
            {
                Console.WriteLine(i + ". " + flats[i].Name + "\n" + flats[i].Region + "\n" + flats[i].NumberRooms + "\n" + flats[i].Price + "\n" + flats[i].CountViews + "\n");
            }

            Console.WriteLine("Введите номер квартиры, чтобы сохранить её.");
            Console.WriteLine("Вернуться в меню пользователя (napishite)");
            Console.WriteLine("Выход (napishite)");

            var choise = Console.ReadLine().ToLower();
            int choiseNumber;
            bool isNumber;
            (isNumber, choiseNumber) = ExtensionMethods.isNumber(choise);

            if (isNumber)
            {
                WorkWithUsers.saveFlatToTxt(flats.ElementAt(choiseNumber), userName);
                WorkWithFlat.countViewsAdd(flats.ElementAt(choiseNumber));
            }
            else
            {

                if (choise.Contains("Ве"))
                    user(userName);
                else
                    Environment.Exit(0);
            }
        }

        public static void addFlat()
        {
            Delwtf add;
            add = WriteName;
            add();
            var name = Console.ReadLine();

            Console.Write("Введите регион: ");
            var region = Console.ReadLine();

            Console.Write("Введите кол-во комнат: ");
            var roomsNumber = Console.ReadLine();

            Console.Write("Введите цену:");
            var price = Console.ReadLine();

            Flat flat = new Flat
            {
                Code = "123123",
                Name = name,
                Region = region,
                NumberRooms = int.Parse(roomsNumber),
                Price = price,
                CountViews = 0
            };
            WorkWithFlat.AddFlat(flat);

            owner();
        }

        private static void WriteName()
        {
            Console.Write("Введите название: ");
        }

        public static void removeFlat()
        {
            var flats = WorkWithFlat.getFlatList();

            for (int i = 0; i < flats.Count; i++)
            {
                Console.WriteLine(i + ". " + flats[i].Name + "\n" + flats[i].Region + "\n" + flats[i].NumberRooms + "\n" + flats[i].Price + "\n" + flats[i].CountViews + "\n");
            }

            Console.WriteLine("Выберите квартиру, которую хотите удалить(цифра)");
            var choise = int.Parse(Console.ReadLine());

            WorkWithFlat.removeFlat(flats.ElementAt(choise));

            owner();
        }

        public static void getStatistic()
        {
            var flats = WorkWithFlat.getFlatList().OrderBy(c => c.CountViews).ToList();

            for (int i = 0; i < flats.Count; i++)
            {
                Console.WriteLine(i + "." + flats[i].Name + " Количество просмотров:" + flats[i].CountViews);
            }

            Console.WriteLine();
            Console.WriteLine("1. Вернуться в меню");
            Console.WriteLine("2. Выход");

            var choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    owner();
                    break;
                case "2":
                    break;
            }
        }

        public static void showFlatsOrderByNumberRooms(string userName)
        {
            var flats = WorkWithFlat.sortByRooms();
            for (int i = 0; i < flats.Count; i++)
            {
                Console.WriteLine(i + ". " + flats[i].Name + "\n" + flats[i].Region + "\n" + flats[i].NumberRooms + "\n" + flats[i].Price + "\n" + flats[i].CountViews + "\n");
            }

            Console.WriteLine("Введите номер квартиры, чтобы сохранить её.");
            Console.WriteLine("Вернуться в меню пользователя (napishite)");
            Console.WriteLine("Выход (napishite)");

            var choise = Console.ReadLine().ToLower();
            int choiseNumber;
            bool isNumber;
            (isNumber, choiseNumber) = ExtensionMethods.isNumber(choise);

            if (isNumber)
            {
                WorkWithUsers.saveFlatToTxt(flats.ElementAt(choiseNumber), userName);
                WorkWithFlat.countViewsAdd(flats.ElementAt(choiseNumber));
            }
            else
            {

                if (choise.Contains("ве"))
                    user(userName);
                else
                    Environment.Exit(0);
            }
        }

        public static void showFlatsOrderByViews(string userName)
        {
            var flats = WorkWithFlat.sortByViews();

            for (int i = 0; i < flats.Count; i++)
            {
                Console.WriteLine(i + ". " + flats[i].Name + "\n" + flats[i].Region + "\n" + flats[i].NumberRooms + "\n" + flats[i].Price + "\n" + flats[i].CountViews + "\n");
            }

            Console.WriteLine("Введите номер квартиры, чтобы сохранить её.");
            Console.WriteLine("Вернуться в меню пользователя (napishite)");
            Console.WriteLine("Выход (napishite)");

            var choise = Console.ReadLine().ToLower();
            int choiseNumber;
            bool isNumber;
            (isNumber, choiseNumber) = ExtensionMethods.isNumber(choise);

            if (isNumber)
            {
                WorkWithUsers.saveFlatToTxt(flats.ElementAt(choiseNumber), userName);
                WorkWithFlat.countViewsAdd(flats.ElementAt(choiseNumber));
            }
            else
            {

                if (choise.Contains("ве"))
                    user(userName);
                else
                    Environment.Exit(0);
            }
        }

        public static void showFlatsOrderByRegion(string userName)
        {
            var flats = WorkWithFlat.sortByRegion();

            for (int i = 0; i < flats.Count; i++)
            {
                Console.WriteLine(i + ". " + flats[i].Name + "\n" + flats[i].Region + "\n" + flats[i].NumberRooms + "\n" + flats[i].Price + "\n" + flats[i].CountViews + "\n");
            }

            Console.WriteLine("Введите номер квартиры, чтобы сохранить её.");
            Console.WriteLine("Вернуться в меню пользователя (napishite)");
            Console.WriteLine("Выход (napishite)");

            var choise = Console.ReadLine().ToLower();
            int choiseNumber;
            bool isNumber;
            (isNumber, choiseNumber) = ExtensionMethods.isNumber(choise);

            if (isNumber)
            {
                WorkWithUsers.saveFlatToTxt(flats.ElementAt(choiseNumber), userName);
                WorkWithFlat.countViewsAdd(flats.ElementAt(choiseNumber));
            }
            else
            {

                if (choise.Contains("ве"))
                    user(userName);
                else
                    Environment.Exit(0);
            }
        }
    }
}
