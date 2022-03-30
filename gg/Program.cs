using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace gg
{
    class Program
    {
        static void Main(string[] args)
        {
            int cc = 0;
            
            Console.WriteLine("Список товара:");
            List<Tovar> t = new List<Tovar>();
            t.Add(new Tovar() { Id = 1001, Name = "Юла", Opisanie = "Разноцветная", Proizvod = "Татпромгаз", Price = 400, Activity = "Да", Coll = 5 });
            t.Add(new Tovar() { Id = 1002, Name = "Мяч", Opisanie = "Футбольный", Proizvod = "Татпромгаз", Price = 200, Activity = "Да", Coll = 6 });
            t.Add(new Tovar() { Id = 1003, Name = "Меч", Opisanie = "Железный", Proizvod = "Роснефть", Price = 500, Activity = "Нет", Coll = 10 });
            t.Add(new Tovar() { Id = 1004, Name = "Лук", Opisanie = "Деревянный", Proizvod = "Татпромгаз", Price = 3000, Activity = "Нет", Coll = 5 });
            t.Add(new Tovar() { Id = 1005, Name = "Катер", Opisanie = "Деревянный", Proizvod = "Роснефть", Price = 400, Activity = "Нет", Coll = 15 });
            foreach (Tovar tov in t)
            {
                Console.WriteLine(tov);
            }
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1- Найти товар по названию и описанию");
            Console.WriteLine("2- Сортировка товара по возрастанию цены и фильтрация производителя");
            Console.WriteLine("3- Сортировка товара по убыванию цены и фильтрация производителя");
            //int cam = Convert.ToInt32(Console.ReadLine());
            if ((!int.TryParse(Console.ReadLine(), out var cam)) || cam < 1 || cam > 3)
            {
                Console.WriteLine("Ошибка, недопустимы диапазон!");
            }
            else
            {
                if (cam == 1)
                {
                    int b = 0;                   
                    Console.WriteLine("Введите название или описание товара:");
                    string s = Console.ReadLine();                   
                    var sorted1 = from p in t
                                        orderby p.Name, p.Opisanie
                                        select p;

                    foreach (var p in sorted1)
                    {
                        
                        if (s == p.Name || s == p.Opisanie)
                        {
                            cc = p.Coll;
                            //Console.WriteLine($"{p.Name} + {p.Id} ");
                            Console.WriteLine($"Номер(Id): {p.Id}, Наименование: {p.Name}, Описание: {p.Opisanie}, Производитель: {p.Proizvod}, Цена: {p.Price}руб., Активный:{p.Activity}, Количество:{p.Coll}");
                            b++;
                        }                        
                    }
                    if(b == 0)
                    {
                        Console.WriteLine("Такого товара нет!");
                    }
                }

                if (cam == 2)
                {
                    
                    var sorted2 = from p in t
                                         orderby p.Price, p.Proizvod
                                         select p;
                    foreach(var p in sorted2)
                        Console.WriteLine(p);  
                }

                if (cam == 3)
                {

                    var sorted2 = from p in t
                                  orderby p.Price descending, p.Proizvod
                                  select p;
                    foreach (var p in sorted2)
                        Console.WriteLine(p);
                }

                Console.WriteLine("Введите название товара для покупки:");
                string ss = Console.ReadLine();
                var sorted3 = from r in t
                              orderby r.Name
                              select r;

                foreach (var r in sorted3)
                {
                    if (ss == r.Name)
                    {
                        cc = r.Coll;
                        //Console.WriteLine($"{p.Name} + {p.Id} ");
                        Console.WriteLine($"Номер(Id): {r.Id}, Наименование: {r.Name}, Описание: {r.Opisanie}, Производитель: {r.Proizvod}, Цена: {r.Price}руб., Активный:{r.Activity}, Количество:{r.Coll}");                        
                    }
                }

                Console.WriteLine("Введите количество товара:");
                if ((!int.TryParse(Console.ReadLine(), out var call)) || call < 1 || call > cc)
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    Console.WriteLine("Выберите вид оплаты:");
                    Console.WriteLine("1- Банковскаякарта");
                    Console.WriteLine("2- Google pay");
                    Console.WriteLine("3- Apple pay");
                    Console.WriteLine("4- Наличные");
                    if ((!int.TryParse(Console.ReadLine(), out var plata)) ||plata < 1 || plata > 3)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        Console.WriteLine("Введите ваше ФИО и номер телефона");                        
                        string fioPh = Console.ReadLine();                        
                        Console.WriteLine("Выберите вид доставки:");
                        Console.WriteLine("1- Самовывоз");
                        Console.WriteLine("2- Доставка");
                        Console.WriteLine("3- Срочная доставка");
                        if ((!int.TryParse(Console.ReadLine(), out var dostavka)) ||  dostavka < 1 || dostavka > 3)
                        {
                            Console.WriteLine("Ошибка!");
                        }
                        else
                        {
                            //int phone = Convert.ToInt32(Console.ReadLine());
                            if (dostavka == 2 || dostavka == 3)
                            {
                                Console.WriteLine("Введите адрес(улица, дом квартира):");
                                string adres = Console.ReadLine();
                                Console.WriteLine("Заказ оформлен!");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");
                            }
                        }
                    }                    
                }
            }
        }
    }
}
