﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Utilites.Results;
using Business.Constants;
using Entities.DTOs;
using System.Linq.Expressions;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {

            _carDal = carDal;

        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.AddedCar);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedCar);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }


        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(filter));
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice < 0)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.UpdatedCar);
            }

            return new ErrorResult(Messages.FailedCar);

        }
    }
}
