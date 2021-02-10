using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            //_car = new List<Car>

            //{
            //    new Car{Id=1, BrandId=111, ColorId=11121, DailyPrice=950, ModelYear=2015, Description="Audi"},
            //    new Car{Id=2, BrandId=222, ColorId=22212, DailyPrice=550, ModelYear=2013, Description="Renault"},
            //    new Car{Id=3, BrandId=333, ColorId=33323, DailyPrice=150, ModelYear=1990, Description="Tofaş Şahin"},
            //    new Car{Id=4, BrandId=444, ColorId=44434, DailyPrice=700, ModelYear=2014, Description="BMW"},
            //    new Car{Id=5, BrandId=555, ColorId=55545, DailyPrice=1000, ModelYear=2020, Description="Mini Cooper"}

            //};
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.BrandId == car.BrandId);
            _car.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }
        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
