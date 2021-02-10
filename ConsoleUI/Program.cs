using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Car Manager-----------------\n");

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç Adı  {0}  aracın  modeli  {1}  aracın günlük fiyatı  {2} TL'dir.\n", car.Descriptions, car.ModelYear,car.DailyPrice);
            }

          



            foreach (var car in carManager.GetAllByBrandId(2))
            {
                Console.WriteLine("Marka ıd'si 2 olan arabalar: "+car.Descriptions);
            }

            foreach (var car  in carManager.GetAllByColorId(3))
            {
                Console.WriteLine("Araba rengi 3 olan arabalar :"+car.Descriptions);
            }

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}











        }
    }
}
