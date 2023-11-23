using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCreationIvan.Models;
using WorldCreationIvan.Models.Enums;

namespace WorldCreationIvan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            List<Region> regions = new List<Region>();

            Console.Write($"Введіть кількість регіоні для вводу: ");
            int.TryParse(Console.ReadLine(), out int sizeN);

            for(int i = 0; i < sizeN; i++)
            {
                Console.Write("Введіть назву регіона: ");
                string name = Console.ReadLine();

                Console.Write($"Введіть площину регіона: ");
                double.TryParse(Console.ReadLine(), out double square);

                Console.Write($"Введіть кількість людей на кілометр метр: ");
                double.TryParse(Console.ReadLine(), out double numberOfPeoplePerSquareMeter);

                Console.Write($"{(int)RegionType.Island}. Острів\n" +
                              $"{(int)RegionType.Peninsula}. Півострів\n" +
                              $"{(int)RegionType.Metric}. Материк\n" +
                              $"Оберіть тип регіона:");

                Enum.TryParse(Console.ReadLine(), out RegionType type);
                Region region = null;
                switch (type)
                {
                    case RegionType.Island:
                        {
                            region = new Island(name, square, numberOfPeoplePerSquareMeter);
                        }
                        break;
                    case RegionType.Peninsula:
                        {
                            region = new Peninsula(name, square, numberOfPeoplePerSquareMeter);
                        }
                        break;
                    case RegionType.Metric:
                        {
                            region = new Metric(name, square, numberOfPeoplePerSquareMeter);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Помилка!");
                            continue;
                        }
                }
                Console.WriteLine("Додано!\n\n");
                regions.Add(region);
            }

            Console.Clear();

            Union union = new Union("Test Union");
            Country country = new Country("Test Country", 100, 100);

            Console.WriteLine($"Усі регіони: ");

            for(int i = 0; i < regions.Count; i++)
            {
                union.AddRegion(regions[i]);
                country.AddRegion(regions[i]);
                Console.WriteLine(regions[i].ToString());
            }
            Console.WriteLine("\n\n");

            Cooperation cooperation = new Cooperation("Test cooperation", 100, 100);
            ((Interfaces.IRegionable)cooperation).AddRegion(country);

            Console.WriteLine("\n\n");

            Console.WriteLine(union.ToString());
            Console.WriteLine("\n\n");
            Console.WriteLine(country.ToString());
            Console.WriteLine("\n\n");
            Console.WriteLine(cooperation.ToString());
        }
    }
}
