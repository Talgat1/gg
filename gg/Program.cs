using System;
using System.Collections.Generic;
using System.Linq;

namespace gg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список товара:");
            List<Tovar> t = new List<Tovar>();
            t.Add(new Tovar() { Id = 1001, Name = "Юла", Opisanie = "Разноцветная", Proizvod = "Татпромгаз", Price = 400, Activity = "Да" });
            t.Add(new Tovar() { Id = 1002, Name = "Мяч", Opisanie = "Футбольный", Proizvod = "Татпромгаз", Price = 200, Activity = "Да" });
            t.Add(new Tovar() { Id = 1003, Name = "Меч", Opisanie = "Железный", Proizvod = "Роснефть", Price = 500, Activity = "Нет" });
            t.Add(new Tovar() { Id = 1004, Name = "Лук", Opisanie = "Деревянный", Proizvod = "Татпромгаз", Price = 3000, Activity = "Нет" });
            t.Add(new Tovar() { Id = 1004, Name = "Катер", Opisanie = "Деревянный", Proizvod = "Роснефть", Price = 400, Activity = "Нет" });
            foreach (Tovar tov in t)
            {
                Console.WriteLine(tov);
            }
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1- Найти товар по названию и описанию");
            Console.WriteLine("2- Сортировка товара по возрастанию цены");
            Console.WriteLine("3- Сортировка товара по убыванию цены");
            //int cam = Convert.ToInt32(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out var cam))
            {
                Console.WriteLine("Ошибка, введите число!");
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
                            //Console.WriteLine($"{p.Name} + {p.Id} ");
                            Console.WriteLine($"Номер(Id): {p.Id}, Наименование: {p.Name}, Описание: {p.Opisanie}, Производитель: {p.Proizvod}, Цена: {p.Price}руб., Активный:{p.Activity}");
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
                Console.WriteLine("Введите количество товара:");
                if (!int.TryParse(Console.ReadLine(), out var call))
                {
                    Console.WriteLine("Ошибка, введите число!");
                }
                else
                {
                    Console.WriteLine("Выберите вид оплаты:");
                    Console.WriteLine("1- Банковскаякарта");
                    Console.WriteLine("2- Google pay");
                    Console.WriteLine("3- Apple pay");
                    if (!int.TryParse(Console.ReadLine(), out var plata))
                    {
                        Console.WriteLine("Ошибка, введите число!");
                    }
                    else
                    {
                        Console.WriteLine("Введите ФИО и телефон");
                        string fioPhone = Console.ReadLine();
                        Console.WriteLine("Выберите вид доставки:");
                        Console.WriteLine("1- Самовывоз");
                        Console.WriteLine("2- Доставка");
                        Console.WriteLine("3- Срочная доставка");
                        if (!int.TryParse(Console.ReadLine(), out var dostavka))
                        {
                            Console.WriteLine("Ошибка, введите число!");
                        }
                        else
                        {
                            //int phone = Convert.ToInt32(Console.ReadLine());
                            if (dostavka == 2 || dostavka == 3)
                            {
                                Console.WriteLine("Введите адрес(улица, дом квартира):");
                                string adres = Console.ReadLine();
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
