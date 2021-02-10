using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {

            _carDal = carDal;

        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                Console.WriteLine("Araba başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba Başarıyla Silindi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        internal IEnumerable<Car> GetAllByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c=> c.ColorId == id);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c=> c.Id == id);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice <0)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba bilgileri güncellendi.");
            }
            else
            {
                Console.WriteLine("Geçerli fiyat bilgisi giriniz.");
            }
            
        }
    }
}
