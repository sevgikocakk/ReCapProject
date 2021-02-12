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
            Console.WriteLine("-------------------------Rent A Car----------------------\n");

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Sistemde mevcut olan araçların listesi!\n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("### Araç Adı  {0}  aracın  modeli  {1}  aracın günlük fiyatı  {2} TL'dir.\n", car.Descriptions, car.ModelYear,car.DailyPrice);
            }

            Car car1 = new Car() {Name="NEW" ,ColorId = 3, BrandId = 4, Descriptions = "Dizel bakımlı.", DailyPrice = 220 ,ModelYear=2005};
            carManager.Add(car1);

            //Color color1 = new Color() { ColorName = "Fıstık Yeşili" };
            //colorManager.Add(color1);

            Brand brand1 = new Brand() { BrandName = "Ferrari" };
            brandManager.Add(brand1);

            












        }
    }
}
