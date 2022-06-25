using System;
using System.Collections.Generic;

namespace Lab_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Cinema florencia = new Cinema("23.08.2001", 125, 4);
            Console.WriteLine(florencia);
            Console.WriteLine("Дата побудови: " + florencia.Date);
            Console.WriteLine("Вартiсть квитка (пiльговий): " + florencia.CountPrice(50, 3));
            Console.WriteLine("Вартiсть квитка (звичайний): " + florencia.CountPrice(50, 30));
            Console.WriteLine("Мiсткiсть: " + florencia.capacity());

            Hotel California = new Hotel("10.02.1987", 500, 8);
            Console.WriteLine("\n" + California);
            Console.WriteLine("Дата побудови: " + California.Date);
            Console.WriteLine("Вартiсть оренди: " + California.CountRent(125, 4, 12));
            Console.WriteLine("Мiсткiсть: " + California.capacity());

            PublicBuilding museum = new PublicBuilding("05.12.1962", 180, 3);
            Console.WriteLine("\n" + museum);
            Console.WriteLine("Дата побудови: " + museum.Date);
            Console.WriteLine("Вартiсть квитка (звичайний): " + museum.CountPrice(100, 34));
            Console.WriteLine("Вартiсть квитка (пiльговий): " + museum.CountPrice(100, 84));
            Console.WriteLine("Мiсткiсть: " + museum.capacity());

            ResidentialBuilding house = new ResidentialBuilding("26.01.2015", 175, 19);
            Console.WriteLine("\n" + house);
            Console.WriteLine("Дата побудови: " + house.Date);
            Console.WriteLine("Вартiсть оренди: " + house.CountRent(175, 45, 28));
            Console.WriteLine("Мiсткiсть: " + house.capacity());

            List<Building> building_list = new List<Building> { florencia, California, museum };
            City misto = new City(building_list);
            misto.show_building();
            misto.add_building(house);
            misto.show_building();
            misto.average_capacity();
        }
    }
}
