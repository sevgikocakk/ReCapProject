using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Car Manager-----------------\n");

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç Adı  {0}  aracın  modeli  {1}  aracın günlük fiyatı  {2} TL'dir.", car.Description,car.ModelYear,car.DailyPrice);
            }
        }
    }
}
