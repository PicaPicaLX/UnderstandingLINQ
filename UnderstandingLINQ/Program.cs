using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() // 首先创建元素并归于List中
            {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };


            /*
            // 这是LINQ查询
            // var关键字表示不确定后面的字符属于何种变量，计算机决定其正确形式
            var bmws = from car in myCars // 在myCars中选择
                       where car.Make == "BMW" // 选出Make为BMW的车
                       && car.Year==2010
                       select car; // 选中

            foreach (var car in bmws) // 将刚刚选出的车遍历
            {
                Console.WriteLine("BMW car: {0} {1}", car.Model, car.VIN);
            }
            */

            // LINQ方法
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); // 这种方法被称为Lambda方法，只有在myCars中符合圆括号里条件的元素才会被添加进bmws里
            foreach (var car in bmws)
            {
                Console.WriteLine("BMW car: {0} {1}", car.Model, car.VIN); 
            }

            Console.ReadLine();

        }
    }


    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}