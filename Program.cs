using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            User user1 = new User
            {
                FirsName = "Иван",
                LastName = "Сидоров",
                Number = 9616077530,
                Country = "Россия",
                MiddleName = "Викторивич",
                Birthday = "12.12.1996",
                Organization = "Сбер",
                Position = "Программист",
                Notes = "Нет Заметок"
            };
            User user2 = new User
            {
                FirsName = "Cемен",
                LastName = "Лабанов",
                Number = 9616058530,
                Country = "Россия",
                MiddleName = "Викторивич",
                Birthday = "10.11.1973",
                Organization = "Сбер",
                Position = "Программист",
                Notes = "Нет Заметок"
            };
            User user3 = new User
            {
                FirsName = "Дмитрий",
                LastName = "Горцев",
                Number = 9616066630,
                Country = "Россия",
                MiddleName = "Сергеевич",
                Birthday = "10.11.1963",
                Organization = "Сбер",
                Position = "Программист",
                Notes = "Нет Заметок"
            };


          

            do
            {

                Console.WriteLine("1-посмотреть все записи");
                Console.WriteLine("2-посмотреть запись");
                Console.WriteLine("3-удалить запись");
                Console.WriteLine("4-редактировать запись");
                Console.WriteLine("5-создать запись");
                Console.WriteLine("0-выйти");
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    if (x==0)
                    {
                        break;
                    }
                    Console.WriteLine();
                    Book.Command(x);

                }
                else
                {
                    Console.WriteLine("Ошибка ввода,введи цифру");
                }
            } while (x != 0);
        }
    }


    public static class Book
    {
        public static int count = 0;
        public static User[] users = null;


        public static void Command(int x)
        {

            if (x == 1)
            {
                ShowUsers();
            }
            else if (x == 2)
            {
                ShowUsers();
                int v;
                if (ChoiceID(out v))
                {
                    ShowUser(v);
                }
            }
            else if (x == 3)
            {
                ShowUsers();
                int d;
                if (ChoiceID(out d))
                {
                    DeleteUser(d);
                }

            }
            else if (x == 4)
            {
                ShowUsers();
                int r;
                if (ChoiceID(out r))
                {
                    RedactionUser(r);
                }
            }
            else if (x == 5)
            {


                CreateUser();
                ShowUsers();

            }

            else
            {
                Console.WriteLine("Нет такой команды");
            }
        }
        public static void CreateUser()
        {
            Console.Write("Введите имя: ");
            string FirstName = Console.ReadLine();
            Console.Write("Введите фамилия: ");
            string LastName = Console.ReadLine();
            Console.Write("Введите номер: ");
            int number, nomer = 0;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    nomer = number;
                    break;
                }
                else { Console.WriteLine("Введите цифры: "); }

            } while (true);

            Console.Write("Введите отчество: ");
            string MiddleName = Console.ReadLine();
            Console.Write("Введите страну: ");
            string Country = Console.ReadLine();
            Console.Write("Введите день рождения: ");
            string Birthday = Console.ReadLine();
            Console.Write("Введите организация: ");
            string Organization = Console.ReadLine();
            Console.Write("Введите должность: ");
            string Position = Console.ReadLine();
            Console.Write("Введите заметки: ");
            string Notes = Console.ReadLine();

            new User
            {
                FirsName = FirstName,
                LastName = LastName,
                Number = nomer,
                Country = Country,
                MiddleName = MiddleName,
                Birthday = Birthday,
                Organization = Organization,
                Position = Position,
                Notes = Notes
            };
        }
        public static void RedactionUser(int r)
        {
            ShowUser(r);
            int x;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    if (0 <= x && x < 10)
                    {
                        if (x == 0)
                        {
                            return;
                        }
                        if (x == 1)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].LastName = Console.ReadLine();
                            ShowUser(r);
                        }
                        else if (x == 2)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].FirsName = Console.ReadLine();
                            ShowUser(r);
                        }

                        else if (x == 3)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].MiddleName = Console.ReadLine();
                            ShowUser(r);
                        }
                        else if (x == 4)
                        {
                            int number;
                            Console.WriteLine("Введите новое значение:");
                            if (Int32.TryParse(Console.ReadLine(), out number))
                                users[r].Number = number;
                            else Console.WriteLine("Введите цифры");
                            ShowUser(r);
                        }
                        else if (x == 5)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].Country = Console.ReadLine();
                            ShowUser(r);
                        }
                        else if (x == 6)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].Birthday = Console.ReadLine();
                            ShowUser(r);
                        }
                        else if (x == 7)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].Organization = Console.ReadLine();
                            ShowUser(r);
                        }
                        else if (x == 8)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].Position = Console.ReadLine();
                            ShowUser(r);
                        }
                        else if (x == 9)
                        {
                            Console.WriteLine("Введите новое значение:");
                            users[r].Notes = Console.ReadLine();
                            ShowUser(r);
                        }


                    }

                    else
                    {
                        Console.WriteLine("Введите число от 1 до 9,или 0 для выхода");
                    }


                }
                else
                {
                    Console.WriteLine("Ошибка ввода,введи цифру");
                }

            } while (x != 0);
        }


        public static bool ChoiceID(out int v)
        {

            while (true)
            {
                Console.WriteLine("Введите id или 9 для выхода");
                if (Int32.TryParse(Console.ReadLine(), out v))
                {

                    if (v < users.Length)
                    {
                        return true;
                    }
                    else if (v == 9)
                    {
                        return false;

                    }
                    else
                    {
                        Console.WriteLine("Нет такого пользователя");

                    }
                }

                else
                {
                    Console.WriteLine("Введите цифру");

                }
            }

        }
        public static void ShowUser(int id)
        {
            Console.WriteLine("ID:{0} 1)Фамилия:{1} 2)Имя:{2} 3)Отчество:{3} 4)Номер телефона:{4} \n 5)Страна:{5}" +
                "6)Дата рождения:{6} 7)Организация:{7} 8)Должность:{8} 9)Прочие заметки:{9}", users[id].id,
                users[id].LastName, users[id].FirsName, users[id].MiddleName, users[id].Number, users[id].Country,
                users[id].Birthday, users[id].Organization, users[id].Position, users[id].Notes);

        }
        public static void ShowUsers()
        {

            foreach (User item in users)
            {
                if (item != null)
                {
                    Console.WriteLine("ID:{0} Фамилия:{1} Имя:{2} Номер телефона:{3}", item.id, item.LastName, item.FirsName, item.Number);
                }
            }
        }

        public static void DeleteUser(int id)
        {
            users[id] = null;

        }


    }
    public class User
    {
        public int id;
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public long Number { get; set; }
        public string Country { get; set; }
        public string MiddleName { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string Birthday { get; set; }
        public string Notes { get; set; }
        public User()
        {

            if (Book.users == null)
            {
                SetId(Book.count);
                Book.users = new User[1];
                Book.users[Book.count] = this;
                Book.count++;

            }
            else
            {
                SetId(Book.count);
                Array.Resize(ref Book.users, Book.users.Length + 1);
                Book.users[Book.count] = this;
                Book.count++;
            }
        }

    }

}