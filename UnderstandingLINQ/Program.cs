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

            /*
            // LINQ方法
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); // 圆括号里的称为Lambda表达式，这里表示对集合的每一项进行规定,按照=>后的要求进行计算
            foreach (var car in bmws)
            {
                Console.WriteLine("BMW car: {0} {1}", car.Model, car.VIN); 
            }
            */

            /*
            // 创建一个排序的汽车列表(使用LINQ查询)
            var orderdsCars = from car in myCars
                              orderby car.Year descending
                              select car;

            foreach (var car in orderdsCars)
            {
                Console.WriteLine("Year of car: {0} {1} {2}", car.Model, car.VIN,car.Year);
            }
            */

            /*
            // 创建一个排序汽车列表(使用LINQ方法)
            var orderedCars = myCars.OrderByDescending(p => p.Year);

            foreach (var car in orderedCars)
            {
                Console.WriteLine("Year of car: {0} {1} {2}", car.Model, car.VIN, car.Year);
            }
            */

            /*
            // 选出第一项(LINQ方法)
            var firstBMW = myCars.OrderByDescending(p=>p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            /*
            // 判断所有元素是否全部符合某一要求(LINQ方法)
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012)); // myCars中所有元素是否符合表达式中的条件 
            */

            /*
            // 对车的价格进行批量操作
            myCars.ForEach(p => Console.WriteLine("Price before: {0} {1:c}", p.VIN, p.StickerPrice));
            myCars.ForEach(p => p.StickerPrice -= 3000); // 只用一行代码完成foreach并将价格减去3,000
            Console.WriteLine();
            myCars.ForEach(p => Console.WriteLine("Price after: {0} {1:c}", p.VIN, p.StickerPrice)); // 只用一行代码完成foreach并输出VIN和价格
            */

            /*
            // 检查车是否存在某个型号
            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            */

            /*
            // 求总价
            Console.WriteLine("{0:c}",myCars.Sum(p => p.StickerPrice));
            */


            // 
            Console.WriteLine(myCars.GetType());
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